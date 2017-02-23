(function () {
    'use strict';

    angular
        .module('app')
        .controller('UpdateModelController', UpdateModelController);

    UpdateModelController.$inject = ['$scope', '$routeParams', '$filter', '$q', 'dataService'];

    function UpdateModelController($scope, $routeParams, $filter, $q, dataService) {
        var vm = this;

        vm.model = {};
        vm.modelId = '';
        vm.specClasses = [];
        vm.getSpecClass = getSpecClass;
        vm.masterSpecClasses = [];
        vm.selectedSpecClass = {};
        vm.specifications = [];

        activate();

        function activate() {

            vm.modelId = $routeParams.modelId;

            var modelSearchCriteria = {
                $filter: 'modelId eq ' + vm.modelId,
                $expand: 'make($select=mfgLogoImg,mfgName),specifications($expand=specName)'
            };

            var promise1 = searchModels(modelSearchCriteria);

            var promises = [];
            
            promises.push(promise1);

            var specClassSearchCriteria = {
            }

            var promise2 = searchSpecClasses(specClassSearchCriteria);
            
            promises.push(promise2);

            $q.all(promises).then(fillSpecClasses).then(addNewSpecClasses);
        }

        function addNewSpecClasses() {
            for (var i = 0; i < vm.masterSpecClasses.length; i++) {
                // Get spec classes from the model for each master spec class.
                var specClassResultArray = $filter('filter')(vm.masterSpecClasses, { specClassID: vm.model.specifications[i].specName.specClassId }, true);

                var foundSpecifications = $filter('filter')(vm.model.specifications, { specClassId: vm.masterSpecClasses[i] }, true);

                // Get all spec names for this spec class
                var specNamesSearchCriteria = { $filter: `specClassId eq ${vm.masterSpecClasses[i].specClassID}` };

                searchSpecNames(specNamesSearchCriteria).then(function (data) {
                    var foundSpecNames = data;

                    for (var j = 0; j < foundSpecNames; j++) {
                        var modelSpecNames = $filter('filter')(vm.model.specifications, { specNameId: foundSpecNames[0].specNameId }, true);

                        // If that specName is not found in the models specifications then add a new empty
                        // specification to the models specifications array.
                        if (modelSpecNames.length === 0) {
                            var newSpecification = {
                                modelId: vm.model.modelId,
                                specNameId: foundSpecNames[0].specNameId
                            };

                            // Add empty specifications for spec classes.
                            vm.model.specifications.push(newSpecification);
                        }
                    }
                });
            }
        }

        function fillSpecClasses() {
            for (var i = 0; i < vm.model.specifications.length; i++) {
                var specClassResultArray = $filter('filter')(vm.specClasses, { specClassID: vm.model.specifications[i].specName.specClassId }, true);

                vm.model.specifications[i].specName.specClass = specClassResultArray.length > 0 ? specClassResultArray[0] : null;

                if ($filter('filter')(vm.masterSpecClasses, { specClassID: vm.model.specifications[i].specName.specClassId }, true).length === 0) {
                    vm.masterSpecClasses.push(specClassResultArray[0]);
                }
            }
        }

        function getSpecClass(specClassId) {
            var result = $filter('filter')(vm.specClasses, { specClassID: specClassId }, true);

            return result;
        }

        function searchSpecClasses(specClassSearchCriteria) {
            return dataService.searchEntities('specClasses', specClassSearchCriteria).then(function (data) {
                vm.specClasses = data;

                return vm.specClasses;
            });
        }

        function searchSpecClasses(specNamesSearchCriteria) {
            return dataService.searchEntities('specNames', specNamesSearchCriteria).then(function (data) {
                vm.specNames = data;

                return vm.specNames;
            });
        }

        function searchModels(modelSearchCriteria) {
            return dataService.searchEntities('models', modelSearchCriteria).then(function (data) {
                vm.model = data[0];

                return vm.model;
            });
        }

    }

})();