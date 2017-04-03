(function () {
    'use strict';

    angular
        .module('app', [
            'ngRoute',
            'toaster',
            'angular-loading-bar',
            'ngAnimate',
            'ngSessionStorage',
            'textAngular',
            'ng-file-model',
            'angular-carousel'
        ]);

    // http://stackoverflow.com/questions/12506329/how-to-dynamically-change-header-based-on-angularjs-partial-view
    //angular
    //    .module('app')
    //    .run(['$rootScope', function ($rootScope) {
    //    $rootScope.$on('$routeChangeSuccess', function (event, current, previous) {
    //        if (current.$$route) {
    //            $rootScope.title = current.$$route.title;
    //        }
    //    });
    //}]);

})();

(function () {
    'use strict';

    //http://stackoverflow.com/questions/17063000/ng-model-for-input-type-file
    angular
        .module('app')
        .directive("fileread", [function () {
            return {
                scope: {
                    fileread: "="
                },
                link: function (scope, element, attributes) {
                    element.bind("change", function (changeEvent) {
                        var reader = new FileReader();
                        reader.onload = function (loadEvent) {
                            scope.$apply(function () {
                                scope.fileread = loadEvent.target.result;
                            });
                        }
                        reader.readAsDataURL(changeEvent.target.files[0]);
                    });
                }
            }
        }]);
})();
