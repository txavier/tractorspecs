﻿using TractorSpecs.DependencyResolution;
using StructureMap;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace TractorSpecs
{
    public class MvcApplication : HttpApplication
    {
        public static IContainer container { get; private set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // http://cdroulers.com/blog/2015/03/03/structuremap-3-and-asp-net-web-api-2/
            //container = new Container(c => c.AddRegistry<DefaultRegistry>());
            container = IoC.Initialize();

            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator), new StructureMapWebApiControllerActivator(container));
        }

        protected void Application_End()
        {
            container.Dispose();
        }
    }
}
