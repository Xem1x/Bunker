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


        static SortedDictionary<int, Player> players = new SortedDictionary<int, Player>();
        

        public static void SetPlayers(Player inpt_player)
        {
            int player_id = GetFirstFreeIdentificator();
            players.Add(player_id, inpt_player);
        }
        public static SortedDictionary<int, Player> GetPlayers()
        {
           return players;
        }
        public static int GetPlayersAmount()
        {
            return players.Count;
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