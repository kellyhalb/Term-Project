using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using RestaurantLibrary;

namespace Project2
{
    public partial class DeclareRestaurant : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DBConnect objDB = new DBConnect();
                String strSQL = "SELECT * From Restaurant";
                DataSet myDS = objDB.GetDataSet(strSQL);

                gvRestaurants.DataSource = myDS;
                gvRestaurants.DataBind();
            }


        }

        protected void btnReturnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHome.aspx");
        }

        protected void btnAddRestaurant_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddRestaurant.aspx");

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            UserObject user;
            user = (UserObject)Session["User"];
            string username = user.username;

            int amountchecked = 0;

            for (int i = 0; i < gvRestaurants.Rows.Count; i++)       //Input Validation to make sure one and only one checkbox is selected
            {
                CheckBox cb;
                cb = (CheckBox)gvRestaurants.Rows[i].FindControl("cbSelect");

                if (cb.Checked)
                {
                    amountchecked = amountchecked + 1;
                }
            }

            if (amountchecked < 1 || amountchecked > 1)
            {
                lblErrorMessage.Text = "You can only select one restaurant of which to be a representative.";
            }
            else
            {
                for (int i = 0; i < gvRestaurants.Rows.Count; i++)                             //If all conditions are good pull the information from the one selected
                {
                    CheckBox cb;
                    cb = (CheckBox)gvRestaurants.Rows[i].FindControl("cbSelect");

                    if (!cb.Checked)
                    {
                        continue;
                    }
                    else
                    {
                        UserFunctions uf = new UserFunctions();

                        string restaurantname = gvRestaurants.Rows[i].Cells[1].Text;
                        string restaurantaddress = gvRestaurants.Rows[i].Cells[2].Text;
                        int restaurantID = uf.GetRestaurantID(restaurantname, restaurantaddress);

                        UserObject user1;
                        user1 = (UserObject)Session["User"];
                        string repUsername = user1.username;

                        string sqlcheck = "SELECT * FROM RestaurantRepresentative WHERE Username ='" + username + "'";



                        DBConnect objDB = new DBConnect();
                        DataSet checkingDS = objDB.GetDataSet(sqlcheck);

                        if (checkingDS.Tables[0].Rows.Count == 0)
                        {

                            if ((uf.DeclareRestaurantAssignmentDB(username, restaurantID)) > 0)
                            {
                                lblErrorMessage.Text = "Success. You have selected the restaurant of which you work.";
                                String strSQL = "SELECT Reservation.Time, Reservation.Date, Reservation.PartySize, Restaurant.Name, Restaurant.Address FROM Reservation JOIN Restaurant ON Reservation.RestaurantID=Restaurant.RestaurantID WHERE Username='" + username + "'"; //Pull all reservations where username is this
                                DataSet myDS = objDB.GetDataSet(strSQL);
                            }

                            else
                            {
                                lblErrorMessage.Text = "Error. Please try again.";
                            }
                        }

                        else
                        {
                            lblErrorMessage.Text = "You already work someowhere else.";
                        }

                    }



                }
            }
        }
    }
}