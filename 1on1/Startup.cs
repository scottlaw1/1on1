using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1on1.Startup))]
namespace _1on1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
