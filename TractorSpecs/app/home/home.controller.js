(function () {
    'use strict';

    angular
        .module('app')
        .controller('HomeController', HomeController);

    HomeController.$inject = ['$scope', '$location', '$routeParams', '$window', 'dataService'];

    function HomeController($scope, $location, $routeParams, $window, dataService) {
        var vm = this;

        vm.makes = [];
        vm.models = [];
        vm.modelsCount = 0;
        vm.specificationsCount = 0;
        vm.makeClick = makeClick;
        vm.modelClick = modelClick;
        vm.linkClick = linkClick;
        vm.equipmentClassClick = equipmentClassClick;

        activate();

        function activate() {
            // http://docs.oasis-open.org/odata/odata/v4.0/os/part2-url-conventions/odata-v4.0-os-part2-url-conventions.html#_System_Query_Option_2
            var makesSearchCriteria = {
                $select: 'makeId, mfgDesc, mfgLogoImg, mfgName, mfgURL',
                $expand: 'models($select=modelId)',
                $top: 26
            };

            searchMakes(makesSearchCriteria);

            var modelSearchCriteria = {
                currentPage: 1,
                itemsPerPage: 14,
                orderBy: 'date desc',
                search: null,
                searchFields: null,
                includeProperties: 'make($select=mfgURL)',
                q: null,
                fields: null
            };

            getModels(modelSearchCriteria);

            getModelsCount(modelSearchCriteria);

            getSpecificationsCount();
        }

        function equipmentClassClick(equipmentClassUrl) {
            $location.path('/class/' + equipmentClassUrl);
        }

        function modelClick(model) {
            $location.path('/specs/' + model.make.mfgURL + '/' + model.modelUrl);
        }

        function linkClick(url) {
            $window.location.href = url;
        }

        function makeClick(mfgURL) {
            $location.path('/mfg/' + mfgURL);
        }

        function searchMakes(makeSearchCriteria) {
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