using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary
{
    public class UserObject
    {
        public string name;
        public string phone;
        public string email;
        public string username;
        public string password;
        public string accounttype;




        public UserObject(string aname, string aphone, string aemail, string ausername, string apassword, string aaccounttype)
        {
            name = aname;
            phone = aphone;
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

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
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
