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

        static List<Player> players = new List<Player>();

        public static void SetPlayers(Player inpt_player)
        {

            players.Add(inpt_player);
        }
        public static List<Player> GetPlayers()
        {
            return players;
        }
        public static int GetPlayersAmount()
        {
            return players.Count;
        }
        static int GetFirstFreeIdentificator()
        {
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i] == null)
                {
                    return i;
                }

            }
            return players.Count + 1;
        }





        public void Send(string name)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<UserConnectionHub>();
            context.Clients.All.updateUsersOnlineCount(name);
        }
        public void Add(string name)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<UserConnectionHub>();
            context.Clients.All.AddMessage("added "/* + GetPlayersAmount()*/);
        }
        public void Connect(string username)
        {
            string clientId = GetClientId();
            int user_id = GetFirstFreeIdentificator();
            Player player = new Player();
            player.client_id = clientId;
            player.user_id = user_id;
            player.username = username;

            players.Add(player);
            string s1 = player.username + " id: " + player.user_id + " connection id: " + player.client_id;
            Send(s1);

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




