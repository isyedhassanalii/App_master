using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(App_master.Startup))]
namespace App_master
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
