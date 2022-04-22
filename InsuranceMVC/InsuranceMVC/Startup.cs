using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InsuranceMVC.Startup))]
namespace InsuranceMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
