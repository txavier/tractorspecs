(function () {
    'use strict';

    angular
        .module('app')
        .controller('EquipmentClassesController', EquipmentClassesController);

    EquipmentClassesController.$inject = ['$scope', '$routeParams', '$location', 'dataService'];

    function EquipmentClassesController($scope, $routeParams, $location, dataService) {
        var vm = this;

        vm.equipmentClasses = [];
        vm.equipmentClassClick = equipmentClassClick;

        activate();

        function activate() {
            var equipmentClassesSearchCriteria = {
                $select: 'className,classURL',
                $expand: 'models($select=modelId)',
                $orderby: 'className'
            };

            searchEquipmentClasses(equipmentClassesSearchCriteria);
        }

        function equipmentClassClick(classUrl) {
            $location.path(`equipment-class/${classUrl}`);
        }

        function searchEquipmentClasses(equipmentClassesSearchCriteria) {
            return dataService.searchEntities('equipmentClasses', equipmentClassesSearchCriteria).then(function (data) {
                vm.equipmentClasses = data;

                return vm.equipmentClasses;
            });
        }

    }

})();