using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Utilities;
using System.Data;
using AuctionLibrary;

namespace Project3WS
{
    /// <summary>
    /// Summary description for OnlineAuction
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class OnlineAuction : System.Web.Services.WebService
    {

        [WebMethod]

        public void AddNewProductDB(string productname, string productdescription, decimal startingprice, decimal reserveprice, string username, string category, string subcategory, DateTime date)
        {
            int bids = 0;
            DBConnect objDB = new DBConnect();
            string sqlupdateDB = "INSERT INTO Products (ProductName, ProductDescription, StartingPrice, ReservePrice, Bids, Username, Category, Subcategory, AuctionEndDate) VALUES ('" + productname + "', '" + productdescription + "', " + startingprice + ", " + reserveprice + ", " +bids+ ", '" + username + "', '" + category + "', '" +subcategory+ "', '" +date+ "')";
            objDB.DoUpdate(sqlupdateDB);
        }

        [WebMethod]

        public DataSet UpdateForDate()
        {
            DateTime currentdate = DateTime.Now;
            DBConnect objDB = new DBConnect();
            string sqlUpdateDB = "SELECT * FROM Products";
            DataSet myDS = objDB.GetDataSet(sqlUpdateDB);

            for (int x = 0; x < myDS.Tables[0].Rows.Count; x++)
            {
               DateTime AuctionEndDate = (DateTime) myDS.Tables[0].Rows[x][10];
               int compare = DateTime.Compare(currentdate, AuctionEndDate);
               if (compare > 0)
               {


                  int productID = Convert.ToInt32(myDS.Tables[0].Rows[x][0]);

                  MakeInactiveDB(productID);


                   string productname =  myDS.Tables[0].Rows[x][1].ToString();
                  decimal reserveprice = Convert.ToDecimal(myDS.Tables[0].Rows[x][4]);
                   int bids = Convert.ToInt32(myDS.Tables[0].Rows[x][5]); 
                   string sellerusername = myDS.Tables[0].Rows[x][6].ToString();
                   decimal currentbid = Convert.ToDecimal(myDS.Tables[0].Rows[x][11]);
                   string winnerusername = myDS.Tables[0].Rows[x][13].ToString();
                   

                   if (currentbid > reserveprice)
                   {
                       int thisproductID = Convert.ToInt32(myDS.Tables[0].Rows[x][0]);
                       string didsell = "Yes";
                       ChangeIfSoldDB(productID, didsell);
                       MakeInactiveDB(productID);

                   }
                   else
                   {
                       int thisproductID = Convert.ToInt32(myDS.Tables[0].Rows[x][0]);
                       string didsell = "No";
                       ChangeIfSoldDB(productID, didsell);
                       MakeInactiveDB(productID);
                   }



                   MovetoTransactions(sellerusername, productname, bids, currentbid, winnerusername);

               }
                else
                {
                    continue;
                }
            }


            objDB.DoUpdate(sqlUpdateDB);
            string SQL = "SELECT * FROM Products where Active = 'Yes'";
            DataSet myActiveProducts = objDB.GetDataSet(SQL);

            return myActiveProducts;


        }
        [WebMethod]
        public void MakeInactiveDB(int productid)
        {
            DBConnect objDB = new DBConnect();
            string sqlUpdateDB = "UPDATE Products SET Active = 'No' WHERE ProductID = " +productid+ "";
            objDB.DoUpdate(sqlUpdateDB);

        }
        [WebMethod]
        public void ChangeIfSoldDB(int productid, string didsell)
        {
            DBConnect objDB = new DBConnect();
            string sql = "UPDATE Products SET DidSell = '" +didsell+ "' WHERE ProductID = " +productid+ "";
            objDB.DoUpdate(sql);
        }


        [WebMethod]
        public void MovetoTransactions(string sellerusername, string productname, int bids, decimal currentbid, string winnerusername)
        {

        //string sql = "INSERT into Transactions (SellerUsername, DidSell, SellingPrice, TotalBids, WinenrUsername) VALUES ('"+ sellerusername + "', '" + 

        }

        [WebMethod]
        public Product RetrieveProductDB(int productID)
        {

            Product product = new Product();
            DBConnect objDB = new DBConnect();
            DataSet myDS;
            string sql = "SELECT * FROM Products WHERE ProductID = " +productID+ "";
            myDS = objDB.GetDataSet(sql);
          //  DataSet myDS = new DataSet(sql);
           
            
            product.productname = myDS.Tables[0].Rows[0][1].ToString();
            product.productdescription = myDS.Tables[0].Rows[0][2].ToString();
            product.sellerusername = myDS.Tables[0].Rows[0][6].ToString();
            product.auctionenddate =(DateTime) myDS.Tables[0].Rows[0][10];
            product.currentbid = Convert.ToDecimal(myDS.Tables[0].Rows[0][11]);
            product.reserveprice = Convert.ToDecimal(myDS.Tables[0].Rows[0][4]);

             
           return product;   

        }

        [WebMethod]
        public void AddBidDB(int productID, decimal bidamount, string currentbidder)
        {
            DBConnect objDB = new DBConnect();
            string sql = "INSERT INTO Bids (Username, BidPrice, ProductID) VALUES ('" + currentbidder + "', " + bidamount + ", " + productID + ")";
            objDB.DoUpdate(sql);
        }

        [WebMethod]
        public void UpdateProductBidsDB(int productID, decimal currentbid, string bidderusername)
        {
            DBConnect objDB = new DBConnect();
            DataSet myDS = new DataSet();
            string sql = "SELECT * FROM Products WHERE ProductID = " +productID+"";
            myDS = objDB.GetDataSet(sql);
            int currentbids = Convert.ToInt32(myDS.Tables[0].Rows[0][5]);
            int updatedbids = currentbids + 1;

            string sqlupdate = "UPDATE Products SET Bids = " + updatedbids + ", CurrentBid = " +currentbid+ ", CurrentBidder = '" +bidderusername+"' WHERE ProductID = " + productID + "";
            objDB.DoUpdate(sqlupdate);

        }

        [WebMethod]
        public DataSet SearchByCategory(string category)
        {
            DBConnect objDB = new DBConnect();
            DataSet myDS = new DataSet();
            string sql = "SELECT * FROM Products WHERE Category = '" + category + "'";
            myDS = objDB.GetDataSet(sql);

            return myDS;


        }

        [WebMethod]
        public DataSet ViewMyAuctions(string username)
        {
            DBConnect objDB = new DBConnect();
            DataSet myDS = new DataSet();
            string sql = "SELECT * FROM Products WHERE Username = '" + username + "'";
            myDS = objDB.GetDataSet(sql);

            return myDS;
        }


        [WebMethod]
        public int GetProductID(string productname, string productdescription)
        {
            DBConnect objDB = new DBConnect();
            string SQL = "Select * FROM Products WHERE ProductName = '" + productname + "' AND ProductDescription = '" +productdescription + "'";
            DataSet myDS = objDB.GetDataSet(SQL);
            int productID = Convert.ToInt32(myDS.Tables[0].Rows[0][0]);

            return productID;
        }


        [WebMethod]
        public int DeleteProductDB(int productID)
        {
            DBConnect objDB = new DBConnect();
            string sqlDelete = "DELETE from Products WHERE ProductID=" +productID+"";
            int x = objDB.DoUpdate(sqlDelete);

            return x;
        }
   

        [WebMethod]
        public int ModifyProductDB(int productID, string productname, string productdescription, decimal reserveprice)
        {
            DBConnect objDB = new DBConnect();
            string sqlUpdate = "UPDATE Products SET ProductName='" + productname + "', ProductDescription='" + productdescription + "', ReservePrice= " + reserveprice + " WHERE ProductID=" + productID + "";
            int x = objDB.DoUpdate(sqlUpdate);

            return x;
        }


        [WebMethod]
        public DataSet GetMyBids(string username)
        {
            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT Bids.BidPrice, Products.ProductName, Products.ProductImage FROM Bids JOIN Products ON Products.ProductID=Bids.ProductID WHERE Bids.Username='" + username + "'"; //Pull all bids where username is this
            DataSet myDS = objDB.GetDataSet(strSQL);

            return myDS;
        }


        [WebMethod]
          public void AddNewUserDB(string username, string password, string name, string email, string accounttype)
        {
            DBConnect objDB = new DBConnect();
            string sqlupdateDB = "INSERT INTO Accounts (Username, Password, Name, Email, AccountType) VALUES ('"+username+ "', '" +password+ "', '" +name+ "', '" +email+ "', '" +accounttype+ "'";   

            objDB.DoUpdate(sqlupdateDB);
        }

    }
}
