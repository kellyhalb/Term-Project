using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace Project1
{
    public partial class ManagerialView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            String strSQL = "SELECT * FROM Pizza";
            DataSet myDS = db.GetDataSet(strSQL);

            gvManager.DataSource = myDS;
            gvManager.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("PizzaOrder.aspx");
        }
    }
}