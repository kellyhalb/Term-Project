using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using RestaurantLibrary;


namespace Project2
{
    public partial class MakeReservation : System.Web.UI.Page
    {
        String rname = "";
        String raddress = "";


        protected void Page_Load(object sender, EventArgs e)
        {
            UserFunctions uf = new UserFunctions();
            rname = Session["Restaurant Name"].ToString();
            lblRestaurantName.Text = rname;

            raddress = Session["Restaurant Address"].ToString();
            lblRestaurantAddress.Text = raddress;


            //UserObject user = (UserObject)Session["User"];
           // string username = user.username;


            DateTime dateAndTime = DateTime.Now;
            string currentdate = dateAndTime.ToString("dd/MM/yyyy");

        }

        protected void btnReturnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHome.aspx");

        }

        protected void btnSearchNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("RestaurantSearch.aspx");
        }

        protected void btnBookReservation_Click(object sender, EventArgs e)
        {
            
            string time = ddlResTime.Text;
            string partysizetext = ddlPartySize.Text;
            
      


            if ((ddlMonth.Text == "Month") || (ddlDay.Text == "Day") || (ddlYear.Text == "Year"))  //Input Validation for Date
            {
                lblErrorMessage.Text = "Please select a valid date for your reservation.";
            }

            if (time == "")   //Input validation for Time
            {
                lblErrorMessage.Text = "Please make sure you have selected a time for your reservation.";
            }
            if (partysizetext == "") //Input Validation for Party Size
            {
                lblErrorMessage.Text = "Please enter a valid size for your party.";
            }


            else
            {

                string month = ddlMonth.Text;
                string day = ddlDay.Text;
                string year = ddlYear.Text;
                String date = month + " " + day + " " + year;      //Concatinates the parts of the date to create one date string


                int partysize = Convert.ToInt32(ddlPartySize.Text);

                UserObject user = (UserObject)Session["User"];
                string username = user.username;

                UserFunctions uf = new UserFunctions();

                int restaurantID = uf.GetRestaurantID(rname, raddress);       //Gets Rest ID using the name and address

                
                if (uf.AddNewReservationDB(time, date, username, restaurantID, partysize) > 0)    //Checks if database update works
                {
                    Response.Redirect("ReservationConfirmation.aspx");    //If it works redirect to confirmation page
                }

                else
                {
                    lblErrorMessage.Text = "Error. Please try again.";
                }

            

            }


        }


        


    }
}