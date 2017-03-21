(function () {
    'use strict';

    angular
        .module('app')
        .controller('LayoutController', LayoutController);

    LayoutController.$inject = ['$scope', '$routeParams', '$location', 'dataService', 'seoService'];

    function LayoutController($scope, $routeParams, $location, dataService, seoService) {
        var vm = this;

        vm.user = null;
        vm.equipmentTypesClick = equipmentTypesClick;
        vm.searchTerm = 'Search';
        vm.searchSubmit = searchSubmit;
        vm.getTitle = getTitle;

        activate();

        function activate() {
        }

        function getTitle() {
            var title = seoService.getTitle();

            return title;
        }

        function searchSubmit(searchTerm) {
            $location.path('/search/' + searchTerm);
        }

        function equipmentTypesClick() {
            $location.path('/categories');
        }

        function getLoggedInUser() {
            return dataService.getLoggedInUser().then(function (data) {
                vm.user = data.value;

                return vm.user;
            });
        }

    }

})();