using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HeliosGlamour.Startup))]
namespace HeliosGlamour
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
