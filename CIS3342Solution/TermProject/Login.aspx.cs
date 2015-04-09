using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using System.Data.SqlClient;


namespace TermProject
{
    public partial class Login : System.Web.UI.Page
    {
        HttpCookie objCookie;


        protected void Page_Load(object sender, EventArgs e)
        {
            objCookie = Request.Cookies["theCookie"];

            if(Request.Cookies["theCookie"] != null)
                {  txtUsername.Text = objCookie.Values["Username"].ToString(); }
        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

           

            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CheckUser";
            objCommand.Parameters.AddWithValue("@inputUsername", username);
            objCommand.Parameters.AddWithValue("@inputPassword", password);


            DBConnect objDB = new DBConnect();
            DataSet myDS;
            myDS = objDB.GetDataSetUsingCmdObj(objCommand);

            if (myDS.Tables[0].Rows.Count == 0)
            {
                lblMessage.Text = "Please check your username/password combination.";
            }
            else
            {
                if (rdoListLogin.SelectedItem.Value =="Remember Me")
                {

                    HttpCookie myCookie = new HttpCookie("theCookie");
                
                    myCookie.Expires = new DateTime(2016, 1, 1);
                    myCookie["Username"] = txtUsername.Text;
                    Response.Cookies.Add(myCookie);
                    //code here to create a cookie that remembers them
                }
                else if (rdoListLogin.SelectedItem.Value == "Don't Remember Me")
                {
                    //code here to delete the current cookie that remembers them
                }
                else
                {
                    //Code here to log them in without creating nor destroying any cookies
                }
            }


        }


        public bool checkIfDigits(string x)  //Method to make sure all characters of a given string a numbers
        {
          foreach (char c in x)
         {
            if (c < '0' || c > '9')
             return false;
          }
        return true;
        }       



        protected void btnCreateAccount_Click(object sender, EventArgs e)
        {

            //Input Validation for new Log-in
            if (txtNewName.Text == "" || txtNewEmail.Text == "" || txtNewAddress.Text == "" || txtNewState.Text == "" || txtNewZipCode.Text == "" || txtNewUsername.Text == "" || txtDesiredPassword.Text == "" || txtDesiredPassword1.Text == "")
            {
                lblMessage.Text = "Please make sure all fields are filled out";
                return;
            }

            if (txtDesiredPassword.Text != txtDesiredPassword1.Text)
            {
                lblMessage.Text = "Desired password and desired password confirmation do not match.";
                return;
            }
            if (txtNewState.Text.Length >2)
            {
                lblMessage.Text = "State must be written in 2 letter format, i.e. New Jersey = NJ";
                return;
            }

            bool zip = checkIfDigits(txtNewZipCode.Text); 

            if (zip == false)
            {
                lblMessage.Text = "Only numbers can be inputed as your zipcode.";
                return;
            }

            //If they make it past input validation then check if a cookie needs to be made
            string username = txtNewUsername.Text;
            string password = txtDesiredPassword.Text;
            string name = txtNewName.Text;
            string address = txtNewAddress.Text + ", " + txtNewCity.Text + ", " + txtNewState.Text + " " + txtNewZipCode.Text;
            string email = txtNewEmail.Text;


            if (rdoRememberMe.Checked)  //Remember Me is checked so make a cookie and create account
            {
                HttpCookie myCookie = new HttpCookie("theCookie");
                myCookie.Value = "CIS3342 Website";
                myCookie.Expires = new DateTime(2016, 1, 1);
                myCookie.Values["Username"] = txtUsername.Text;
                Response.Cookies.Add(myCookie);




            }

            else  //Remember me is not checked so create account without using a cookie
            {
                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "CreateNewUser";
                objCommand.Parameters.AddWithValue("@inputUsername", username);
                objCommand.Parameters.AddWithValue("@inputPassword", password);
                objCommand.Parameters.AddWithValue("@inputName", name);
                objCommand.Parameters.AddWithValue("@inputEmail", email);
                objCommand.Parameters.AddWithValue("@inputAddress", address);

                DBConnect objDB = new DBConnect();
                objDB.DoUpdateUsingCmdObj(objCommand); //adds user to DB using stored procedure

                //add code here to make a new customer object and create a session
            }


            

            
        }
    }
}