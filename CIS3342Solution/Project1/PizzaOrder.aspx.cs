using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Collections;
using PizzaLibrary;


namespace Project1
{
    public partial class PizzaOrder : System.Web.UI.Page
    {
        
        OrderDetail pizzaOrder; 
        bool selected = false;
        ArrayList itemsOrdered = new ArrayList();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DBConnect objDB = new DBConnect();
                String strSQL = "SELECT * FROM Pizza";
                DataSet myDS = objDB.GetDataSet(strSQL);

                gvOrder.DataSource = myDS;
                gvOrder.DataBind();
            }

        }





        //METHODS

        private void showOrder()
        {
            gvOrderOutput.DataSource = itemsOrdered;
            gvOrderOutput.DataBind();
        }

        private void showLabels()
        {
            lblSummary.Visible = true;
            lblAddressSum.Visible = true;
            lblNameSum.Visible = true;
            lblPhoneSum.Visible = true;
            lblThanks.Visible = true;
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            pizzaOrder = new OrderDetail();


            if (txtboxName.Text == "")   //INPUT VALIDATION
            {
                lblErrorMessage.Text = "Please make sure all fields are filled out before submitting your order.";
            }
            if (txtboxAddress.Text == "")
            {
                lblErrorMessage.Text = "Please make sure all fields are filled out before submitting your order.";
            }
            if (txtboxPhone.Text == "")
            {
                lblErrorMessage.Text = "Please make sure all fields are filled out before submitting your order.";
            }
            if (PickUpDelivery.Text == "")
            {
                lblErrorMessage.Text = "Please make sure all fields are filled out before submitting your order.";
            }



            for (int i = 0; i < gvOrder.Rows.Count; i++)   //INPUT VALIDATION
            {

                CheckBox cb;
                TextBox txtQuan;
                //string quantitySpecified;

                cb = (CheckBox)gvOrder.Rows[i].FindControl("cbSelectPizza");
                //cb = (CheckBox)gvOrder.Rows[i].Cells[0].Controls[0];
                txtQuan = (TextBox)gvOrder.Rows[i].FindControl("txtQuantity");
                string strQuan = Convert.ToString(txtQuan.Text);

                if (cb.Checked)
                {
                    selected = true;
                }
                
                if ((cb.Checked) && (strQuan == ""))
                {
                    selected = true;
                    lblErrorMessage.Text = "Please select a pizza, quantity, and size for at least one pizza.";
                }

                else if (!(cb.Checked) && (selected == false))
                {

                    lblErrorMessage.Text = "Please enter a Quantity for the pizzas you have selected.";
                }
                else
                {
                    lblErrorMessage.Text = "";
                }

            }






                CheckBox cbselected;
                int TotalQuantity = 0;
                double Sales = 0;

                for (int x = 0; x < gvOrder.Rows.Count; x++)
                {
                    cbselected = (CheckBox)gvOrder.Rows[x].FindControl("cbSelectPizza");
                    DropDownList ddlSize = (DropDownList)gvOrder.Rows[x].FindControl("ddlSize");
                    string size = ddlSize.SelectedItem.Text;
                    TextBox textbox = (TextBox)gvOrder.Rows[x].FindControl("txtQuantity");


                    if (cbselected.Checked)
                    {
                        int validation = 0;
                        bool isanumber = int.TryParse(textbox.Text, out validation) && validation >= 1;

                        if (isanumber == false)
                        {
                            lblErrorMessage.Text = "You must enter a valid quantity";
                            break;
                        }

                        else
                        {


                            int quan;
                            bool result = int.TryParse(textbox.Text, out quan);
                            string type = gvOrder.Rows[x].Cells[1].Text;
                            int quantity = Convert.ToInt32(textbox.Text);

                            double pizzaPrice = pizzaOrder.PizzaCost(type, size); //gets price of the pizza
                            double totalPrice = pizzaOrder.OnePizzaTypeTotalCost(pizzaPrice, quantity);

                            PizzaObject pizzaobject = new PizzaObject(type, size, quantity, pizzaPrice, totalPrice);

                            itemsOrdered.Add(pizzaobject);

                            pizzaOrder.UpdateDBTotals(type, quantity, pizzaPrice);

                            TotalQuantity += quantity;
                            Sales += totalPrice;


                        }

                        showLabels();
                        lblNameEntered.Text = txtboxName.Text;
                        lblAddressEntered.Text = txtboxAddress.Text;
                        lblPhoneEntered.Text = txtboxPhone.Text;

                    }


                }
                gvOrderOutput.DataSource = itemsOrdered;
                gvOrderOutput.DataBind();

                gvOrderOutput.Columns[0].FooterText = "Total: ";
                gvOrderOutput.Columns[2].FooterText = TotalQuantity.ToString();
                gvOrderOutput.Columns[4].FooterText = Sales.ToString("C2");
                gvOrderOutput.DataBind();

                
                



            }




        protected void btnManager_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManagerialView.aspx");
        }














        }
    }
