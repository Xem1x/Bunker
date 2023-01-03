using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUNKER
{
    public static class GlobalVar
    {
        static int i = 0;
        public static int I
        {
            get
            {
                return i;
            }
            set
            {
                i = value;
            }
        }
    }
}