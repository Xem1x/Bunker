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
            else
            {
                var player = GlobalVar.GetPlayerByName(username);
                string clientId = GetClientId();
                player.client_id = clientId;
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
        public void SendCharToAll(int id, string clientId, string info)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<UserConnectionHub>();
            //context.Clients.All.loadInfo(id, info);
            context.Clients.AllExcept(clientId).updateInfo(id, info);
        }
        public void ShareCharacteristics(string username,string info)
        {
            var sender_player = GlobalVar.GetPlayerByName(username);
            SendCharToAll(sender_player.user_id, sender_player.client_id, info);
        }

        public void SendMessage(string user, int id)
        {
            
            Clients.Client(user).loadInfo(id, "test");
        }
        public void LoadOwnCharacteristics(string nameOfPlayer)
        {
            string user = Context.ConnectionId;
            var id = GlobalVar.GetPlayerByName(nameOfPlayer).user_id;
            SendMessage(user,id);
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




