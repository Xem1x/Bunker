using BUNKER.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BUNKER.Pages
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Token.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Name"] = TextBox1.Text;
            Session["Xui"] = System.Security.Principal.WindowsIdentity.GetCurrent().Token.ToString();
            Response.Redirect("Game.aspx");
        }
    }
}