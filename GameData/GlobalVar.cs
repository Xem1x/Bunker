using BUNKER.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUNKER
{
    public static class GlobalVar
    { 

        static public List<string> alreadyAssignedCharactr = new List<string>() { };
        public static void SetAssignedChar(string inpt)
        {
            alreadyAssignedCharactr.Add(inpt);
        }
        public static List<string> GetAssignedChar()
        {
            return alreadyAssignedCharactr;
        }


        
        

        

    }
}