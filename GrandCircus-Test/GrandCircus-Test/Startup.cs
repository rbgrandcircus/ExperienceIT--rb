using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GrandCircus_Test.Startup))]
namespace GrandCircus_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
