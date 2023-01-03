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
            int position = GlobalVar.I++;
            Label1.Text = Session["Name"].ToString();
            ServHub co = new ServHub();
            Player player = new Player();
            player.id = position;
            Label2.Text = player.id.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}