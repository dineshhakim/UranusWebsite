using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Uranus.Startup))]
namespace Uranus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
