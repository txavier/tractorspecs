(function () {
    'use strict';

    angular
        .module('app')
        .controller('AboutController', AboutController);

    AboutController.$inject = ['$scope', 'seoService'];

    function AboutController($scope, seoService) {
        var vm = this;

        activate();

        function activate() {
            seoService.setTitle('About');
            seoService.setDescription('Tractor Specifications Website');
            seoService.setKeywords('Tractor Specifications');
        }
    }

})();