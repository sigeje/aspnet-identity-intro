using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspnet_identity_intro.Startup))]
namespace aspnet_identity_intro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
