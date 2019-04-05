using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspWebSiteTest.Startup))]
namespace AspWebSiteTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
