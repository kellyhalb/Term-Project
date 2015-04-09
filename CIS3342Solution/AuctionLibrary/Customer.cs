using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionLibrary
{
    public class Customer
    {


        public string name;
        public string email;
        public string username;
        public string password;
        public string accounttype;




        public Customer(string aname, string aemail, string ausername, string apassword, string aaccounttype)
        {
            name = aname;
            email = aemail;
            username = ausername;
            password = apassword;
            accounttype = aaccounttype;
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string AccountType
        {
            get { return accounttype; }
            set { accounttype = value; }
        }



    }
}


