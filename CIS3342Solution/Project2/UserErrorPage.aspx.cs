using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project2
{
    public partial class UserErrorPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNewLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("RestaurantReviewHome.aspx");
        }

        protected void btnReturnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHome.aspx");
        }

        protected void btnLoginPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("RestaurantReviewHome.aspx");

        }
    }
}