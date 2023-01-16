using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUNKER.GameData
{
    public class Player
    {
        public Player()
        {
            job.value = "default";
            Player_info.Add(job);
            Player_info.Add(bio);
            Player_info.Add(health);
            Player_info.Add(phobia);
            Player_info.Add(hobby);
            Player_info.Add(additional_info);
            Player_info.Add(knowledge);
            Player_info.Add(luggage);

        }
        public int user_id { get; set; }

        public string username { get; set; }

        public string client_id { get; set; }
        bool voted_out { get; set; } = false;
        public void VoteOut()
        {
            voted_out = true;
        }
        public bool IsVotedOut()
        { 
            return voted_out;
        }
        public List<Characteristics> Player_info{ get; set; } = new List<Characteristics>();
        Characteristics job { get; set; } = new Characteristics("job");
        Characteristics bio { get; set; } = new Characteristics("bio");
        Characteristics health { get; set; } = new Characteristics("health");
        Characteristics phobia { get; set; } = new Characteristics("phobia");
        Characteristics hobby { get; set; } = new Characteristics("hobby");
        Characteristics additional_info { get; set; } = new Characteristics("additional_info");
        Characteristics knowledge { get; set; } = new Characteristics("knowledge");
        Characteristics luggage { get; set; } = new Characteristics("luggage");

    }
}