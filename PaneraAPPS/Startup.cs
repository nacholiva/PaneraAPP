using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaneraAPPS.Startup))]
namespace PaneraAPPS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
