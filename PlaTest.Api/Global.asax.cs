using Microsoft.AspNet.Identity;
using PlaTest.Api.Data;
using PlaTest.Api.Models;
using Swashbuckle.Application;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dependencies;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;
using Unity.Injection;
using Unity.WebApi;

namespace PlaTest.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var container = new UnityContainer();

            container.RegisterType<DataContext>(new InjectionConstructor(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString));

            container.RegisterFactory<AppUserManager>(
                    c => new AppUserManager(new AppUserStore(new DataContext()))
                );

            AreaRegistration.RegisterAllAreas();

            #region Global Configuration
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configuration.DependencyResolver= new UnityDependencyResolver(container);
            //GlobalConfiguration.Configuration
            //    .EnableSwagger(c =>
            //{
            //})
            //    .EnableSwaggerUi();

            #endregion

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
