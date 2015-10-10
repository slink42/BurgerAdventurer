using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BurgerAdventurer.Startup))]
namespace BurgerAdventurer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
