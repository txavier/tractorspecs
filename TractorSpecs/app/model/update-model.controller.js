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
        vm.specNames = [];

        activate();

        function activate() {

            vm.modelId = $routeParams.modelId;

            //var modelSearchCriteria = {
            //    $filter: 'modelId eq ' + vm.modelId,
            //    $expand: 'make($select=mfgLogoImg,mfgName),specifications($expand=specName)'
            //};

            //var promise1 = searchModels(modelSearchCriteria);

            var promise1 = getSpecificationsWithEmptySpecificationsByModelId(vm.modelId);

            var promises = [];
            
            promises.push(promise1);

            var specClassSearchCriteria = {
            }

            var promise2 = searchSpecClasses(specClassSearchCriteria);
            
            promises.push(promise2);

            var promise3 = searchSpecNames();

            promises.push(promise3);

            $q.all(promises).then(function (data) {
                fillSpecNames();

                fillSpecClasses();
            });
        }

        function getSpecificationsWithEmptySpecificationsByModelId(modelId) {
            return dataService.getSpecificationsWithEmptySpecificationsByModelId(modelId).then(function (data) {
                vm.model.specifications = data.value;

                return vm.model;
            });
        }

        function fillSpecNames() {
            for (var i = 0; i < vm.model.specifications.length; i++) {
                var specNameResultArray = $filter('filter')(vm.specNames, { specNameId: vm.model.specifications[i].specNameId }, true);

                vm.model.specifications[i].specName = specNameResultArray.length > 0 ? specNameResultArray[0] : null;
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

        function searchSpecNames(specNameSearchCriteria) {
            return dataService.searchEntities('specNames', specNameSearchCriteria).then(function (data) {
                vm.specNames = data;

                return vm.specNames;
            });
        }

        function searchSpecClasses(specClassSearchCriteria) {
            return dataService.searchEntities('specClasses', specClassSearchCriteria).then(function (data) {
                vm.specClasses = data;

                return vm.specClasses;
            });
        }

        //function searchSpecClasses(specNamesSearchCriteria) {
        //    return dataService.searchEntities('specNames', specNamesSearchCriteria).then(function (data) {
        //        vm.specNames = data;

        //        return vm.specNames;
        //    });
        //}

        function searchModels(modelSearchCriteria) {
            return dataService.searchEntities('models', modelSearchCriteria).then(function (data) {
                vm.model = data[0];

                return vm.model;
            });
        }

    }

})();