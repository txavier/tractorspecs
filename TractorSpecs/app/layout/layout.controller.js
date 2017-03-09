(function () {
    'use strict';

    angular
        .module('app')
        .controller('LayoutController', LayoutController);

    LayoutController.$inject = ['$scope', '$routeParams', '$location', 'dataService'];

    function LayoutController($scope, $routeParams, $location, dataService) {
        var vm = this;

        vm.user = null;
        vm.equipmentTypesClick = equipmentTypesClick;
        vm.searchTerm = 'Search';
        vm.searchSubmit = searchSubmit;

        activate();

        function activate() {
        }

        function searchSubmit(searchTerm) {
            $location.path('/search/' + searchTerm);
        }

        function equipmentTypesClick() {
            $location.path(`/equipment-classes`);
        }

        function getLoggedInUser() {
            return dataService.getLoggedInUser().then(function (data) {
                vm.user = data.value;

                return vm.user;
            });
        }

    }

})();