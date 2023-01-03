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
            Label1.Text = Session["Name"].ToString();
            ServHub co = new ServHub();
            Label2.Text = co.GetOnline().ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}