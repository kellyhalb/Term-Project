using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AuctionLibrary;
using Utilities;
using System.Data;
using System.Globalization;


namespace Project3
{
    public partial class ViewMyAuctions : System.Web.UI.Page
    {
        Customer c;

        public int amountchecked = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {

                DataSet myDS = new DataSet();
                OnlineAuctionSvc.OnlineAuction pxy = new OnlineAuctionSvc.OnlineAuction();

                c = (Customer) Session["User"];
                string username = c.username;
                

                myDS = pxy.ViewMyAuctions(username);

                gvMyAuctions.DataSource = myDS;
                gvMyAuctions.DataBind();


            }
        }




        public void ShowEditFunctions()
        {
            lblProductDescriptionTitle.Visible = true;
            lblProductNameTitle.Visible = true;
            lblReservePriceTitle.Visible = true;
            lblEditTitle.Visible= true;
            txtProductDescription.Visible = true;
            txtReservePrice.Visible = true;
            txtProductName.Visible = true;
            btnSubmitEdit.Visible = true;
        }


        public void HideEditFunctions()
        {
            lblProductDescriptionTitle.Visible = false;
            lblProductNameTitle.Visible = false;
            lblReservePriceTitle.Visible = false;
            lblEditTitle.Visible = false;
            txtProductDescription.Visible = false;
            txtReservePrice.Visible = false;
            txtProductName.Visible = false;
            btnSubmitEdit.Visible = false;

        }





        protected void gvMyAuctions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvMyAuctions.Rows.Count; i++)       //Input Validation to make sure one and only one checkbox is selected
            {
                CheckBox cb;
                cb = (CheckBox)gvMyAuctions.Rows[i].FindControl("cbSelect");

                if (cb.Checked)
                {
                    amountchecked = amountchecked + 1;
                }
            }

            if (amountchecked < 1)
            {
                lblMessage.Text = "Please Select a product to work with";
            }

            if (amountchecked > 1)
            {
                lblMessage.Text = "Please Select only one product to work with";

            }
            else
            {
                for (int i = 0; i < gvMyAuctions.Rows.Count; i++)                             //If all conditions are good pull the information from the one selected
                {
                    CheckBox cb;
                    cb = (CheckBox)gvMyAuctions.Rows[i].FindControl("cbSelect");

                    if (!cb.Checked)
                    {
                        continue;
                    }
                    else
                    {
                        
                        Customer user;
                        user = (Customer)Session["User"];
                        string username = user.username;


                        ShowEditFunctions();
                        txtProductName.Text = gvMyAuctions.Rows[i].Cells[1].Text;
                        txtProductDescription.Text = gvMyAuctions.Rows[i].Cells[2].Text;
                        txtReservePrice.Text = gvMyAuctions.Rows[i].Cells[3].Text;

                        string productname = txtProductName.Text;
                        string productdescription = txtProductDescription.Text;


                        OnlineAuctionSvc.OnlineAuction pxy = new OnlineAuctionSvc.OnlineAuction();
                        int productID = pxy.GetProductID(productname, productdescription);
                        Session["ProductID"] = productID;

                    }

                }
            }

        }

        protected void btnSubmitEdit_Click(object sender, EventArgs e)
        {

            string productname = txtProductName.Text;
            string productdescription = txtProductDescription.Text;
            decimal reserveprice = decimal.Parse(txtReservePrice.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Number);
            int productID = (int)Session["ProductID"];



            OnlineAuctionSvc.OnlineAuction pxy = new OnlineAuctionSvc.OnlineAuction();

            int x = pxy.ModifyProductDB(productID, productname, productdescription, reserveprice);
            if (x > 0)
            {
                HideEditFunctions();

                Customer user;
                user = (Customer)Session["User"];
                string username = user.username;
                lblMessage.Text = "Success. You have edited that product";
                DBConnect objDB = new DBConnect();
                DataSet myDS = pxy.ViewMyAuctions(username);

                gvMyAuctions.DataSource = myDS;
                gvMyAuctions.DataBind();

            }
            else
            {
                lblMessage.Text = "Error, please try again.";
            }


        


        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvMyAuctions.Rows.Count; i++)       //Input Validation to make sure one and only one checkbox is selected
            {
                CheckBox cb;
                cb = (CheckBox)gvMyAuctions.Rows[i].FindControl("cbSelect");

                if (cb.Checked)
                {
                    amountchecked = amountchecked + 1;
                }
            }

            if (amountchecked < 1 || amountchecked > 1)
            {
                lblMessage.Text = "Please Select only one restaurant to work with at a time.";
            }
            else
            {
                for (int i = 0; i < gvMyAuctions.Rows.Count; i++)                             //If all conditions are good pull the information from the one selected
                {
                    CheckBox cb;
                    cb = (CheckBox)gvMyAuctions.Rows[i].FindControl("cbSelect");

                    if (!cb.Checked)
                    {
                        continue;
                    }
                    else
                    {
                       

                        string productname = gvMyAuctions.Rows[i].Cells[1].Text;
                        string productdescription = gvMyAuctions.Rows[i].Cells[2].Text;



                        OnlineAuctionSvc.OnlineAuction pxy = new OnlineAuctionSvc.OnlineAuction();
                        int productID = pxy.GetProductID(productname, productdescription);


                        Customer user;
                        user = (Customer)Session["User"];
                        string username = user.username;



                        int x = pxy.DeleteProductDB(productID);

                        if (x > 0)
                        {
                            lblMessage.Text = "Success. You have deleted that product";
                            DBConnect objDB = new DBConnect();
                            DataSet myDS = pxy.ViewMyAuctions(username);

                            gvMyAuctions.DataSource = myDS;
                            gvMyAuctions.DataBind();

                        }
                        else
                        {
                            lblMessage.Text = "Error. Please try again.";
                        }
                    }



                }

            }

        }

        protected void btnReturnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHome.aspx");
        }
    }
}