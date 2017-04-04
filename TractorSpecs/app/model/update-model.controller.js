(function () {
    'use strict';

    angular
        .module('app')
        .controller('UpdateModelController', UpdateModelController);

    UpdateModelController.$inject = ['$scope', '$routeParams', '$filter', '$q', 'dataService', 'seoService'];

    function UpdateModelController($scope, $routeParams, $filter, $q, dataService, seoService) {
        var vm = this;

        vm.model = {};
        vm.modelId = '';
        vm.specClasses = [];
        vm.getSpecClass = getSpecClass;
        vm.masterSpecClasses = [];
        vm.selectedSpecClass = {};
        vm.specifications = [];
        vm.specNames = [];
        vm.addOrUpdateReview = addOrUpdateReview;

        activate();

        function activate() {

            vm.modelId = $routeParams.modelId;

            var promise1 = getSpecificationsWithEmptySpecificationsByModelId(vm.modelId);

            var promises = [];
            
            promises.push(promise1);

            var specClassSearchCriteria = {}

            var promise2 = searchSpecClasses(specClassSearchCriteria);
            
            promises.push(promise2);

            var promise3 = searchSpecNames();

            promises.push(promise3);

            $q.all(promises).then(function (data) {
                fillSpecNames();

                fillSpecClasses();

                vm.selectedSpecClass = vm.specClasses[0];
            });

            var modelSearchCriteria = {
                $expand: 'make($select=mfgName,mfgURL)',
                $select: 'modelNumber,modelUrl',
                $filter: 'modelId eq ' + vm.modelId
            };

            getModel(modelSearchCriteria).then(function (data) {
                // Set the title of the page.
                seoService.setTitle('Edit listing for the ' + vm.model.make.mfgName + ' ' + vm.model.modelNumber);

                seoService.setDescription('Edit listing for the ' + vm.model.make.mfgName + ' ' + vm.model.modelNumber);

                seoService.setKeywords(vm.model.make.mfgName + ' ' + vm.model.modelNumber);
            });
        }

        function addOrUpdateReview(review) {
            return dataService.getClientIp().then(function (data) {
                review.ip = data;

                review.modelId = vm.model.modelId;

                review.reviewDate = new Date();

                // If this already exists then update it.
                if (review.reviewId) {
                    return dataService.updateEntity('reviews', review.reviewId, review).then(function (data) {
                        vm.review = data;
                    });
                }
                else {
                    return dataService.addEntity('reviews', review).then(function (data) {
                        vm.review = data;
                    });
                }
            });
        }

        function addOrUpdateLink(link) {
            return dataService.getClientIp().then(function (data) {
                link.IP = data;

                link.modelId = vm.model.modelId;

                // If this already exists then update it.
                if (link.linkId) {
                    return dataService.updateEntity('links', link.linkId, link).then(function (data) {
                        vm.link = data;
                    });
                }
                else {
                    return dataService.addEntity('links', link).then(function (data) {
                        vm.link = data;
                    });
                }
            });
        }

        function addOrUpdateModelPrice(modelPrice) {
            return dataService.getClientIp().then(function (data) {
                modelPrice.modelId = vm.model.modelId;

                modelPrice.date = new Date();

                // If this already exists then update it.
                if (modelPrice.modelPriceId) {
                    return dataService.updateEntity('modelPrices', modelPrice.modelPriceId, modelPrice).then(function (data) {
                        vm.modelPrice = data;
                    });
                }
                else {
                    return dataService.addEntity('modelPrices', modelPrice).then(function (data) {
                        vm.modelPrice = data;
                    });
                }
            });
        }

        function getModel(modelSearchCriteria) {
            return dataService.searchEntities('models', modelSearchCriteria).then(function (data) {
                vm.model.modelNumber = data[0].modelNumber;

                vm.model.modelUrl = data[0].modelUrl;

                vm.model.make = data[0].make;

                return vm.model;
            });
        }

        function getSpecificationsWithEmptySpecificationsByModelId(modelId) {
            return dataService.getSpecificationsWithEmptySpecificationsByModelId(modelId).then(function (data) {
                vm.model.specifications = data.value;

                return vm.model;
            });
        }

        function fillSpecNames() {
            for (var i = 0; i < vm.model.specifications.length; i++) {
                var specNameResultArray = $filter('filter')(vm.specNames, { specNameId: vm.model.specifications[i].specNameId }, true);

                vm.model.specifications[i].specName = specNameResultArray.length > 0 ? specNameResultArray[0] : null;
            }
        }

        function fillSpecClasses() {
            for (var i = 0; i < vm.model.specifications.length; i++) {
                var specClassResultArray = $filter('filter')(vm.specClasses, { specClassID: vm.model.specifications[i].specName.specClassId }, true);

                vm.model.specifications[i].specName.specClass = specClassResultArray.length > 0 ? specClassResultArray[0] : null;

                if ($filter('filter')(vm.masterSpecClasses, { specClassID: vm.model.specifications[i].specName.specClassId }, true).length === 0) {
                    vm.masterSpecClasses.push(specClassResultArray[0]);
                }
            }
        }

        function getSpecClass(specClassId) {
            var result = $filter('filter')(vm.specClasses, { specClassID: specClassId }, true);

            return result;
        }

        function searchSpecNames(specNameSearchCriteria) {
            return dataService.searchEntities('specNames', specNameSearchCriteria).then(function (data) {
                vm.specNames = data;

                return vm.specNames;
            });
        }

        function searchSpecClasses(specClassSearchCriteria) {
            return dataService.searchEntities('specClasses', specClassSearchCriteria).then(function (data) {
                vm.specClasses = data;

                return vm.specClasses;
            });
        }

        function searchModels(modelSearchCriteria) {
            return dataService.searchEntities('models', modelSearchCriteria).then(function (data) {
                vm.model = data[0];

                return vm.model;
            });
        }

    }

})();