using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUNKER.GameData
{
    public class Characteristics
    {
        public Characteristics(string value_inpt)
        {
            value = value_inpt;
        }
        public string name { get; set; }
        public string value { get; set; }
        public bool shared { get; set; } = false;

        
    }
}