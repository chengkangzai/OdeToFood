using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using OdeToFood.Data.Services;

namespace OdeToFood.Web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer(HttpConfiguration httpConfiguration)
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);
            
             // * Will not work if have more than one user
             builder
                .RegisterType<InMemoryRestaurantData>()
                .As<IRestaurantData>()
                .SingleInstance();
             
             var container = builder.Build();
             DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
             // httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}