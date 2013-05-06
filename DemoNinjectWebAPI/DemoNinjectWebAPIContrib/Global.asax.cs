using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using DemoNinjectWebAPI.Contracts;
using DemoNinjectWebAPI.Repositories;
using Ninject;
using WebApiContrib.IoC.Ninject;

namespace DemoNinjectWebAPIContrib
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            //DI
            IKernel kernel = new StandardKernel();
            kernel.Bind<IPaisRepository>().To<PaisRepository>();
            System.Web.Http.Dependencies.IDependencyResolver resolver = new NinjectResolver(kernel);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            GlobalConfiguration.Configuration.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);
        }
    }
}