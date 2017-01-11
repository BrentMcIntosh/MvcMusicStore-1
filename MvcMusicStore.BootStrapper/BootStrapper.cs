using Autofac;
using Autofac.Integration.WebApi;
using MvcMusicStore.Application.Interfaces;
using MvcMusicStore.Application.Services;
using MvcMusicStore.Business.Core.Interfaces.Persistence;
using MvcMusicStore.Business.Core.Interfaces.Services;
using MvcMusicStore.Business.Services;
using MvcMusicStore.Infrastructure.Persistence;
using MvcMusicStore.Presentation.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(MvcMusicStore.BootStrapper.BootStrapper), "Register")]
namespace MvcMusicStore.BootStrapper
{
    public class BootStrapper
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();

            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;

            // Register your Web API controllers.
            builder.RegisterApiControllers(typeof(StoreManagerApiController).Assembly);

            // OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(config);

            builder.RegisterType<StoreService>().As<IStoreService>();
            builder.RegisterType<StoreManagerService>().As<IStoreManagerService>();
            builder.RegisterInstance(new MvcMusicStoreDataContext(@"Data Source=.\SQLEXPRESS;Initial Catalog=MusicStore;Integrated Security=true"))
                   .As<IWriteEntities>().SingleInstance();

            builder.RegisterType<StoreApplicationService>().As<IStoreApplicationService>();
            builder.RegisterType<StoreManagerApplicationService>().As<IStoreManagerApplicationService>();
            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
