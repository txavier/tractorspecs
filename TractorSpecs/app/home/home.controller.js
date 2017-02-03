(function () {
    'use strict';

    angular
        .module('app')
        .controller('HomeController', HomeController);

    HomeController.$inject = ['$scope', '$routeParams', 'dataService'];

    function HomeController($scope, $routeParams, dataService) {
        var vm = this;

        vm.getMakesWithModelsCount = [];

        activate();

        function activate() {
            var makeSearchCriteria = {
                currentPage: 1,
                itemsPerPage: 30,
                orderBy: 'models.Count',
                search: null,
                searchFields: null,
                expand: null,
                q: null,
                fields: null
            };

            getMakesWithModelsCount();
        }

        function getMakesWithModelsCount() {
            return dataService.getMakesWithModelsCount().then(function (data) {
                vm.getMakesWithModelsCount = data;

                return vm.getMakesWithModelsCount;
            });
        }

    }

})();