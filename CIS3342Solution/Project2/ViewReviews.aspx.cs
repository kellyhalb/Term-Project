using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using RestaurantLibrary;
using System.Data;

namespace Project2
{
    public partial class ViewReviews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String rname;
            String raddress;

            if (!IsPostBack)
            {
                UserFunctions uf = new UserFunctions();
                rname = Session["Restaurant Name"].ToString();
          

                raddress = Session["Restaurant Address"].ToString();
                
                DBConnect objDB = new DBConnect();

                int restid = uf.GetRestaurantID(rname, raddress);
                String strSQL = "SELECT * From Reviews WHERE RestaurantID = '" +restid+ "'";
                DataSet myDS = objDB.GetDataSet(strSQL);

                gvReviews.DataSource = myDS;
                gvReviews.DataBind();
            }
        }

        protected void btnReturnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHome.aspx");
        }

        protected void btnMakeReservation_Click(object sender, EventArgs e)
        {
            Response.Redirect("MakeReservation.aspx");
            

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("RestaurantSearch.aspx");
        }
    }
}