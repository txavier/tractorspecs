(function () {
    'use strict';

    angular
        .module('app')
        .factory('seoService', seoService);

    seoService.$inject = [];

    // http://stackoverflow.com/questions/12506329/how-to-dynamically-change-header-based-on-angularjs-partial-view
    function seoService() {
        var title = 'Default';

        var service = {
            getTitle: getTitle,
            setTitle: setTitle
        };

        return service;

        function setTitle(newTitle) {
            title = newTitle;
        }

        function getTitle() {
            return title;
        }

    }
})();