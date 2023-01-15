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
            job.value = "defaultJob";
            
        }
        public int user_id { get; set; }

        public string username { get; set; }

        public string client_id { get; set; }
        
        Characteristics health { get; set; } = new Characteristics("health");
        public Characteristics job { get; set; } = new Characteristics("job");
        Characteristics phobia { get; set; } = new Characteristics("phobia");
        Characteristics hobby { get; set; } = new Characteristics("hobby");
        Characteristics additional_info { get; set; } = new Characteristics("additional_info");
        Characteristics knowledge { get; set; } = new Characteristics("knowledge");
        Characteristics luggage { get; set; } = new Characteristics("luggage");

    }
}