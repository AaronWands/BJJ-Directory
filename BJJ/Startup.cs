using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BJJ.Startup))]
namespace BJJ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
