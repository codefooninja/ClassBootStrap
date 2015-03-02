using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClassBootStrap.Startup))]
namespace ClassBootStrap
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
