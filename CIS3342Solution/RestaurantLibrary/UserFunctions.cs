using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;


namespace RestaurantLibrary
{
   
    public class UserFunctions
    {
        DBConnect objDB;


        public UserFunctions()
        {
            objDB = new DBConnect();
        }


        public void AddNewUserDB(string name, string phone, string email, string username, string password, string accounttype)
        {
            string sqlupdateDB = "INSERT INTO User_t (Name, Phone, Email, Username, Password, AccountType) VALUES ('"+name+ "', '" +phone+ "', '" +email+ "', '" +username+ "', '" +password+ "', '" +accounttype+ "')"; 

            objDB.DoUpdate(sqlupdateDB);
        }


        public void AddNewRestaurantDB(string name, string address, string phone, string cuisine)
        {
            string sqlupdateDB = "INSERT INTO Restaurant (Name, Address, PhoneNumber, Cuisine) VALUES ('" + name + "', '" + address + "', '" + phone + "', '" + cuisine + "')";

            objDB.DoUpdate(sqlupdateDB);
        }


        public int AddNewReviewDB(string username, int restaurantID, string review, int pricerating, int qualityrating)
        {
            string sqlupdateDB = "INSERT INTO Reviews (Username, RestaurantID, Review, PriceRating, QualityRating) VALUES ('" + username + "', " + restaurantID + ", '" + review + "', " + pricerating + ", "+qualityrating+ ")";

            int x = objDB.DoUpdate(sqlupdateDB);

            return x;
        }


        public int AddNewReservationDB(string time, string date, string username, int restid, int partysize)
        {
            string sqlupdateDB = "INSERT INTO Reservation (Time, Date, Username, RestaurantID, PartySize) VALUES ('" + time + "', '" + date + "', '" + username + "', " + restid + ", " + partysize + ")";

            int x = objDB.DoUpdate(sqlupdateDB);

            return x;
        }

        public int DeclareRestaurantAssignmentDB(string username, int restid)
        {

            string sqlupdateDB = "INSERT INTO RestaurantRepresentative (Username, RestaurantID) VALUES ('" + username + "', " + restid + ")";

            int x = objDB.DoUpdate(sqlupdateDB);

            return x;

        }




        public int DeleteReservationDB(string username, string date, string time)
        {
            string sqlDelete = "DELETE from Reservation WHERE Username='" + username + "' AND Date ='" + date + "' AND Time='" + time + "'";
            int x = objDB.DoUpdate(sqlDelete);

            return x;
        }

        public int DeleteReviewDB(string username, int restID, string review)
        {
            string sqlDelete = "DELETE from Reviews WHERE Username='" + username + "' AND RestaurantID =" + restID + " AND Review='" + review + "'";
            int x = objDB.DoUpdate(sqlDelete);

            return x;
        }


        public int ModifyReviewDB(int reviewID, string newreviewcomments, int newpricerating, int newqualityrating)
        {
            string sqlUpdate = "UPDATE Reviews SET Review='" + newreviewcomments + "', PriceRating=" + newpricerating + ", QualityRating=" + newqualityrating + " WHERE ReviewID=" + reviewID + "";
            int x = objDB.DoUpdate(sqlUpdate);

            return x;
        }



        public int GetRestaurantID(string restaurantname, string restaurantaddress)
        {
            string findrestaurantSQL = "Select * FROM Restaurant WHERE Name = '" + restaurantname + "' AND Address = '" +restaurantaddress + "'";
            DataSet myDS = objDB.GetDataSet(findrestaurantSQL);
            int RestID = Convert.ToInt32(myDS.Tables[0].Rows[0][0]);

            return RestID;
        }


        public int GetReviewID(string username, string reviewcommentsinitial, int priceratinginitial, int qualityratinginitial)
        {
            string findreviewSQL = "Select * FROM Reviews WHERE Username = '" + username + "' AND Review = '" +reviewcommentsinitial + "' AND PriceRating =" +priceratinginitial+ " AND QualityRating = " +qualityratinginitial+"";
            DataSet myDS = objDB.GetDataSet(findreviewSQL);
            int ReviewID = Convert.ToInt32(myDS.Tables[0].Rows[0][0]);

            return ReviewID;

        }


        public void CalculateAverages(int restid)
        {
            string sqlRetrieve = "SELECT AVG(PriceRating) AS PriceAverage, AVG(QualityRating) AS QualityAverage FROM Reviews WHERE RestaurantID=" +restid+ "";
            DataSet myDS = objDB.GetDataSet(sqlRetrieve);
            decimal PriceAverage = Convert.ToDecimal(myDS.Tables[0].Rows[0][0]);
            decimal QualityAverage = Convert.ToDecimal(myDS.Tables[0].Rows[0][1]);
            PriceAverage = Math.Round(PriceAverage, 3);
            QualityAverage = Math.Round(QualityAverage, 3);

            string sqlUpdateDB = "UPDATE Restaurant SET PriceRating=" + PriceAverage + ", QualityRating=" + QualityAverage + " WHERE RestaurantID = " + restid + "";
            objDB.DoUpdate(sqlUpdateDB);

        }

        
        


        //public void FindRestaurantByCuisineDB(string cuisine);
        //{
        
        //}






    }
}
