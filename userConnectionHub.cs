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

        //public int GetOnline()
        //{
        //    return GlobalHost.DependencyResolver.Resolve<ITransportHeartbeat>().GetConnections().Count;
        //}

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

        public void Send(string name)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<UserConnectionHub>();
            context.Clients.All.updateUsersOnlineCount(name);
        }
        public void AddCard(int user_id,string name)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<UserConnectionHub>();
            context.Clients.All.AddCard(user_id, name);
        }
        public void Connect(string username)
        {
            if (!UserIsLoggedIn(username))
            {
                string clientId = GetClientId();
                int user_id = GlobalVar.GetFirstFreeIdentificator();
                Player player = new Player();
                player.client_id = clientId;
                player.user_id = user_id;
                player.username = username;

                GlobalVar.SetPlayers(player);
                AddCard(player.user_id, player.username);
            }
        }
        bool UserIsLoggedIn(string inpt_username)
        {
            //fix this to bottom form
            //return GlobalVar.GetPlayers().Contains(new Player { username = inpt_username });
            for (int i = 0; i < GlobalVar.GetPlayers().Count; i++)
            {
                if (GlobalVar.GetPlayers()[i].username == inpt_username)
                { 
                    return true;
                }

            }
            return false;
        }

        public void LoadAllCards()
        {
            for (int i = 0; i < GlobalVar.GetPlayers().Count; i++)
            {
                AddCard(GlobalVar.GetPlayers()[i].user_id, GlobalVar.GetPlayers()[i].username);

            }
        }

        public void LoadOwnCharacteristics()
        {

        }

        public override System.Threading.Tasks.Task OnConnected()
        {
            
            return base.OnConnected();
        }

        public override System.Threading.Tasks.Task OnReconnected()
        {


            return base.OnReconnected();
        }

        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);
        }

        
    }
}




