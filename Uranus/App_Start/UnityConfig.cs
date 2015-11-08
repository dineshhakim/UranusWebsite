using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Unity.Mvc5;
using Uranus.Controllers;
using Uranus.Domain;

namespace Uranus.App_Start
{
    public static class UnityConfig
    {
        //public static void RegisterComponents()
        //{
        //    var container = new UnityContainer();
            
        //    // register all your components with the container here
        //    // it is NOT necessary to register your controllers
            
        //    // e.g. container.RegisterType<ITestService, TestService>();
            
        //    DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        //}
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
          // container.LoadConfiguration();
            //   GlobalConfiguration.Configuration.DependencyResolver = new Unity.Mvc5.UnityDependencyResolver(container);
          
            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            // e.g. container.RegisterType<ITestService, TestService>();    
            RegisterTypes(container);
            return container;
        }
        //http://www.developer.com/net/dependency-injection-best-practices-in-an-n-tier-modular-application.html
        public static void RegisterTypes(IUnityContainer container)
        {
            //container.RegisterType<IUserData, UserData>();
            //Module initialization thru MEF 
            //Very Important
            ModuleLoader.LoadContainer(container, ".\\bin", "Uranus.*.dll");
        }
    }
}