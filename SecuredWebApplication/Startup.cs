using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecuredWebApplication.Startup))]
namespace SecuredWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
