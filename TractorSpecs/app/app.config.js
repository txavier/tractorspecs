(function () {
    'use strict';

    angular
        .module('app')
        .config(config);

    config.$inject = ['$routeProvider', '$locationProvider', '$httpProvider'];

    function config($routeProvider, $locationProvider, $httpProvider) {
        // Configure the security token bearer interceptor.
        $httpProvider.interceptors.push('authInterceptorService');

        $routeProvider
            .when('/equipment-classes', {
                templateUrl: 'app/equipment-class/equipment-classes.html',
                controller: 'EquipmentClassesController',
                controllerAs: 'vm'
            })
            .when('/equipment-class/:classURL', {
                templateUrl: 'app/equipment-class/equipment-class.html',
                controller: 'EquipmentClassController',
                controllerAs: 'vm'
            })
            .when('/makes', {
                templateUrl: 'app/make/makes.html',
                controller: 'MakesController',
                controllerAs: 'vm'
            })
            .when('/make/:mfgURL/model/:modelUrl', {
                templateUrl: 'app/model/model.html',
                controller: 'ModelController',
                controllerAs: 'vm'
            })
            .when('/make/:mfgURL', {
                templateUrl: 'app/make/make.html',
                controller: 'MakeController',
                controllerAs: 'vm'
            })
            .when('/dashboard', {
                templateUrl: 'app/user/dashboard.html',
                controller: 'DashboardController',
                controllerAs: 'vm'
            })
            .when('/update-blog-entry/:blogEntryId', {
                templateUrl: 'app/blog-entry/update-blog-entry.html',
                controller: 'UpdateBlogEntryController',
                controllerAs: 'vm'
            })
            .when('/add-blog-entry', {
                templateUrl: 'app/blog-entry/add-blog-entry.html',
                controller: 'AddBlogEntryController',
                controllerAs: 'vm'
            })
            .when('/view-blog-entry/:blogEntryId', {
                templateUrl: 'app/blog-entry/view-blog-entry.html',
                controller: 'ViewBlogEntryController',
                controllerAs: 'vm'
            })
            .when('/blog-entries', {
                templateUrl: 'app/blog-entry/blog-entries.html',
                controller: 'BlogEntriesController',
                controllerAs: 'vm'
            })
            .when('/home', {
                templateUrl: 'app/home/home.html',
                controller: 'HomeController',
                controllerAs: 'vm'
            })
            .otherwise({ redirectTo: 'home' });

    }

})();