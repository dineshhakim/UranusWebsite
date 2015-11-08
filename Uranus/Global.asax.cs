 
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Uranus.App_Start;

namespace Uranus
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
          
            UnityConfig.Initialise();
            //Database.SetInitializer(new ProductDatabaseInitializer());
        }
    }
}
