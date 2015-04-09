using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AuctionLibrary;
using Utilities;
using System.Data;

namespace Project3
{
    public partial class AuctionLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (txtDesiredUsername.Text == "")       //CHECKS FOR ANY BLANK FIELDS IN ACCOUNT CREATION
            {
                lblErrorMessage.Text = "Please make sure all fields are filled out correctly.";
                return;
            }
            if (txtNewName.Text == "")
            {
                lblErrorMessage.Text = "Please make sure all fields are filled out correctly.";
                return;
            }
            if (txtNewEmail.Text == "")
            {
                lblErrorMessage.Text = "Please make sure all fields are filled out correctly.";
                return;
            }

            if (txtDesiredPassword1.Text == "")
            {
                lblErrorMessage.Text = "Please make sure all fields are filled out correctly.";
                return;
            }
            if (txtDesiredPassword2.Text == "")
            {
                lblErrorMessage.Text = "Please make sure all fields are filled out correctly.";
                return;
            }
            if (ddlAccountType.Text == "")
            {
                lblErrorMessage.Text = "Please select which account type you are making.";
                return;
            }

            if (txtDesiredPassword1.Text != txtDesiredPassword2.Text)   //Checks to make sure the two passwords match
            {
                lblErrorMessage.Text = "Your passwords do not match.";
                return;
            }




            OnlineAuctionSvc.OnlineAuction pxy = new OnlineAuctionSvc.OnlineAuction();

            DBConnect objDB = new DBConnect();


            string desiredname = txtDesiredUsername.Text;
            string sqlCheck = "SELECT * From Accounts WHERE Username = '" + desiredname + "'";
            DataSet myDS = objDB.GetDataSet(sqlCheck);
           // String checking = myDS.Tables[0].Rows[0][0].ToString();


            if (myDS.Tables[0].Rows.Count > 0)
            {
                lblErrorMessage.Text = "Username is already taken. Please select another.";
            }


            else                                                            //if all fields ok make a new account and redirect to homepage
            {
                CustomerFunctions cf = new CustomerFunctions();

                string name = txtNewName.Text;

                string email = txtNewEmail.Text;
                string username = txtDesiredUsername.Text;
                string password = txtDesiredPassword1.Text;
                string accounttype = ddlAccountType.Text;

                Customer newUser = new Customer(name, email, username, password, accounttype);


              
                pxy.AddNewUserDB(username, password, name, email, accounttype);

                Session["User"] = newUser;



                Response.Redirect("UserHome.aspx");



            }
        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")                         //CHECKS FOR ANY BLANK FIELDS IN ACCOUNT LOGON
            {
                lblErrorMessage.Text = "Please enter a Username";
            }
            if (txtPassword.Text == "")
            {
                lblErrorMessage.Text = "Please enter a password";
            }
            else                                           //IF ALL FIELDS FILLED IN MOVE INTO CHECKING IF THEIR ACCOUNT EXISTS
            {

                string username = txtUsername.Text;
                string password = txtPassword.Text;


                DBConnect objDB = new DBConnect();
                String strSQL = "SELECT Username, Password FROM Accounts WHERE Username = '" + username + "' AND Password ='" + password + "'";
                DataSet myDS = objDB.GetDataSet(strSQL);


                if (myDS.Tables[0].Rows.Count <= 0)   //CHECK IF THERES ANY MATCHING USERNAME/PASSWORD
                {
                    lblErrorMessage.Text = "Check and make sure your usename and password is correct.";   //USERNAME AND PASSWORD ARE BAD
                }

                else
                {


                    string retriveuserSQL = "SELECT * FROM Accounts WHERE Username= '" + username + "'";
                    DataSet myUserDS = objDB.GetDataSet(retriveuserSQL);

                    string name = Convert.ToString(myUserDS.Tables[0].Rows[0][1]);
                    string email = Convert.ToString(myUserDS.Tables[0].Rows[0][3]);
                    string accounttype = Convert.ToString(myUserDS.Tables[0].Rows[0][5]);


                    Customer customer = new Customer(name, email, username, password, accounttype);
                    Session["User"] = customer;

                    Response.Redirect("UserHome.aspx");   //USERNAME AND PASSWORD ARE GOOD
                }
            }
        }
    }
}
