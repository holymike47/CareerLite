using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CareerLite.Startup))]
namespace CareerLite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
