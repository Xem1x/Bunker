using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using System.Web.Routing;

[assembly: OwinStartup(typeof(BUNKER.Startup))]

namespace BUNKER
{
    public class Startup
    {
        readonly UserConnectionHub _servHub = new UserConnectionHub();
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            
            app.MapSignalR();
        }
    }
}