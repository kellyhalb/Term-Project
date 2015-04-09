using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Utilities;
using System.Data;

namespace Lab1
{
    public partial class DemoPage : System.Web.UI.Page
    {

        int count= 0;
        

        protected void Page_Load(object sender, EventArgs e)
        {

            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT * FROM Pizzas";
            DataSet myDS = objDB.GetDataSet(strSQL);

            gvPizza.DataSource = myDS;
            gvPizza.DataBind();


            gvPizzaOrder.DataSource = myDS;
            gvPizzaOrder.DataBind();

            if (IsPostBack == false)
                Session["MyCount"] = count;
            else
                count = int.Parse(Session["MyCount"].ToString());
                    

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            count++;
            Session["MyCount"] = count;
            lblDisplay.Text = "Hello " + txtInput.Text + ", Welcome to my First Page. Button clicked " + count + " times total.";
     
            
        }

        protected void gvPizza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}