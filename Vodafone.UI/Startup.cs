using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vodafone.UI.Startup))]
namespace Vodafone.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
