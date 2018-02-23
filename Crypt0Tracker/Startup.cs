using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Crypt0Tracker.Startup))]
namespace Crypt0Tracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
