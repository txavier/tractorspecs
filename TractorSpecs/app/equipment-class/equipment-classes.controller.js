﻿(function () {
    'use strict';

    angular
        .module('app')
        .controller('EquipmentClassesController', EquipmentClassesController);

    EquipmentClassesController.$inject = ['$scope', '$routeParams', '$location', 'dataService', 'seoService'];

    function EquipmentClassesController($scope, $routeParams, $location, dataService, seoService) {
        var vm = this;

        vm.equipmentClasses = [];
        vm.equipmentClassClick = equipmentClassClick;

        activate();

        function activate() {
            seoService.setTitle('TractorSpecs Equipment Categories');
            seoService.setDescription('Equipment Categories to find specification for different models of equipment.');
            seoService.setKeywords('tractor equipment mower specification categories find models search');

            var equipmentClassesSearchCriteria = {
                $select: 'className,classURL',
                $expand: 'models($select=modelId)',
                $orderby: 'className'
            };

            searchEquipmentClasses(equipmentClassesSearchCriteria);
        }

        function equipmentClassClick(classURL) {
            $location.path('class/' + classURL);
        }

        function searchEquipmentClasses(equipmentClassesSearchCriteria) {
            return dataService.searchEntities('equipmentClasses', equipmentClassesSearchCriteria).then(function (data) {
                vm.equipmentClasses = data;

                return vm.equipmentClasses;
            });
        }

    }

})();