(function () {
    'use strict';

    angular
        .module('app')
        .controller('ModelController', ModelController);

    ModelController.$inject = ['$scope', '$routeParams', '$filter', '$q', 'dataService'];

    function ModelController($scope, $routeParams, $filter, $q, dataService) {
        var vm = this;

        vm.model = {};
        vm.modelUrl = '';
        vm.specClasses = [];
        vm.getSpecClass = getSpecClass;
        vm.masterSpecClasses = [];

        activate();

        function activate() {

            vm.modelUrl = $routeParams.modelUrl;

            var modelSearchCriteria = {
                $filter: 'modelUrl eq \'' + vm.modelUrl + '\'',
                $expand: 'make($select=mfgLogoImg,mfgName),specifications($expand=specName)'
            };

            var promise1 = searchModels(modelSearchCriteria);

            var promises = [];
            
            promises.push(promise1);

            var specClassSearchCriteria = {
            }

            var promise2 = searchSpecClasses(specClassSearchCriteria);
            
            promises.push(promise2);

            $q.all(promises).then(fillSpecClasses);
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

                return vm.model;
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