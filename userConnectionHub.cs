using BUNKER.GameData;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.AspNet.SignalR.Transports;
using System;
using System.Collections.Generic;
using System.Data;
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
                var currentPlayer = GlobalVar.GetPlayers()[i];
                AddCard(currentPlayer.user_id, currentPlayer.username);
                foreach (var characteristics in currentPlayer.Player_info)
                {
                    if (characteristics.shared)
                    {
                        SendCharToAll(currentPlayer.user_id, currentPlayer.client_id, characteristics.name, characteristics.value);
                    }
                }
                
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
                LoadOwnCharacteristics(username);
            }
            else
            {
                var player = GlobalVar.GetPlayerByName(username);
                string clientId = GetClientId();
                player.client_id = clientId;
                LoadOwnCharacteristics(username);
            }

        }


        public void SendOwnCharacteristicsToForm(string userConnectionId, string characteristic_div, string characteristic_data, int id)
        {

            Clients.Client(userConnectionId).loadInfo(id, characteristic_div, characteristic_data);
        }
        public void TransferOwnCharacteristics(string userConnectionId, Player currentPlayer)
        {
            foreach (var characteristics in currentPlayer.Player_info)
            {
                SendOwnCharacteristicsToForm(userConnectionId, characteristics.name, characteristics.value, currentPlayer.user_id);
            }
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
            context.Clients.AllExcept(clientId).updateInfo(id, characteristic_div, info);
        }
        public void ShareCharacteristics(string username, string characteristic_div, string info)
        {
            var sender_player = GlobalVar.GetPlayerByName(username);
            var characteristic_to_share = sender_player.Player_info.Find(x => x.name == characteristic_div);
            characteristic_to_share.shared = true;
            SendCharToAll(sender_player.user_id, sender_player.client_id, characteristic_div, info);
        }

        public void VoteOut(int card_id)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<UserConnectionHub>();
            context.Clients.All.changeInactive(card_id);
            context.Clients.All.clearVotingDropBox();
            Voting.ClearVoteList();
        }
        
        public void RegisterVote(string username)
        {

            Voting.Vote(username);
            if(Voting.CountOfVotes() == GlobalVar.GetPlayers().Count())
            {
                var mostSelectedPlayer = Voting.GetMostSelectedUser();
                var playerToVoteOut = GlobalVar.GetPlayerByName(mostSelectedPlayer);
                playerToVoteOut.VoteOut();
                VoteOut(playerToVoteOut.user_id);
            }
        }
        public void StartVoting()
        {

            var context = GlobalHost.ConnectionManager.GetHubContext<UserConnectionHub>();
            context.Clients.All.clearVotingDropBox();
            context.Clients.All.changeInactive("start_voting");
            foreach (var player in GlobalVar.GetPlayers())
            {
                if (!player.IsVotedOut())
                {
                    context.Clients.All.loadPlayersInDropBox(player.username);
                }
            }

            
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




