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
    public partial class Voting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Count = 0;
            Count = Voting_play.count_play();
            Label2.Text = Count.ToString() + " / " + Convert.ToInt32(Application["TotalOnlineUsers"]);
            if (!IsPostBack)
            {
                for (int i =1; i <= Convert.ToInt32(Application["TotalOnlineUsers"]); i++)
                {
                    DropDownList1.Items.Add(GlobalVar.GetPlayers()[i].username.ToString());
                }
            }
        }

        protected void q1_Click(object sender, EventArgs e)
        {
           Voting_play.voting(DropDownList1.SelectedItem.Text.ToString());
           //Q1.InnerText = "Xui";
           //Q1.Visible = false;
        }
        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    Voting_play.voting(DropDownList1.SelectedItem.Text.ToString());
        //    Button1.Enabled= false;
        //}
    }
}