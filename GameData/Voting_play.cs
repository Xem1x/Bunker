using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUNKER.GameData
{
    public class Voting_play
    {
        static List<string> voting_list = new List<string>();
        static List<string> del_list = new List<string>();
        public static List<string> voting(string var)
        {
            voting_list.Add(var);
            return voting_list;
        }
        public static int count_play()
        {
            return voting_list.Count;
        }
        public static object clean()
        {

            voting_list.Clear();
            return voting_list;
        }
    }
}