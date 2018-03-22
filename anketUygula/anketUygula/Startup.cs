using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(anketUygula.Startup))]
namespace anketUygula
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
