using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(App_master.Web.Startup))]
namespace App_master.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
