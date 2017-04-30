using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthorizationPrototype.Startup))]
namespace AuthorizationPrototype
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
