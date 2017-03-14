(function () {
    'use strict';

    angular
        .module('app')
        .controller('MakeController', MakeController);

    MakeController.$inject = ['$scope', '$routeParams', '$location', 'dataService'];

    function MakeController($scope, $routeParams, $location, dataService) {
        var vm = this;

        vm.make = {};
        vm.models = [];
        vm.modelsCount = 0;
        vm.specificationsCount = 0;
        vm.mfgURL = '';
        vm.modelClick = modelClick;

        activate();

        function activate() {

            vm.mfgURL = $routeParams.mfgURL;

            var makeSearchCriteria = {
                $filter: 'mfgURL eq \'' + vm.mfgURL + '\'',
                $select: 'makeId, mfgDesc, mfgLogoImg, mfgName'
            };

            getMake(makeSearchCriteria).then(function (data) {
                var modelSearchCriteria = {
                    currentPage: 1,
                    itemsPerPage: 99999,
                    orderBy: 'modelNumber',
                    search: null,
                    searchFields: null,
                    expand: null,
                    q: 'makeId eq ' + vm.make.makeId,
                    fields: 'modelNumber, modelUrl'
                };

                getModels(modelSearchCriteria);
            });
        }

        function modelClick(modelUrl) {
            $location.path('specs/' + vm.mfgURL + '/' + modelUrl);
        }

        function getMake(makeSearchCriteria) {
            return dataService.searchEntities('makes', makeSearchCriteria).then(function (data) {
                vm.make = data[0];

                return vm.make;
            });
        }

        function getModels(modelSearchCriteria) {
            return dataService.searchEntities('models', modelSearchCriteria).then(function (data) {
                vm.models = data;

                return vm.models;
            });
        }

    }

})();