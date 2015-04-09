using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Utilities;
using AuctionLibrary;

namespace Project3
{
    public partial class ViewMyBids : System.Web.UI.Page
    {

        Customer user;
        protected void Page_Load(object sender, EventArgs e)
        {
            OnlineAuctionSvc.OnlineAuction pxy = new OnlineAuctionSvc.OnlineAuction();

            user = (Customer) Session["User"];
            string username = user.username;

            DataSet myDS = pxy.GetMyBids(username);

            gvBids.DataSource = myDS;
            gvBids.DataBind();
        }

        protected void btnReturnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHome.aspx");
        }
    }
}