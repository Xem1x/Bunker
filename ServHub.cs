using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Transports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BUNKER
{
    public class ServHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
        }
        public int GetOnline()
        {
            return GlobalHost.DependencyResolver.Resolve<ITransportHeartbeat>().GetConnections().Count;
        }
    }
}



