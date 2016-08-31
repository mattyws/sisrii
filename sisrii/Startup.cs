using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sisrii.Startup))]
namespace sisrii
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
