using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAssignment1.Startup))]
namespace MVCAssignment1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
