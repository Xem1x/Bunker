using BUNKER.GameData;
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
            Random rnd = new Random();
            int job = rnd.Next(1, 13);
            int bio = rnd.Next(1, 13);
            ServHub co = new ServHub();
            Player player = new Player();
            GlobalVar.SetPlayers(player);
            SortedDictionary<int, Player> pl = GlobalVar.GetPlayers();
            player.name = Session["Name"].ToString();
            player.job = job.ToString();
            player.bio = bio.ToString(); 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}