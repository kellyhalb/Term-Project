using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;


namespace AuctionLibrary
{
    public class CustomerFunctions
    {
        DBConnect objDB;

        public CustomerFunctions()
        {
            objDB = new DBConnect();
        }

        public void AddNewUserDB(string name, string email, string username, string password, string accounttype)
        {
            string sqlupdateDB = "INSERT INTO Customers (Name, Email, Username, Password, AccountType) VALUES ('" + name + "', '" + email + "', '" + username + "', '" + password + "', '" + accounttype + "')";

            objDB.DoUpdate(sqlupdateDB);
        }

    }
}
