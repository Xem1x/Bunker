using BUNKER.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BUNKER.Pages
{
    public partial class TestGenerator : System.Web.UI.Page
    {
        UserConnectionHub _servHub = new UserConnectionHub();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["name"] = "test1";

            Player_Generator.Connect();
            Label1.Text = Player_Generator.connected.ToString();
        }
        public void Button1_Click(object sender, EventArgs e)
        {


            Label1.Text = Player_Generator.GetJob();  //.GetCurrent().Token.ToString();// /

        }
    }
}