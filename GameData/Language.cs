using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUNKER.GameData
{
    public class Language
    {
        public string Settings { get; }

        public Language(string choose)
        {

            if (choose == "UA")
            {
                Settings = "Налаштування";
            }
            else if (choose == "EN")
            {
                Settings = "Enter your name:";

            }
        }
        }
}