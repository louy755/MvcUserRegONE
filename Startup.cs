using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcUserRegONE.Startup))]
namespace MvcUserRegONE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
