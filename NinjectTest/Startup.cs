using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NinjectTest.Startup))]
namespace NinjectTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
