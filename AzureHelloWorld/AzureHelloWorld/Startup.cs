using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureHelloWorld.Startup))]
namespace AzureHelloWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
