(function () {
    'use strict';

    angular
        .module('app')
        .controller('AboutController', AboutController);

    AboutController.$inject = ['$scope'];

    function AboutController($scope, $routeParams, $location, dataService) {
        var vm = this;

        activate();

        function activate() {
        }
    }

})();