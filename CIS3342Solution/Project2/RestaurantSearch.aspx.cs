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
    public partial class RestaurantSearch : System.Web.UI.Page
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

        protected void btnSearchCuisine_Click(object sender, EventArgs e)
        {
            string cuisine = ddlCuisineSearch.Text;
            DBConnect objDB = new DBConnect();
            String strCuisineSQL = "SELECT * From Restaurant WHERE Cuisine = '" + cuisine + "'";
            DataSet myDS = objDB.GetDataSet(strCuisineSQL);

            gvRestaurants.DataSource = myDS;
            gvRestaurants.DataBind();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < gvRestaurants.Rows.Count; x++)
            {

                DropDownList ddlRestaurantAction = (DropDownList)gvRestaurants.Rows[x].FindControl("ddlRestaurantAction");
                string action = ddlRestaurantAction.SelectedItem.Text;


                if (ddlRestaurantAction.Text == "")
                {
                    lblErrorMessage.Text = "You must select a desired action";
                }

                else
                {
                    if (ddlRestaurantAction.Text == "Add a Review")
                    {
                        string restaurantname = gvRestaurants.Rows[x].Cells[1].Text;
                        Session["Restaurant Name"] = restaurantname;

                        string restaurantaddress = gvRestaurants.Rows[x].Cells[3].Text;
                        Session["Restaurant Address"] = restaurantaddress;

                        Response.Redirect("AddReview.aspx");
                    }
                    if (ddlRestaurantAction.Text == "Make a Reservation")
                    {
                        string restaurantname = gvRestaurants.Rows[x].Cells[1].Text;
                        Session["Restaurant Name"] = restaurantname;

                        string restaurantaddress = gvRestaurants.Rows[x].Cells[3].Text;
                        Session["Restaurant Address"] = restaurantaddress;


                        Response.Redirect("MakeReservation.aspx");
                    }
                   
                    
                    if (ddlRestaurantAction.Text == "View Reviews")
                    {
                        string restaurantname = gvRestaurants.Rows[x].Cells[1].Text;
                        Session["Restaurant Name"] = restaurantname;

                        string restaurantaddress = gvRestaurants.Rows[x].Cells[3].Text;
                        Session["Restaurant Address"] = restaurantaddress;


                        Response.Redirect("ViewReviews.aspx");
                    }



                    else
                    {
                        lblErrorMessage.Text = "Error. You must select an action.";
                    }

                }
            }
        }

        protected void btnReturnHomeFromRestaurants_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHome.aspx");
        }

        protected void btnSearchByQuality_Click(object sender, EventArgs e)
        {
            decimal quality = Convert.ToDecimal(ddlQualityRating.Text);
            DBConnect objDB = new DBConnect();
            String strSearchSQL = "SELECT * From Restaurant WHERE QualityRating = " + quality + "";
            DataSet myDS = objDB.GetDataSet(strSearchSQL);

            gvRestaurants.DataSource = myDS;
            gvRestaurants.DataBind();
        }

        protected void btnSearchByPrice_Click(object sender, EventArgs e)
        {
            decimal price = Convert.ToDecimal(ddlPriceRating.Text);
            DBConnect objDB = new DBConnect();
            String strSearchSQL = "SELECT * From Restaurant WHERE PriceRating = " + price + "";
            DataSet myDS = objDB.GetDataSet(strSearchSQL);

            gvRestaurants.DataSource = myDS;
            gvRestaurants.DataBind();

        }
    }
}