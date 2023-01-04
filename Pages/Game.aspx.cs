﻿using BUNKER.GameData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace BUNKER.Pages
{
    public partial class Game : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            ServHub co = new ServHub();
            Player player = new Player();
            GlobalVar.SetPlayers(player);
            SortedDictionary<int, Player> pl = GlobalVar.GetPlayers();
            player.name = Session["Name"].ToString();

            Label1.Text = GlobalVar.GetPlayers()[1].name.ToString(); 
            if (Convert.ToInt32(Application["TotalOnlineUsers"]) > 1)
            {
                Label2.Text = GlobalVar.GetPlayers()[2].name.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}