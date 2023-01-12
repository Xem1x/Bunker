using BUNKER.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUNKER
{
    public static class GlobalVar
    { 

        static SortedDictionary<int, Player> players = new SortedDictionary<int, Player>();
        

        public static void SetPlayers(Player inpt_player)
        {
            int player_id = GetFirstFreeIdentificator();
            players.Add(player_id, inpt_player);
        }

        public static int GetPlayersAmount()
        {
            return players.Count;
        }
        public static SortedDictionary<int, Player> GetPlayers()
        {
           return players;
        }

        
        static int GetFirstFreeIdentificator()
        {
            for(int i = 1 ; i <= players.Count;i++)
            {
                if(!players.ContainsKey(i))
                {
                    return i;
                }
            }
            return players.Count + 1;
        }

    }
}