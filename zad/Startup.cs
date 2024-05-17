using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(zad.Startup))]
namespace zad
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
