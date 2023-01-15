using BUNKER.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUNKER
{
    public static class GlobalVar
    { 

        static public List<string> alreadyAssignedCharactr = new List<string>() { };
        public static void SetAssignedChar(string inpt)
        {
            alreadyAssignedCharactr.Add(inpt);
        }
        public static List<string> GetAssignedChar()
        {
            return alreadyAssignedCharactr;
        }



        static List<Player> players = new List<Player>();

        public static void SetPlayers(Player inpt_player)
        {

            players.Add(inpt_player);
        }
        public static List<Player> GetPlayers()
        {
            return players;
        }
        public static Player GetPlayerByName(string name)
        {
            for (int i = 0; i < players.Count(); i++)
            {
                if (players[i].username == name)
                {
                    return (Player)players[i];
                }

            }
            return null;
        }
        public static Player GetPlayerByClientId(string clientID)
        {
            for (int i = 0; i < players.Count(); i++)
            {
                if (players[i].client_id == clientID)
                {
                    return (Player)players[i];
                }

            }
            return null;
        }
        public static int GetPlayersAmount()
        {
            return players.Count;
        }
        public static int GetFirstFreeIdentificator()
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





    }
}