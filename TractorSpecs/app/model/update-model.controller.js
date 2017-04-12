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
        vm.addOrUpdateModelPicture = addOrUpdateModelPicture;
        vm.addOrUpdateLink = addOrUpdateLink;
        vm.addOrUpdateModelPrice = addOrUpdateModelPrice;
        vm.addOrUpdateSpecifications = addOrUpdateSpecifications;
        vm.specChangeLog = {};

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
                $select: 'modelId,modelNumber,modelUrl',
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
                    return dataService.updateEntity('reviews', review.reviewId, review, true).then(function (data) {
                        vm.review = data;
                    });
                }
                else {
                    return dataService.addEntity('reviews', review, true).then(function (data) {
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
                    return dataService.updateEntity('links', link.linkId, link, true).then(function (data) {
                        vm.link = data;
                    });
                }
                else {
                    return dataService.addEntity('links', link, true).then(function (data) {
                        vm.link = data;
                    });
                }
            });
        }

        function addOrUpdateModelPrice(modelPrice) {
            modelPrice.modelId = vm.model.modelId;

            modelPrice.date = new Date();

            // If this already exists then update it.
            if (modelPrice.modelPriceId) {
                return dataService.updateEntity('modelPrices', modelPrice.modelPriceId, modelPrice, true).then(function (data) {
                    vm.modelPrice = data;
                });
            }
            else {
                return dataService.addEntity('modelPrices', modelPrice, true).then(function (data) {
                    vm.modelPrice = data;
                });
            }
        }

        function addOrUpdateModelPicture(modelPicture) {
            modelPicture.modelId = vm.model.modelId;

            modelPicture.base64String = modelPicture.fileModel.data;

            modelPicture.filename = modelPicture.fileModel.name;

            var tempFileModel = modelPicture.fileModel;

            modelPicture.fileModel = undefined;

            if (modelPicture.modelPictureId) {
                return dataService.updateEntity('modelPictures', modelPicture.modelPictureId, modelPicture, true).then(function (data) {
                    vm.modelPicture = data;
                }, function (err) {
                    modelPicture.fileModel = tempFileModel;
                });
            }
            else {
                return dataService.addEntity('modelPictures', modelPicture, true).then(function (data) {
                    vm.modelPicture = data;
                }, function (err) {
                    modelPicture.fileModel = tempFileModel;
                });
            }
        }

        function addOrUpdateSpecifications(specifications) {
            for (var i = 0; i < specifications.length; i++) {
                if (specifications[i].isDirty) {
                    return dataService.getClientIp().then(function (data) {
                        specifications[i].isDirty = undefined;
                        specifications[i].ip = data;
                        specifications[i].date = new Date();

                        if (specifications[i].specificationId) {
                            return dataService.updateEntity('specifications', specifications[i].specificationId, specifications[i]).then(function (data) {
                                addSpecChangeLog(specifications[i]);
                            });
                        }
                        else {
                            return dataService.addEntity('specifications', specifications[i]).then(function (data) {
                                addSpecChangeLog(specifications[i]);
                            });
                        }
                    });
                }
            }
        }

        function addSpecChangeLog(specification) {
            vm.specChangeLog.modelId = specification.modelId;
            vm.specChangeLog.specValue = specification.specValue;
            vm.specChangeLog.ipAddr = specification.ip;

            return dataService.addEntity('specChangeLogs', vm.specChangeLog).then(function (data) {
                vm.specChangeLog = data;
            });
        }

        function getModel(modelSearchCriteria) {
            return dataService.searchEntities('models', modelSearchCriteria).then(function (data) {
                vm.model.modelNumber = data[0].modelNumber;

                vm.model.modelUrl = data[0].modelUrl;

                vm.model.make = data[0].make;

                vm.model.modelId = data[0].modelId;

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