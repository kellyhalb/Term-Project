using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using AuctionLibrary;
using Utilities;

namespace Project3
{
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string category = ddlProductCategory.Text;
                if (category == "")
                {
                    lblErrorMessage.Text = "Please select a product category";
                    return;
                }
                else
                {
                    string sqlretrieve = "SELECT * FROM ProductCategories WHERE Category = '" + category + "'";
                    DBConnect objDB = new DBConnect();
                    ddlProductSubCategory.DataSource = objDB.GetDataSet(sqlretrieve);
                    ddlProductSubCategory.DataTextField = "SubCategory";
                    ddlProductSubCategory.DataValueField = "SubCategory";

                    ddlProductSubCategory.DataBind();

                }

            }
        }

        protected void btnAddItem_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" || txtProductDescription.Text == "" || txtStartPrice.Text == "" || txtReservePrice.Text == "")
            {
                lblErrorMessage.Text = "Please write a name for the product.";
                return;
            }
            else
            {

                string productname = txtProductName.Text;
                string productdescription = txtProductDescription.Text;
                decimal startprice = Convert.ToDecimal(txtStartPrice.Text);
                decimal reserveprice = Convert.ToDecimal(txtReservePrice.Text);
                string category = ddlProductCategory.SelectedValue;
                string subcategory = ddlProductSubCategory.Text;
                DateTime date = calTime.SelectedDate;

                Customer c = (Customer)Session["User"];
                string username = c.username;


                OnlineAuctionSvc.OnlineAuction pxy = new OnlineAuctionSvc.OnlineAuction();


                pxy.AddNewProductDB(productname, productdescription, startprice, reserveprice, username, category, subcategory, date);

                lblErrorMessage.Text = "Success. You have added an item.";



                txtReservePrice.Text="";
                txtProductName.Text ="";
                txtStartPrice.Text="";
                txtProductDescription.Text="";

            }

        }

        protected void calTime_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void btnReturnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHome.aspx");
        }
    }
}