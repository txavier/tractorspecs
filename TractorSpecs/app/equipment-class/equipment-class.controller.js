(function () {
    'use strict';

    angular
        .module('app')
        .controller('EquipmentClassController', EquipmentClassController);

    EquipmentClassController.$inject = ['$scope', '$routeParams', '$location', 'dataService'];

    function EquipmentClassController($scope, $routeParams, $location, dataService) {
        var vm = this;

        vm.makes = [];
        vm.classURL = '';
        vm.modelClick = modelClick;
        vm.makeClick = makeClick;

        activate();

        function activate() {

            vm.classURL = $routeParams.classURL;

            var makesClassSearchCriteria = {
                $expand: 'models($select=modelNumber,modelUrl)',
                $orderby: 'mfgName',
                $select: 'mfgLogoImg,mfgName,mfgURL',
                $filter: 'models/any(d:d/equipmentClass/classURL eq \'' + vm.classURL + '\')'
            };

            getMakes(makesClassSearchCriteria);
        }

        function makeClick(mfgURL) {
            $location.path('make/' + mfgURL);
        }

        function modelClick(mfgURL, modelUrl) {
            $location.path('make/' + mfgURL + '/model/' + modelUrl);
        }

        function getMakes(makesClassSearchCriteria) {
            return dataService.searchEntities('makes', makesClassSearchCriteria).then(function (data) {
                vm.makes = data;

                return vm.makes;
            });
        }

    }

})();