using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestaurantLibrary;
using Utilities;


namespace Project2
{
    public partial class AddReview : System.Web.UI.Page
    {
        String rname = "";
        String raddress = "";

        protected void Page_Load(object sender, EventArgs e)
        {

            UserFunctions uf = new UserFunctions();
            rname = Session["Restaurant Name"].ToString();
            lblRestaurantName.Text = rname;
            //Correlates the Restaurant Name to the Restaurant ID

            UserObject user = (UserObject)Session["User"];
            string username = user.username;

            raddress = Session["Restaurant Address"].ToString();

        }

        protected void btnReturnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHome.aspx");
        }

        protected void btnAddReview_Click(object sender, EventArgs e)
        {

            UserFunctions uf = new UserFunctions();

            if (txtReview.Text == "")
            {
                lblErrorMessage.Text = "Please say something about the restaurant.";
            }
            else
            {
                UserObject user = (UserObject)Session["User"];
                string username = user.username;
                string RestaurantName = lblRestaurantName.Text;
                int RestID = uf.GetRestaurantID(rname, raddress);

                int qualityrating = int.Parse(ddlQualityRating.Text);
                int pricerating = 5;



                if (uf.AddNewReviewDB(username, RestID, txtReview.Text, pricerating, qualityrating) > 0)
                {
                    uf.CalculateAverages(RestID);
                    Response.Redirect("UserHome.aspx");
                }
                else
                {
                    lblErrorMessage.Text = "Error. Please try again.";
                }
            }
        }
    }
}