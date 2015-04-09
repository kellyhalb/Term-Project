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
    public partial class RestaurantReviewHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreateNewAccount_Click(object sender, EventArgs e)    //New User
        {

                if (txtDesiredUsername.Text == "")       //CHECKS FOR ANY BLANK FIELDS IN ACCOUNT CREATION
                {
                    lblErrorMessage.Text = "Please make sure all fields are filled out correctly.";
                     return;
                }
                if (txtName.Text == "")
                {
                    lblErrorMessage.Text = "Please make sure all fields are filled out correctly.";
                     return;
                }
                if (txtEmail.Text == "")
                {
                    lblErrorMessage.Text = "Please make sure all fields are filled out correctly.";
                     return;
                }
                if (txtPhone.Text == "")
                {
                    lblErrorMessage.Text = "Please make sure all fields are filled out correctly.";
                     return;
                }
                if (txtDesiredPassword.Text == "")
                {
                    lblErrorMessage.Text = "Please make sure all fields are filled out correctly.";
                     return;
                }
                if (txtDesiredPasswordConfirm.Text == "")
                {
                    lblErrorMessage.Text = "Please make sure all fields are filled out correctly.";
                     return;
                }
                if (ddlRep.Text == "")
                {
                    lblErrorMessage.Text = "Please select which account type you are making.";
                    return;
                }

                if (txtDesiredPassword.Text != txtDesiredPasswordConfirm.Text)   //Checks to make sure the two passwords match
                {
                    lblErrorMessage.Text = "Your passwords do not match.";
                    return;
                }





            UserFunctions uf = new UserFunctions();
            DBConnect objDB = new DBConnect();

            string desiredname = txtDesiredUsername.Text;
            string sqlCheck = "SELECT * From User_t WHERE Username = '" + desiredname + "'";
            DataSet myDS = objDB.GetDataSet(sqlCheck);
            //String checking = myDS.Tables[0].Rows[0][0];


            if (myDS.Tables[0].Rows.Count>0)
            {
                lblErrorMessage.Text = "Username is already taken. Please select another.";
            }
       

                else                                                            //if all fields ok make a new account and redirect to homepage
                {

                    string name = txtName.Text;
                    string phone = txtPhone.Text;
                    string email = txtEmail.Text;
                    string username = txtDesiredUsername.Text;
                    string password = txtDesiredPassword.Text;
                    string accounttype = ddlRep.Text;

                    UserObject newUser = new UserObject(name, phone, email, username, password, accounttype);
                    uf.AddNewUserDB(name, phone, email, username, password, accounttype);   //Adds record to the User_t Database
                    Session["User"] = newUser;



                    Response.Redirect("UserHome.aspx");


              
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)         //Existing User
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
                String strSQL = "SELECT Username, Password FROM User_t WHERE Username = '" + username + "' AND Password ='" + password + "'";
                DataSet myDS = objDB.GetDataSet(strSQL);


                if (myDS.Tables[0].Rows.Count <= 0)   //CHECK IF THERES ANY MATCHING USERNAME/PASSWORD
                {
                    lblErrorMessage.Text = "Check and make sure your usename and password is correct.";   //USERNAME AND PASSWORD ARE BAD
                }

                else
                {
  
              
                    string retriveuserSQL = "SELECT * FROM User_t WHERE Username= '" + username + "'";
                    DataSet myUserDS = objDB.GetDataSet(retriveuserSQL);

                    string name = Convert.ToString(myUserDS.Tables[0].Rows[0][0]);
                    string phone = Convert.ToString(myUserDS.Tables[0].Rows[0][1]);
                    string email = Convert.ToString(myUserDS.Tables[0].Rows[0][2]);
                    string accounttype = Convert.ToString(myUserDS.Tables[0].Rows[0][5]);

                    UserObject user = new UserObject(name, phone, email, username, password, accounttype);
                    Session["User"] = user;

                    Response.Redirect("UserHome.aspx");   //USERNAME AND PASSWORD ARE GOOD
                }



            }





        }
    }
}