using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(labb6.Startup))]
namespace labb6
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
