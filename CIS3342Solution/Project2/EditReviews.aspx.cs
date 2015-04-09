using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestaurantLibrary;
using Utilities;
using System.Data;

namespace Project2
{
    public partial class EditReviews : System.Web.UI.Page
    {

       public int amountchecked = 0;
       public int priceratinginitial;
       public int qualityratinginitial;
       public string reviewcommentsinitial;

       public int newpricerating;
       public int newqualityrating;
       public string newreviewcomments;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UserObject user;
                user = (UserObject)Session["User"];
                string username = user.username;



                String strSQL = "SELECT Reviews.Review, Reviews.PriceRating, Reviews.QualityRating, Restaurant.Name, Restaurant.Address FROM Reviews JOIN Restaurant ON Reviews.RestaurantID=Restaurant.RestaurantID WHERE Username='" + username + "'"; //Pull all reservations where username is this

                DBConnect objDB = new DBConnect();
                DataSet myDS = objDB.GetDataSet(strSQL);

                gvReviews.DataSource = myDS;
                gvReviews.DataBind();

            }
        }



        private void ShowEditFunctions()
        {
            TitleRestaurantName.Visible = true;
            TitleAddress.Visible = true;
            TitleNewPriceRating.Visible = true;
            TitleNewQualityRating.Visible = true;
            TitleReviewComments.Visible = true;
            txtNewComments.Visible = true;
            ddlPriceRating.Visible = true;
            ddlQualityRating.Visible = true;
            btnConfirmEdit.Visible = true;
            TitleEditReview.Visible = true;
        }
        private void HideEditFunctions()
        {
            TitleRestaurantName.Visible = false;
            TitleAddress.Visible = false;
            TitleNewPriceRating.Visible = false;
            TitleNewQualityRating.Visible = false;
            TitleReviewComments.Visible = false;
            txtNewComments.Visible = false;
            ddlPriceRating.Visible = false;
            ddlQualityRating.Visible = false;
            btnConfirmEdit.Visible = false;
            TitleEditReview.Visible = false;
            lblRestaurantName.Visible = false;
            lblRestaurantAddress.Visible = false;
        }





        protected void btnReturnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHome.aspx");
        }






        protected void lblEditReview_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvReviews.Rows.Count; i++)       //Input Validation to make sure one and only one checkbox is selected
            {
                CheckBox cb;
                cb = (CheckBox)gvReviews.Rows[i].FindControl("cbSelect");

                if (cb.Checked)
                {
                    amountchecked = amountchecked + 1;
                }
            }

            if (amountchecked < 1)
            {
                lblMessage.Text = "Please Select a restaurant to work with";
            }

            if (amountchecked > 1)
            {
                lblMessage.Text = "Please Select only one restaurant to work with";

            }
            else
            {
                for (int i = 0; i < gvReviews.Rows.Count; i++)                             //If all conditions are good pull the information from the one selected
                {
                    CheckBox cb;
                    cb = (CheckBox)gvReviews.Rows[i].FindControl("cbSelect");

                    if (!cb.Checked)
                    {
                        continue;
                    }
                    else
                    {
                        UserFunctions uf = new UserFunctions();
                        UserObject user;
                        user = (UserObject)Session["User"];
                        string username = user.username;


                        ShowEditFunctions();
                        lblRestaurantName.Text = gvReviews.Rows[i].Cells[1].Text;
                        lblRestaurantAddress.Text = gvReviews.Rows[i].Cells[2].Text;
                        priceratinginitial = Convert.ToInt32(gvReviews.Rows[i].Cells[3].Text);
                        ddlPriceRating.SelectedValue = gvReviews.Rows[i].Cells[3].Text;

                        qualityratinginitial = Convert.ToInt32(gvReviews.Rows[i].Cells[4].Text);
                        ddlQualityRating.SelectedValue = gvReviews.Rows[i].Cells[4].Text;

                        reviewcommentsinitial= gvReviews.Rows[i].Cells[5].Text;
                        txtNewComments.Text = gvReviews.Rows[i].Cells[5].Text;

                        int ReviewId = uf.GetReviewID(username, reviewcommentsinitial, priceratinginitial, qualityratinginitial);
                        Session["ReviewID"] = ReviewId;

                    }

                }
            }



        }




        protected void btnDeleteReview_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvReviews.Rows.Count; i++)       //Input Validation to make sure one and only one checkbox is selected
            {
                CheckBox cb;
                cb = (CheckBox)gvReviews.Rows[i].FindControl("cbSelect");

                if (cb.Checked)
                {
                    amountchecked = amountchecked + 1;
                }
            }

            if (amountchecked < 1 || amountchecked > 1)
            {
                lblMessage.Text = "Please Select only one restaurant to work with at a time.";
            }
            else
            {
                for (int i = 0; i < gvReviews.Rows.Count; i++)                             //If all conditions are good pull the information from the one selected
                {
                    CheckBox cb;
                    cb = (CheckBox)gvReviews.Rows[i].FindControl("cbSelect");

                    if (!cb.Checked)
                    {
                        continue;
                    }
                    else
                    {
                        UserFunctions uf = new UserFunctions();

                        string restaurantname = gvReviews.Rows[i].Cells[1].Text;
                        string restaurantaddress = gvReviews.Rows[i].Cells[2].Text;
                        string review = gvReviews.Rows[i].Cells[5].Text;
                        int restaurantID = uf.GetRestaurantID(restaurantname, restaurantaddress);


                        UserObject user;
                        user = (UserObject)Session["User"];
                        string username = user.username;




                        if (uf.DeleteReviewDB(username, restaurantID, review) > 0)
                        {
                            lblMessage.Text = "Success. You have deleted that review";
                            DBConnect objDB = new DBConnect();
                            String strSQL = "SELECT Reviews.Review, Reviews.PriceRating, Reviews.QualityRating, Restaurant.Name, Restaurant.Address FROM Reviews JOIN Restaurant ON Reviews.RestaurantID=Restaurant.RestaurantID WHERE Username='" + username + "'";
                            DataSet myDS = objDB.GetDataSet(strSQL);

                            gvReviews.DataSource = myDS;
                            gvReviews.DataBind();

                        }
                        else
                        {
                            lblMessage.Text = "Error. Please try again.";
                        }
                    }



                }

            }



        }

        protected void btnConfirmEdit_Click(object sender, EventArgs e)   //START WORKING HERE ON 3/11 -- work on updating an entry in the DB
        {
            UserFunctions uf = new UserFunctions();


            UserObject user;
            user = (UserObject) Session["User"];
            string username = user.username;

            string rname = lblRestaurantName.Text;
            string raddress = lblRestaurantAddress.Text;
            int restaurantID = uf.GetRestaurantID(rname, raddress);
            int reviewID = (int)Session["ReviewID"];

            newpricerating = Convert.ToInt32(ddlPriceRating.Text);
            newqualityrating = Convert.ToInt32(ddlQualityRating.Text);
            newreviewcomments = txtNewComments.Text;

            //priceratinginitial = (int)Session["priceratinginitial"];
            //qualityratinginitial = (int)Session["qualityratinginitial"];
            //reviewcommentsinitial = Session["reviewcommentsinitial"].ToString();

            //if (ddlPriceRating.Text == "")
            //{
            //    newpricerating = priceratinginitial;
            //}
            //else
            //{
            //    newpricerating = Convert.ToInt32(ddlPriceRating.Text);
            //}

            //if (ddlQualityRating.Text == "")
            //{
            //    newqualityrating = qualityratinginitial;
            //}
            //else
            //{
            //    newqualityrating = Convert.ToInt32(ddlQualityRating.Text);
            //}
            //if (txtNewComments.Text == "")
            //{
            //    newreviewcomments = reviewcommentsinitial;
            //}
            //else
            //{
            //    newreviewcomments = txtNewComments.Text;
            //}



            if (uf.ModifyReviewDB(reviewID, newreviewcomments,newpricerating, newqualityrating) > 0)
            {
                lblMessage.Text = "Success, You have edited your review.";
                HideEditFunctions();

                DBConnect objDB = new DBConnect();
                String strSQL = "SELECT Reviews.Review, Reviews.PriceRating, Reviews.QualityRating, Restaurant.Name, Restaurant.Address FROM Reviews JOIN Restaurant ON Reviews.RestaurantID=Restaurant.RestaurantID WHERE Username='" + username + "'";
                DataSet myDS = objDB.GetDataSet(strSQL);

                gvReviews.DataSource = myDS;
                gvReviews.DataBind();
            }
            else
            {
                lblMessage.Text = "Please try again.";
            }


           

        }
    }
}
