using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vol3.Startup))]
namespace Vol3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
