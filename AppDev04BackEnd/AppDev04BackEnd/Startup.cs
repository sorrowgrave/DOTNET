using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppDev04BackEnd.Startup))]
namespace AppDev04BackEnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
