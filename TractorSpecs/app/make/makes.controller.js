(function () {
    'use strict';

    angular
        .module('app')
        .controller('MakesController', MakesController);

    MakesController.$inject = ['$scope', '$routeParams', '$location', 'dataService', 'seoService'];

    function MakesController($scope, $routeParams, $location, dataService, seoService) {
        var vm = this;

        vm.makes = [];
        vm.makeClick = makeClick;

        activate();

        function activate() {
            seoService.setTitle('TractorSpecs Manufacturer Listing');
            seoService.setDescription('Listing of manufacturers represented on tractorspecs.com.');
            seoService.setKeywords('Tractor Companies');

            var makesSearchCriteria = {
                $select: 'makeId, mfgDesc, mfgLogoImg, mfgName, mfgURL',
                $expand: 'models($select=modelId)'
            };

            searchMakes(makesSearchCriteria);
        }

        function makeClick(mfgURL) {
            $location.path('mfg/' + mfgURL);
        }

        function searchMakes(makeSearchCriteria) {
            //return dataService.getMakesWithModelsCount().then(function(data) {
            return dataService.searchEntities('makes', makeSearchCriteria).then(function (data) {
                vm.makes = data;

                return vm.makes;
            });
        }

    }

})();