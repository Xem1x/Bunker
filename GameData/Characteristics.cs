using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUNKER.GameData
{
    public class Characteristics
    {
        public Characteristics(string name_inpt)
        {
            name = name_inpt;
        }
        public string name { get; set; }
        public string value { get; set; } = "test";
        public bool shared { get; set; } = false;

        
    }
}