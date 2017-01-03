using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TaskManager.WebServer.Startup))]
namespace TaskManager.WebServer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
