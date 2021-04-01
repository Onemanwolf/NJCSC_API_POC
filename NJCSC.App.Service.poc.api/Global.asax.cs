using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using NJCSC.App.Service.poc.api.Serviices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace NJCSC.App.Service.poc.api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
           

            // Create your builder.
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(WebApiApplication).Assembly);
            builder.RegisterApiControllers(typeof(WebApiApplication).Assembly);


            builder.RegisterSource(new ViewRegistrationSource());

            // Usually you're only interested in exposing the type
            // via its interface:
            builder.RegisterType<EmpApplicationService>().As<IEmpApplicationService>();

            // However, if you want BOTH services (not as common)
            // you can say so:
            //builder.RegisterType<SomeType>().AsSelf().As<IService>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);


            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


        }
    }
}
