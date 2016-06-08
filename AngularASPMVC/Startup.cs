using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularASPMVC.Startup))]
namespace AngularASPMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
