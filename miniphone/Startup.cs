using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(miniphone.Startup))]
namespace miniphone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
