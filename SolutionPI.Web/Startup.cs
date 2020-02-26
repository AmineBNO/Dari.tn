using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SolutionPI.Web.Startup))]
namespace SolutionPI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
