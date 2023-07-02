using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hospital.webApp.Startup))]
namespace hospital.webApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
