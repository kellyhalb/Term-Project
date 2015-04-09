using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using AuctionLibrary;

namespace Project3
{
    public partial class UserHome : System.Web.UI.Page
    {
        Customer user;

        protected void Page_Load(object sender, EventArgs e)
        {
    
            
        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            user = (Customer)Session["User"];
            string username = user.username;
            string accounttype = user.accounttype;

            if (accounttype == "Buyer")
            {
                lblMessage.Text = "You are not authorized to add products on a buyers account.";
            }
            else
            {
                Response.Redirect("AddProduct.aspx");
            }
        }

        protected void btnBrowse_Click(object sender, EventArgs e)
        {
            Response.Redirect("Search.aspx");
        }

        protected void btnViewMySales_Click(object sender, EventArgs e)
        {
            user = (Customer)Session["User"];
            string username = user.username;
            string accounttype = user.accounttype;

            if (accounttype == "Buyer")
            {
                lblMessage.Text = "You cannot view your sales on a buyers account.";
            }
            else
            {
                Response.Redirect("ViewMyAuctions.aspx");
            }


           
        }

        protected void btnViewBids_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewMyBids.aspx");
        }
    }
}