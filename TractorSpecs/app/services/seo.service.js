(function () {
    'use strict';

    angular
        .module('app')
        .factory('seoService', seoService);

    seoService.$inject = [];

    // http://stackoverflow.com/questions/12506329/how-to-dynamically-change-header-based-on-angularjs-partial-view
    function seoService() {
        var title = 'Default';
        var description = null;
        var keywords = null;

        var service = {
            getTitle: getTitle,
            setTitle: setTitle,
            getDescription: getDescription,
            setDescription: setDescription,
            getKeywords: getKeywords,
            setKeywords: setKeywords
        };

        return service;

        function setTitle(newTitle) {
            title = newTitle;
        }

        function getTitle() {
            return title;
        }

        function setDescription(newDescription) {
            description = newDescription;
        }

        function getDescription() {
            return description;
        }

        function setKeywords(newKeywords) {
            keywords = newKeywords;
        }

        function getKeywords() {
            return keywords;
        }

    }
})();