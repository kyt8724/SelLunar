using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SelLunarApi.Startup))]
namespace SelLunarApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
