﻿(function () {
    'use strict';

    angular
        .module('app')
        .controller('SearchController', SearchController);

    SearchController.$inject = ['$scope', '$routeParams', '$location', 'dataService', 'seoService'];

    function SearchController($scope, $routeParams, $location, dataService, seoService) {
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

            seoService.setTitle(vm.searchTerm + ' Search');

            var makeSearchCriteria = {
                $filter: createFilterFromSearchTerm(vm.searchTerm, 'mfgName'),
                $select: 'makeId, mfgDesc, mfgLogoImg, mfgName, mfgURL'
            };

            getMakes(makeSearchCriteria);

            var modelSearchCriteria = {
                currentPage: 1,
                itemsPerPage: 99999,
                orderBy: 'modelNumber',
                search: null,
                searchFields: null,
                $expand: 'make($select=mfgURL,mfgName)',
                $filter: createFilterFromSearchTerm(vm.searchTerm, 'modelNumber'),
                $select: 'modelNumber, modelUrl'
            };

            getModels(modelSearchCriteria);
        }

        function createFilterFromSearchTerm(searchTerm, fieldName) {
            var searchTerms = searchTerm.split(' ');

            var result = '';

            for (var i = 0; i < searchTerms.length; i++) {
                if (i > 0) {
                    result += ' or ';
                }

                result += 'contains(' + fieldName + ',\'' + searchTerms[i] + '\')';
            }

            return result;
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