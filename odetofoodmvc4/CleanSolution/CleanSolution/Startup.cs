using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CleanSolution.Startup))]
namespace CleanSolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
