using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using AuctionLibrary;
using System.Data;

namespace Project3
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                OnlineAuctionSvc.OnlineAuction pxy = new OnlineAuctionSvc.OnlineAuction();



               DataSet myDS = pxy.UpdateForDate();
                
                gvProducts.DataSource = myDS;
                gvProducts.DataBind();
            }
        }

        protected void btnReturnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHome.aspx");
        }

        protected void gvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void btnViewDetails_Click(object sender, EventArgs e)
        {

   
        }

        protected void btnViewDetails_Click1(object sender, EventArgs e)
        {

            for (int i = 0; i < gvProducts.Rows.Count; i++)
            {
                if (gvProducts.Rows[i].FindControl("btnViewDetails") == sender)
                {
                    int productID = Convert.ToInt32(gvProducts.Rows[i].Cells[3].Text);


                    Session["Product ID"] = productID;

                    Response.Redirect("ViewDetails.aspx");


                }
            }

        }

        protected void btnSearchbyCategory_Click(object sender, EventArgs e)
        {
            DataSet myDS = new DataSet();
            string category = ddlProductCategory.Text;
            OnlineAuctionSvc.OnlineAuction pxy = new OnlineAuctionSvc.OnlineAuction();

            myDS = pxy.SearchByCategory(category);
            gvProducts.DataSource = myDS;
            gvProducts.DataBind();

        }

        

    }
}