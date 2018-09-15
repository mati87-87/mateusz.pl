using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mateusz.pl.Startup))]
namespace mateusz.pl
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
