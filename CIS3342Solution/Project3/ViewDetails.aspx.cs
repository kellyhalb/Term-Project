using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AuctionLibrary;

namespace Project3
{
    public partial class ViewDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           
            if (!IsPostBack)
            {

                OnlineAuctionSvc.Product product;

                int ProductID = (int)Session["Product ID"];
                lblProductName.Text = ProductID.ToString();


                OnlineAuctionSvc.OnlineAuction pxy = new OnlineAuctionSvc.OnlineAuction();

                pxy.RetrieveProductDB(ProductID);


                product = pxy.RetrieveProductDB(ProductID);

                lblProductName.Text = product.productname;
                lblProductDescription.Text = product.productdescription;
                lblReservePrice.Text = product.reserveprice.ToString();
                lblCurrentBid.Text = product.Currentbid.ToString();
                lblSellerUsername.Text = product.Sellerusername;
                lblAuctionEndDate.Text = product.auctionenddate.ToString();



            }







        }


        private void ShowAddFunctions()
        {
            lblAddYourBid.Visible = true;
            lblBidPriceTitle.Visible = true;
            txtAddBidPrice.Visible = true;
            btnSubmitBid.Visible = true;
        }

        private void HideAddFunctions()
        {
            lblAddYourBid.Visible = false;
            lblBidPriceTitle.Visible = false;
            txtAddBidPrice.Visible = false;
            btnSubmitBid.Visible = false;
        }



        protected void btnReturnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHome.aspx");
        }

        protected void lblBid_Click(object sender, EventArgs e)
        {

            ShowAddFunctions();
        }

        protected void btnSubmitBid_Click(object sender, EventArgs e)
        {
            HideAddFunctions();

            int productID = (int)Session["Product ID"];

            decimal bidamount = Convert.ToDecimal(txtAddBidPrice.Text);

            Customer c = (Customer)Session["User"];
            string username = c.username;

            


            OnlineAuctionSvc.OnlineAuction pxy = new OnlineAuctionSvc.OnlineAuction();
            
            pxy.UpdateProductBidsDB(productID, bidamount, username);
            pxy.AddBidDB(productID, bidamount, username);


            lblMessage.Text = "Success, your bid has been added.";
        }

        protected void lblReturntoSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("Search.aspx");
        }



    }
}