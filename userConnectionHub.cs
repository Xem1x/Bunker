using BUNKER.GameData;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.AspNet.SignalR.Transports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
namespace BUNKER
{   
    


    [HubName("userConnectionHub")]
    public class UserConnectionHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }
        public int GetOnline()
        {
            return GlobalHost.DependencyResolver.Resolve<ITransportHeartbeat>().GetConnections().Count;
        }

        public static List<string> Users = new List<string>();

       
        public void Send(int count)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<UserConnectionHub>();
            context.Clients.All.updateUsersOnlineCount(count);
        }

        public override System.Threading.Tasks.Task OnConnected()
        {
            string clientId = GetClientId();




            if (Users.IndexOf(clientId) == -1)
            {
                Users.Add(clientId);
            }

            // Send the current count of users
            Send(Users.Count);

            return base.OnConnected();
        }

        public override System.Threading.Tasks.Task OnReconnected()
        {
            string clientId = GetClientId();
            if (Users.IndexOf(clientId) == -1)
            {
                Users.Add(clientId);
            }

            // Send the current count of users
            Send(Users.Count);

            return base.OnReconnected();
        }

        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            string clientId = GetClientId();

            if (Users.IndexOf(clientId) > -1)
            {
                Users.Remove(clientId);
            }

            // Send the current count of users
            Send(Users.Count);

            return base.OnDisconnected(stopCalled);
        }

        public string GetClientId()
        {
            string clientId = "";
            if (Context.QueryString["clientId"] != null)
            {
                // clientId passed from application 
                clientId = this.Context.QueryString["clientId"];
            }

            


            if (string.IsNullOrEmpty(clientId.Trim()))
            {
                clientId = Context.ConnectionId;
            }

            return clientId;
        }
    }
}




