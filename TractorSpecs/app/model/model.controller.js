(function () {
    'use strict';

    angular
        .module('app')
        .controller('ModelController', ModelController);

    ModelController.$inject = ['$scope', '$routeParams', 'dataService'];

    function ModelController($scope, $routeParams, dataService) {
        var vm = this;

        vm.model = {};
        vm.modelUrl = '';

        activate();

        function activate() {

            vm.modelUrl = $routeParams.modelUrl;

            var modelSearchCriteria = {
                $filter: 'modelUrl eq \'' + vm.modelUrl + '\'',
            };

            searchModels(modelSearchCriteria);
        }

        function searchModels(modelSearchCriteria) {
            return dataService.searchEntities('models', modelSearchCriteria).then(function (data) {
                vm.model = data[0];

                return vm.model;
            });
        }

    }

})();