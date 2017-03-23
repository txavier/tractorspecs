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
        vm.getDescription = getDescription;
        vm.getKeywords = getKeywords;

        activate();

        function activate() {
        }

        function getKeywords() {
            var keywords = seoService.getKeywords()
                || 'tractor specs data info price used value engine trade';

            return keywords;
        }

        function getDescription() {
            var description = seoService.getDescription()
                || 'Specifications and information for tractors and all types of agricultural and industrial equipment.';

            return description;
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