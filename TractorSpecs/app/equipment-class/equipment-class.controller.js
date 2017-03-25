(function () {
    'use strict';

    angular
        .module('app')
        .controller('EquipmentClassController', EquipmentClassController);

    EquipmentClassController.$inject = ['$scope', '$routeParams', '$location', 'dataService', 'seoService'];

    function EquipmentClassController($scope, $routeParams, $location, dataService, seoService) {
        var vm = this;

        vm.makes = [];
        vm.classURL = '';
        vm.modelClick = modelClick;
        vm.makeClick = makeClick;
        vm.equipmentClass = {};

        activate();

        function activate() {
            vm.classURL = $routeParams.classURL;

            var makesClassSearchCriteria = {
                $expand: 'models($select=modelNumber,modelUrl),models($filter=equipmentClass/classURL eq \'' + vm.classURL + '\')',
                $orderby: 'mfgName',
                $select: 'mfgLogoImg,mfgName,mfgURL',
                $filter: 'models/any(d:d/equipmentClass/classURL eq \'' + vm.classURL + '\')'
            };

            getMakes(makesClassSearchCriteria);

            var equipmentClassSearchCriteria = {
                $select: 'className',
                $filter: 'classURL eq \'' + vm.classURL + '\''
            };
            
            // Set the title of the html page.
            getEquipmentClass(equipmentClassSearchCriteria).then(function (data) {
                seoService.setTitle(vm.equipmentClass.className + ' Specifications');

                seoService.setDescription(vm.equipmentClass.className + ' specifications.');

                seoService.setKeywords(vm.equipmentClass.className);
            });
        }

        function getEquipmentClass(equipmentClassSearchCriteria) {
            return dataService.searchEntities('equipmentClasses', equipmentClassSearchCriteria).then(function (data) {
                vm.equipmentClass = data[0];

                return vm.equipmentClass;
            });
        }

        function makeClick(mfgURL) {
            $location.path('mfg/' + mfgURL);
        }

        function modelClick(mfgURL, modelUrl) {
            $location.path('/specs/' + mfgURL + '/' + modelUrl);
        }

        function getMakes(makesClassSearchCriteria) {
            return dataService.searchEntities('makes', makesClassSearchCriteria).then(function (data) {
                vm.makes = data;

                return vm.makes;
            });
        }

    }

})();