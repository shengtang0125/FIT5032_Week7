using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FIT5032_Week7.Startup))]
namespace FIT5032_Week7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
