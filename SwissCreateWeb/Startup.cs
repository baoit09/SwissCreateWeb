using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SwissCreateWeb.Startup))]
namespace SwissCreateWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
