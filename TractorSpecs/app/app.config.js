﻿(function () {
    'use strict';

    angular
        .module('app')
        .config(config);

    config.$inject = ['$routeProvider', '$locationProvider', '$httpProvider'];

    function config($routeProvider, $locationProvider, $httpProvider) {
        // Configure the security token bearer interceptor.
        $httpProvider.interceptors.push('authInterceptorService');

        $locationProvider.html5Mode(true);

        $routeProvider
            .when('/search.aspx', {
                redirectTo: 'search'
            })
            .when('/search/:searchTerm', {
                title: 'Search',
                templateUrl: 'app/search/search.html',
                controller: 'SearchController',
                controllerAs: 'vm'
            })
            .when('/search', {
                title: 'Search',
                templateUrl: 'app/search/search.html',
                controller: 'SearchController',
                controllerAs: 'vm'
            })
            .when('/contact-us', {
                title: 'Contact Us',
                templateUrl: 'app/contact-us/contact-us.html',
                controller: 'ContactUsController',
                controllerAs: 'vm'
            })
            .when('/about.aspx', {
                redirectTo: 'about'
            })
            .when('/about', {
                title: 'About',
                templateUrl: 'app/about/about.html',
                controller: 'AboutController',
                controllerAs: 'vm'
            })
            .when('/categories.aspx', {
                redirectTo: 'categories'
            })
            .when('/categories', {
                title: 'Categories',
                templateUrl: 'app/equipment-class/equipment-classes.html',
                controller: 'EquipmentClassesController',
                controllerAs: 'vm'
            })
            .when('/class.aspx', {
                redirectTo: 'class',
            })
            .when('/class/:classURL', {
                title: 'Class',
                templateUrl: 'app/equipment-class/equipment-class.html',
                controller: 'EquipmentClassController',
                controllerAs: 'vm'
            })
             .when('/allmakes.aspx', {
                 redirectTo: 'Brands'
             })
            .when('/allmakes', {
                title: 'Brands',
                templateUrl: 'app/make/makes.html',
                controller: 'MakesController',
                controllerAs: 'vm'
            })
            .when('/edit.aspx', {
                redirectTo: 'Edit'
            })
            .when('/edit/:modelId', {
                title: 'Edit',
                templateUrl: 'app/model/update-model.html',
                controller: 'UpdateModelController',
                controllerAs: 'vm'
            })
            .when('/specs.aspx', {
                redirectTo: 'Specifications'
            })
            .when('/specs/:mfgURL/:modelUrl', {
                title: 'Specifications',
                templateUrl: 'app/model/model.html',
                controller: 'ModelController',
                controllerAs: 'vm'
            })
            .when('/mfg.aspx', {
                redirectTo: 'Manufacturers'
            })
            .when('/mfg/:mfgURL/:classURL', {
                title: 'Manufacturers',
                templateUrl: 'app/make/make.html',
                controller: 'MakeController',
                controllerAs: 'vm'
            })
            .when('/mfg/:mfgURL', {
                title: 'Manufacturers',
                templateUrl: 'app/make/make.html',
                controller: 'MakeController',
                controllerAs: 'vm'
            })
            .when('/home', {
                title: 'Home',
                templateUrl: 'app/home/home.html',
                controller: 'HomeController',
                controllerAs: 'vm',
                redirectTo: ''
            })
            .when('/', {
                title: 'Home',
                templateUrl: 'app/home/home.html',
                controller: 'HomeController',
                controllerAs: 'vm'
            })
            .otherwise({ redirectTo: 'home' });

    }

})();