(function () {
    'use strict';

    angular
        .module('app')
        .controller('HomeController', HomeController);

    HomeController.$inject = ['$scope', '$location', '$routeParams', 'dataService'];

    function HomeController($scope, $location, $routeParams, dataService) {
        var vm = this;

        vm.makesWithModelsCount = [];
        vm.models = [];
        vm.modelsCount = 0;
        vm.specificationsCount = 0;
        vm.makeClick = makeClick;

        activate();

        function activate() {
            var modelSearchCriteria = {
                currentPage: 1,
                itemsPerPage: 14,
                orderBy: 'date desc',
                search: null,
                searchFields: null,
                expand: null,
                q: null,
                fields: null
            };

            getMakesWithModelsCount();

            getModels(modelSearchCriteria);

            getModelsCount(modelSearchCriteria);

            getSpecificationsCount();
        }

        function makeClick(mfgURL) {
            $location.path('/make/' + mfgURL);
        }

        function getMakesWithModelsCount() {
            return dataService.getMakesWithModelsCount(26).then(function (data) {
                vm.makesWithModelsCount = data;

                return vm.makesWithModelsCount;
            });
        }

        function getModels(modelSearchCriteria) {
            return dataService.searchEntities('models', modelSearchCriteria).then(function (data) {
                vm.models = data;

                return vm.models;
            });
        }

        function getModelsCount(modelSearchCriteria) {
            return dataService.searchEntitiesCount('models', modelSearchCriteria).then(function (data) {
                vm.modelsCount = data;

                return vm.modelsCount;
            });
        }

        function getSpecificationsCount() {
            return dataService.searchEntitiesCount('specifications').then(function (data) {
                vm.specificationsCount = data;

                return vm.specificationsCount;
            });
        }
    }

})();