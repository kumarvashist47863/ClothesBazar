using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClothesBazar.Web.Startup))]
namespace ClothesBazar.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
