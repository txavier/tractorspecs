(function () {
    'use strict';

    angular
        .module('app')
        .controller('MakeController', MakeController);

    MakeController.$inject = ['$scope', '$routeParams', '$location', '$filter', 'dataService'];

    function MakeController($scope, $routeParams, $location, $filter, dataService) {
        var vm = this;

        vm.make = {};
        vm.models = [];
        vm.modelsCount = 0;
        vm.specificationsCount = 0;
        vm.mfgURL = '';
        vm.modelClick = modelClick;
        vm.firstModel = {};
        vm.classURL = '';
        vm.equipmentClasses = [];

        activate();

        function activate() {
            vm.classURL = $routeParams.classURL;

            vm.mfgURL = $routeParams.mfgURL;

            var makeSearchCriteria = {
                $filter: 'mfgURL eq \'' + vm.mfgURL + '\'',
                $select: 'makeId, mfgDesc, mfgLogoImg, mfgName'
            };

            getMake(makeSearchCriteria).then(function (data) {
                var modelSearchCriteria = {
                    currentPage: 1,
                    itemsPerPage: 1,
                    orderBy: 'modelNumber',
                    search: null,
                    searchFields: null,
                    $expand: 'equipmentClass($select=classURL,className)',
                    q: 'makeId eq ' + vm.make.makeId,
                    $select: 'modelNumber, modelUrl, equipmentClassId'
                };

                getModels(modelSearchCriteria).then(function (data) {
                    vm.firstModel = vm.models[0];

                    // If there is a classURL from the URL then use it.  Else we want to use the equipment class of the first
                    // model that is returned to use for this make.
                    var classURLToUse = (vm.classURL === '' || !vm.classURL) ? vm.firstModel.equipmentClass.classURL : vm.classURL;

                    var modelsSearchCriteria = {
                        currentPage: 1,
                        itemsPerPage: 99999,
                        orderBy: 'modelNumber',
                        search: null,
                        searchFields: null,
                        $expand: 'equipmentClass($select=className)',
                        $filter: 'makeId eq ' + vm.make.makeId + ' and equipmentClass/classURL eq \'' + classURLToUse + '\'',
                        fields: 'modelNumber, modelUrl'
                    };

                    getModels(modelsSearchCriteria);
                });

                // Get the equipment classes that are going to appear on the right side
                // of the page.
                getEquipmentClasses(vm.make.makeId);
            });
        }

        function getEquipmentClasses(makeId) {
            var modelSearchCriteria = {
                $filter: 'makeId eq ' + makeId,
                $expand: 'equipmentClass($select=className,classURL)',
                $select: 'modelId,equipmentClassId'
            };

            getModelsEquipmentClasses(modelSearchCriteria);
        }

        function modelClick(modelUrl) {
            $location.path('specs/' + vm.mfgURL + '/' + modelUrl);
        }

        function getModelsEquipmentClasses(modelSearchCriteria) {
            return dataService.searchEntities('models', modelSearchCriteria).then(function (data) {
                var modelsEquipmentClasses = data;

                // Get the unique equipment classes from the array of models that has been returned.
                var equipmentClassIds = uniqueBy(modelsEquipmentClasses, function (x) { return x.equipmentClassId });

                for (var i = 0; i < equipmentClassIds.length; i++) {
                    vm.equipmentClasses.push($filter('filter')(modelsEquipmentClasses, { equipmentClassId: equipmentClassIds[i] }, true)[0].equipmentClass);
                }
            });
        }

        // http://stackoverflow.com/questions/15125920/how-to-get-distinct-values-from-an-array-of-objects-in-javascript
        function uniqueBy(arr, fn) {
            var unique = {};
            var distinct = [];
            arr.forEach(function (x) {
                var key = fn(x);
                if (!unique[key]) {
                    distinct.push(key);
                    unique[key] = true;
                }
            });
            return distinct;
        }

        function getMake(makeSearchCriteria) {
            return dataService.searchEntities('makes', makeSearchCriteria).then(function (data) {
                vm.make = data[0];

                return vm.make;
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