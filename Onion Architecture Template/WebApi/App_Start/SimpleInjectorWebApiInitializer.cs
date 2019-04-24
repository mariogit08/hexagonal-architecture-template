[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(TemplateProjects.$safeprojectname$.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]

namespace TemplateProjects.$safeprojectname$.App_Start
{
    using Infra.Ioc.Modulos;    
    using SimpleInjector;
    using SimpleInjector.Integration.$safeprojectname$;
    using SimpleInjector.Lifestyles;
    using System.Web.Http;

    public class SimpleInjectorWebApiInitializer
    {
        public static void Initialize()
        {
            var simpleInjectorNotInitialized = GlobalConfiguration.Configuration.DependencyResolver as SimpleInjectorWebApiDependencyResolver == null;
            if (simpleInjectorNotInitialized)
            {
                var container = new Container();
                container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

                container = ContextModule.RegisterContexts(container);
                container = RepositoryModule.RegisterRepositories(container);
                container = ServicesModule.RegisterServices(container);
                container = ApplicationModule.RegisterServices(container);

                InitializeContainer(container);

                container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

                container.Verify();

                GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
            }
        }
        private static void InitializeContainer(Container container)
        {
            // For instance:
            // container.Register<IUserRepository, SqlUserRepository>(Lifestyle.Scoped);
        }
    }
}