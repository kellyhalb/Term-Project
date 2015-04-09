using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestaurantLibrary;
using System.Data;

namespace Project2
{
    public partial class AddRestaurant : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAddRestaurantReturnHome_Click(object sender, EventArgs e)
        {


            UserFunctions uf = new UserFunctions();

            string name = txtnewRestName.Text;
            string phone = txtNewRestPhone.Text;
            string address = txtnewRestAddress.Text;
            string cuisinetype = ddlNewRestCuisine.Text;




            if (name == "")
            {
                lblErrorMessage.Text = "Please fill out all fields before submitting.";
                return;
            }
            if (phone == "")
            {
                lblErrorMessage.Text = "Please fill out all fields before submitting.";
                return;
            }
            if (address == "")
            {
                lblErrorMessage.Text = "Please fill out all fields before submitting.";
                return;
            }
            if (cuisinetype == "")
            {
                lblErrorMessage.Text = "Please fill out all fields before submitting.";
                return;
            }







            RestaurantObject newRestaurant = new RestaurantObject(name, address, phone, cuisinetype, 1, 1);
            uf.AddNewRestaurantDB(name, address, phone, cuisinetype);   //Adds record to the Restaurant Database
            Session["Restaurant"] = newRestaurant;

            Response.Redirect("UserHome.aspx");

        }

        protected void btnAddRestaurantMakeReview_Click(object sender, EventArgs e)
        {
            UserFunctions uf = new UserFunctions();

            string name = txtnewRestName.Text;
            string phone = txtNewRestPhone.Text;
            string address = txtnewRestAddress.Text;
            string cuisinetype = ddlNewRestCuisine.Text;



            RestaurantObject newRestaurant = new RestaurantObject(name, address, phone, cuisinetype, 1, 1);
            uf.AddNewRestaurantDB(name, address, phone, cuisinetype);   //Adds record to the Restaurant Database
            Session["Restaurant"] = newRestaurant;

            Response.Redirect("AddReview.aspx");
        }

        protected void btnReturnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHome.aspx");
        }
    }
}