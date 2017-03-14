(function () {
    'use strict';

    angular
        .module('app')
        .controller('SearchController', SearchController);

    SearchController.$inject = ['$scope', '$routeParams', '$location', 'dataService'];

    function SearchController($scope, $routeParams, $location, dataService) {
        var vm = this;

        vm.makes = [];
        vm.models = [];
        vm.modelsCount = 0;
        vm.specificationsCount = 0;
        vm.mfgURL = '';
        vm.modelClick = modelClick;
        vm.searchTerm = '';
        vm.makeClick = makeClick;

        activate();

        function activate() {

            vm.searchTerm = $routeParams.searchTerm;

            var makeSearchCriteria = {
                $filter: 'contains(mfgName, \'' + vm.searchTerm + '\')',
                $select: 'makeId, mfgDesc, mfgLogoImg, mfgName, mfgURL'
            };

            getMakes(makeSearchCriteria);

            var modelSearchCriteria = {
                currentPage: 1,
                itemsPerPage: 99999,
                orderBy: 'modelNumber',
                search: null,
                searchFields: null,
                $expand: 'make($select=mfgURL)',
                q: 'contains(modelNumber, \'' + vm.searchTerm + '\')',
                $select: 'modelNumber, modelUrl'
            };

            getModels(modelSearchCriteria);
        }

        function makeClick(mfgURL) {
            $location.path('/mfg/' + mfgURL);
        }

        function modelClick(model) {
            $location.path('specs/' + model.make.mfgURL + '/' + model.modelUrl);
        }

        function getMakes(makeSearchCriteria) {
            return dataService.searchEntities('makes', makeSearchCriteria).then(function (data) {
                vm.makes = data;

                return vm.makes;
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