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

        public void AddCard(int user_id, string name)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<UserConnectionHub>();
            context.Clients.All.AddCard(user_id, name);
        }
        public void LoadAllCards()
        {
            for (int i = 0; i < GlobalVar.GetPlayers().Count; i++)
            {
                AddCard(GlobalVar.GetPlayers()[i].user_id, GlobalVar.GetPlayers()[i].username);

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


        public void SendOwnCharacteristicsToForm(string userConnectionId, string characteristic_div, string characteristic_data, int id)
        {

            Clients.Client(userConnectionId).loadInfo(id, characteristic_div, characteristic_data);
        }
        public void TransferOwnCharacteristics(string userConnectionId, Player currentPlayer)
        {
            SendOwnCharacteristicsToForm(userConnectionId, currentPlayer.job.name, currentPlayer.job.value, currentPlayer.user_id);
        }
        public void LoadOwnCharacteristics(string nameOfPlayer)
        {
            string currentPlayerConnectionId = Context.ConnectionId;
            var currentPlayer = GlobalVar.GetPlayerByName(nameOfPlayer);
            TransferOwnCharacteristics(currentPlayerConnectionId, currentPlayer);
        }





        public void SendCharToAll(int id, string clientId, string characteristic_div, string info)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<UserConnectionHub>();
            //context.Clients.All.loadInfo(id, info);
            context.Clients.AllExcept(clientId).updateInfo(id, characteristic_div, info);
        }
        public void ShareCharacteristics(string username, string characteristic_div, string info)
        {
            var sender_player = GlobalVar.GetPlayerByName(username);
            SendCharToAll(sender_player.user_id, sender_player.client_id, characteristic_div, info);
        }

        

        public override System.Threading.Tasks.Task OnConnected()
        {
            
            return base.OnConnected();
        }

        public override System.Threading.Tasks.Task OnReconnected()
        {


            return base.OnReconnected();
        }
        void Delete(string id)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<UserConnectionHub>();
            //context.Clients.All.loadInfo(id, info);
            context.Clients.All.deleteCard(id);
        }
        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            string currentPlayerConnectionId = Context.ConnectionId;
            var player_left = GlobalVar.GetPlayerByClientId(currentPlayerConnectionId);
            Delete(player_left.user_id.ToString());
            GlobalVar.GetPlayers().Remove(player_left);
            
            return base.OnDisconnected(stopCalled);
        }

        
    }
}




