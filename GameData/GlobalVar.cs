using BUNKER.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUNKER
{
    public static class GlobalVar
    {
        static int i = 0;
        static List<Player> players= new List<Player>();

        public static void SetPlayers(Player inpt_player)
        {
            players.Add(inpt_player);
        }
        public static List<Player> GetPlayers()
        {
           return players;
        }

        public static int I
        {
            get
            {
                return i;
            }
            set
            {
                i = value;
            }
        }
    }
}