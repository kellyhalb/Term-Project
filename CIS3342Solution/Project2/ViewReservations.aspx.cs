using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using RestaurantLibrary;

namespace Project2
{
    public partial class ViewReservations : System.Web.UI.Page
    {

        int amountchecked;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UserObject user;
                user = (UserObject)Session["User"];       //Creates new user object from stored session
                string username = user.username;    //Pulls username so it knows whos reservations to pull

                if (username == null)                //if by some chance they managed to get here without logging in
                {
                    Response.Redirect("RestaurantReviewHome.aspx");
                }
                else
                {

                    DBConnect objDB = new DBConnect();
                    String strSQL = "SELECT Reservation.Time, Reservation.Date, Reservation.PartySize, Restaurant.Name, Restaurant.Address FROM Reservation JOIN Restaurant ON Reservation.RestaurantID=Restaurant.RestaurantID WHERE Username='" + username + "'"; //Pull all reservations where username is this
                    DataSet myDS = objDB.GetDataSet(strSQL);

                    gvReservations.DataSource = myDS;
                    gvReservations.DataBind();
                }
            }
        }

        protected void gvReservations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnReturnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHome.aspx");
        }

        protected void btnNewReservation_Click(object sender, EventArgs e)
        {
            Response.Redirect("RestaurantSearch.aspx");
        }

        protected void btnCancelReservation_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvReservations.Rows.Count; i++)       //Input Validation to make sure one and only one checkbox is selected
            {
                CheckBox cb;
                cb = (CheckBox)gvReservations.Rows[i].FindControl("cbSelectCancel");

                if (cb.Checked)
                {
                    amountchecked = amountchecked + 1;
                }
            }

            if (amountchecked < 1 || amountchecked > 1)
            {
                lblErrorMessage.Text = "Please Select only one restaurant to work with at a time.";
            }
            else
            {
                for (int i = 0; i < gvReservations.Rows.Count; i++)                             //If all conditions are good pull the information from the one selected
                {
                    CheckBox cb;
                    cb = (CheckBox)gvReservations.Rows[i].FindControl("cbSelectCancel");

                    if (!cb.Checked)
                    {
                        continue;
                    }
                    else
                    {
                        UserFunctions uf = new UserFunctions();

                        string restaurantname = gvReservations.Rows[i].Cells[1].Text;
                        string restaurantaddress = gvReservations.Rows[i].Cells[2].Text;
                        string date = gvReservations.Rows[i].Cells[3].Text;
                        string time = gvReservations.Rows[i].Cells[4].Text;
                        int restaurantID = uf.GetRestaurantID(restaurantname, restaurantaddress);
                        
                        UserObject user;
                        user = (UserObject) Session["User"];
                        string username = user.username;




                        if (uf.DeleteReservationDB(username, date, time) > 0)
                        {
                            lblErrorMessage.Text = "Success. You have canceled your reservation.";
                            DBConnect objDB = new DBConnect();
                            String strSQL = "SELECT Reservation.Time, Reservation.Date, Reservation.PartySize, Restaurant.Name, Restaurant.Address FROM Reservation JOIN Restaurant ON Reservation.RestaurantID=Restaurant.RestaurantID WHERE Username='" + username + "'"; //Pull all reservations where username is this
                            DataSet myDS = objDB.GetDataSet(strSQL);

                            gvReservations.DataSource = myDS;
                            gvReservations.DataBind();

                        }
                        else
                        {
                            lblErrorMessage.Text = "Error. Please try again.";
                        }
                    }



                }

            }
        }
    }
}