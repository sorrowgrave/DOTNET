using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OefenExamen.Startup))]
namespace OefenExamen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
