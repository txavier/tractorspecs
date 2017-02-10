﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace TractorSpecs
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/wwwroot/lib/jquery/dist/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.unobtrusive*",
                "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                "~/Scripts/knockout-{version}.js",
                "~/Scripts/knockout.validation.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/sammy-{version}.js",
                "~/Scripts/app/common.js",
                "~/Scripts/app/app.datamodel.js",
                "~/Scripts/app/app.viewmodel.js",
                "~/Scripts/app/home.viewmodel.js",
                "~/Scripts/app/_run.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                      "~/wwwroot/lib/angular/angular.min.js",
                      "~/wwwroot/lib/angular-route/angular-route.min.js",
                      "~/wwwroot/lib/angular-animate/angular-animate.min.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/angular-third-party").Include(
                      "~/wwwroot/lib/angular-loading-bar/build/loading-bar.min.js",
                      "~/wwwroot/lib/angular-sessionstorage/angular-sessionstorage.js",
                      "~/wwwroot/lib/AngularJS-Toaster/toaster.min.js",
                      "~/wwwroot/lib/textAngular/dist/textAngular-rangy.min.js",
                      "~/wwwroot/lib/textAngular/dist/textAngular-sanitize.min.js",
                      "~/wwwroot/lib/textAngular/dist/textAngular.min.js",
                      "~/wwwroot/lib/ng-file-model/ng-file-model.js",
                      "~/wwwroot/lib/angular-carousel/dist/angular-carousel.min.js",
                      "~/wwwroot/lib/angular-touch/angular-touch.min.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/angular-app").Include(
                      "~/app/app.module.js",
                      "~/app/app.config.js",
                      "~/app/services/data.service.js",
                      "~/app/services/error.service.js",
                      "~/app/services/auth-interceptor.service.js",
                      "~/app/home/home.controller.js",
                      "~/app/action-figures/add-action-figure.controller.js",
                      "~/app/action-figures/update-action-figure.controller.js",
                      "~/app/action-figures/view-action-figure.controller.js",
                      "~/app/user/dashboard.controller.js",
                      "~/app/layout/layout.controller.js",
                      "~/app/login/login.controller.js",
                      "~/app/blog-entry/blog-entries.controller.js",
                      "~/app/blog-entry/view-blog-entry.controller.js",
                      "~/app/blog-entry/add-blog-entry.controller.js",
                      "~/app/blog-entry/update-blog-entry.controller.js",
                      "~/app/author/authors.controller.js",
                      "~/app/author/view-author.controller.js",
                      "~/app/author/add-author.controller.js",
                      "~/app/author/update-author.controller.js",
                      "~/app/make/make.controller.js",
                      "~/app/make/makes.controller.js",
                      "~/app/model/model.controller.js"
                      ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/wwwroot/lib/bootstrap/dist/js/bootstrap.min.js",
                "~/wwwroot/lib/respond/dest/respond.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                //"~/wwwroot/lib/bootstrap/dist/css/bootstrap.min.css",
                //"~/wwwroot/lib/bootstrap/dist/css/bootstrap-theme.min.css",
                //"~/wwwroot/lib/AngularJS-Toaster/toaster.min.css",
                //"~/wwwroot/lib/textAngular/dist/textAngular.css",
                //"~/wwwroot/lib/angular-carousel/dist/angular-carousel.min.css",
                "~/Content/Site.css"));

            bundles.Add(new ScriptBundle("~/bundles/theme").Include(
                "~/wwwroot/lib/superfish/dist/js/superfish.js",
                "~/wwwroot/lib/jquery.easing/js/jquery.easing.js"));

            BundleTable.EnableOptimizations = false;
        }
    }
}
