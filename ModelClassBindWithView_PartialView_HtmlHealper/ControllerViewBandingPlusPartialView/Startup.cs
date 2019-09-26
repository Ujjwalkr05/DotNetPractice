using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControllerViewBandingPlusPartialView.Startup))]
namespace ControllerViewBandingPlusPartialView
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
