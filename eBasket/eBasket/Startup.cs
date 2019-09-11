using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eBasket.Startup))]
namespace eBasket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
