using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(farmgate.Startup))]
namespace farmgate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
