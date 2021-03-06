﻿(function () {
    'use strict';

    angular
        .module('app')
        .controller('ModelController', ModelController);

    ModelController.$inject = ['$scope', '$routeParams', '$filter', '$q', '$location', 'dataService', 'seoService'];

    function ModelController($scope, $routeParams, $filter, $q, $location, dataService, seoService) {
        var vm = this;

        vm.model = {};
        vm.modelUrl = '';
        vm.specClasses = [];
        vm.getSpecClass = getSpecClass;
        vm.masterSpecClasses = [];
        vm.editClick = editClick;

        activate();

        function activate() {
            vm.modelUrl = $routeParams.modelUrl;
            vm.mfgURL = $routeParams.mfgURL;

            var modelSearchCriteria = {
                $filter: 'modelUrl eq \'' + vm.modelUrl + '\' and make/mfgURL eq \'' + vm.mfgURL + '\'',
                $expand: 'make($select=mfgLogoImg,mfgName,mfgURL),specifications($expand=specName)'
            };

            var promise1 = searchModels(modelSearchCriteria);

            var promises = [];
            
            promises.push(promise1);

            var specClassSearchCriteria = {
            }

            var promise2 = searchSpecClasses(specClassSearchCriteria);
            
            promises.push(promise2);

            $q.all(promises)
                .then(fillSpecClasses)
                .then(function (data) {
                    // Set the title of the page.
                    seoService.setTitle(vm.model.make.mfgName + ' ' + vm.model.modelNumber);

                    seoService.setKeywords(vm.model.make.mfgName + ' ' + vm.model.modelNumber +
                        ' specifications,specs, pictures, prices, data, horsepower, information, values');

                    seoService.setDescription('Tractor-Specs.com database listing for the ' + vm.model.make.mfgName + ' ' + vm.model.modelNumber
                        + ' Everything you need to know. Used Values, Specs, Pictures and More.');
            });
        }

        function editClick(modelId) {
            $location.path('/edit/' + modelId);
        }

        function fillSpecClasses() {
            for (var i = 0; i < vm.model.specifications.length; i++) {
                var specClassResultArray = $filter('filter')(vm.specClasses, { specClassID: vm.model.specifications[i].specName.specClassId }, true);

                vm.model.specifications[i].specName.specClass = specClassResultArray.length > 0 ? specClassResultArray[0] : null;

                if ($filter('filter')(vm.masterSpecClasses, { specClassID: vm.model.specifications[i].specName.specClassId }, true).length === 0) {
                    vm.masterSpecClasses.push(specClassResultArray[0]);
                }
            }
        }

        function getSpecClass(specClassId) {
            var result = $filter('filter')(vm.specClasses, { specClassID: specClassId }, true);

            return result;
        }

        function searchSpecClasses(specClassSearchCriteria) {
            return dataService.searchEntities('specClasses', specClassSearchCriteria).then(function (data) {
                vm.specClasses = data;

                return vm.model;
            });
        }

        function searchModels(modelSearchCriteria) {
            return dataService.searchEntities('models', modelSearchCriteria).then(function (data) {
                vm.model = data[0];

                return vm.model;
            });
        }

    }

})();