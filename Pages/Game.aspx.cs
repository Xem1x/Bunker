using BUNKER.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            Label2.Text = GlobalVar.GetPlayers()[1].name.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}