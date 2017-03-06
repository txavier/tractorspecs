(function () {
    angular
        .module('app')
        .controller('contactUsController', contactUsController);

    contactUsController.$inject = ['$scope', '$routeParams', '$location', 'dataService', 'toaster'];

    function contactUsController($scope, $routeParams, $location, dataService, toaster) {
        var vm = this;

        vm.sendMessage = sendMessage;
        vm.emailInformation = {};

        activate();

        function activate() {
        }

        function sendMessage(emailInformation) {
            return dataService.sendMessage(emailInformation).then(function (data) {
                toaster.pop('success', 'Email has been sent successfully.');

                $location.path('/');
            }, function (error) {
                toaster.pop('warning', 'Email has not been sent because of an unidentified problem. Please try again later.');
            });
        }
    }

})();