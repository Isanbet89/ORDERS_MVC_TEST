using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ORDERS_MVC.Startup))]
namespace ORDERS_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
