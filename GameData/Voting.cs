using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUNKER.GameData
{
    public class Voting
    {
        static Dictionary<string,int> votes_dictionary = new Dictionary<string, int>();
        //
        public static void Vote(string var)
        {
            if (votes_dictionary.ContainsKey(var))
            {
                votes_dictionary[var]++;
            }
            else
            {
                votes_dictionary.Add(var, 1);
            }

        }
        public static int CountOfVotes()
        {
            return votes_dictionary.Count;
        }
        public static void ClearVoteList()
        {

            votes_dictionary.Clear();
        }
        public static string GetMostSelectedUser()
        {
            //optimize this
            var mostSelectedUser = new KeyValuePair<string, int>("",0);
            foreach (var user in votes_dictionary)
            {
                //fix if equal votes
                if(mostSelectedUser.Value < user.Value)
                { 
                    mostSelectedUser = user;
                }
            }
            return mostSelectedUser.Key;
        }
    }
}