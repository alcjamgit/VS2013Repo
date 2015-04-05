using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BillingAppPrototype.Startup))]
namespace BillingAppPrototype
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
