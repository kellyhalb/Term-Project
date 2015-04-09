using RestaurantLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace Project2
{
    public partial class UserHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         



        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("RestaurantSearch.aspx");
        }

        protected void btnAddRestaurant_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddRestaurant.aspx");
        }

        protected void btnViewMyReservations_Click(object sender, EventArgs e)
        {

            DBConnect objDB = new DBConnect();
            UserObject user;
            user = (UserObject)Session["User"];
            string username = user.username;
            string accounttype = user.accounttype;

            string SQL = "SELECT * FROM Reservation WHERE Username='" + username + "'";
            DataSet myDS = objDB.GetDataSet(SQL);


            if (myDS.Tables[0].Rows.Count == 0)
            {
                lblCantClick.Text = "You Don't currently have any reservations.";
            }
            else
            {
                Response.Redirect("ViewReservations.aspx");
            }
        }

        protected void btnViewReservationsRestaurant_Click(object sender, EventArgs e)
        {
            DBConnect objDB = new DBConnect();
            UserObject user;
            user = (UserObject)Session["User"];
            string username = user.username;
            string accounttype = user.accounttype;

            string SQL = "SELECT * FROM RestaurantRepresentative WHERE Username='" +username+"'";
            DataSet myDS = objDB.GetDataSet(SQL);

        

            if (accounttype == "User")
            {
                Response.Redirect("UserErrorPage.aspx");
            }
            else if(myDS.Tables[0].Rows.Count==0)
            {
                lblError.Text = "You must declare a restaurant that you work for before opening your reservations.";
            }

            else
            {
                Response.Redirect("ViewMyRestaurantsReservations.aspx");
            }
  
        }

        protected void btnAssignRestaurant_Click(object sender, EventArgs e)
        {


            UserObject user;
            user = (UserObject)Session["User"];
            string accounttype = user.accounttype;



            if (accounttype == "User")
            {
                Response.Redirect("UserErrorPage.aspx");
            }

            else
            {
                Response.Redirect("DeclareRestaurant.aspx");
            }
            
            
           
        }

        protected void btnViewEditDelete_Click(object sender, EventArgs e)
        {
            DBConnect objDB = new DBConnect();
            UserObject user;
            user = (UserObject)Session["User"];
            string username = user.username;
            string accounttype = user.accounttype;

            string SQL = "SELECT * FROM Reviews WHERE Username='" + username + "'";
            DataSet myDS = objDB.GetDataSet(SQL);


            if (myDS.Tables[0].Rows.Count == 0)
            {
                lblCantClick.Text = "You Don't currently have any reviews to edit or delete.";
            }
            else
            {

                Response.Redirect("EditReviews.aspx");
            }

        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("RestaurantReviewHome.aspx");
        }
    }
}