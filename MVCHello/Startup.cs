using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCHello.Startup))]
namespace MVCHello
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
