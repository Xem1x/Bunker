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

            job.name = "job";
            job.value = "defaultJob";
            job.shared = false;
            
        }
        public int user_id { get; set; }

        public string username { get; set; }

        public string client_id { get; set; }
        
        Characteristics health { get; set; }
        public Characteristics job { get; set; } = new Characteristics();
        Characteristics phobia { get; set; }
        Characteristics hobby { get; set; }
        Characteristics additional_info { get; set; }
        Characteristics knowledge { get; set; }
        Characteristics luggage { get; set; }

    }
}