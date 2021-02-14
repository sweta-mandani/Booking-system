using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomerWebapp1.Startup))]
namespace CustomerWebapp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
