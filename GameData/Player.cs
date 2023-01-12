using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUNKER.GameData
{
    public class Player
    {
        int user_id { get; set; }

        public string username { get; set; }

        public string client_id { get; set; }


        string job { get; set; }
        string health { get; set; }
        string phobia { get; set; }
        string hobby { get; set; }
        string additional_info { get; set; }
        string knowledge { get; set; }
        string luggage { get; set; }

    }
}