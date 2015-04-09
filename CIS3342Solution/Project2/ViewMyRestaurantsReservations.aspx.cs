using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestaurantLibrary;
using System.Data;
using Utilities;

namespace Project2
{
    public partial class ViewMyRestaurantsReservations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                UserObject user;
                user = (UserObject)Session["User"];       //Creates new user object from stored session
                string username = user.username;    //Pulls username
                
                string retrieveSQL = "Select RestaurantID FROM RestaurantRepresentative WHERE Username ='" +username+"'";

                DBConnect objDB = new DBConnect();
                DataSet myDS = objDB.GetDataSet(retrieveSQL);
                int restaurantID = Convert.ToInt32(myDS.Tables[0].Rows[0][0]);  

                string populateGV = "Select * FROM Reservation WHERE RestaurantID =" +restaurantID+"";
                DataSet reservationsDS = objDB.GetDataSet(populateGV);
                 gvReservations.DataSource = reservationsDS;
                 gvReservations.DataBind();


            
            }




        }

        protected void btnReturnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHome.aspx");
        }
    }
}
