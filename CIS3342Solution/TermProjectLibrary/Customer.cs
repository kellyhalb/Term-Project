using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProjectLibrary
{
    public class Customer
    {
        public string name;
        public string email;
        public string address;
        public string username;
        public string password;

        public Customer(string name, string email, string address, string username, string password)
        {
            this.name = name;
            this.email = email;
            this.address = address;
            this.username = username;
            this.password = password;
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

        public string Address
        {
            get { return address; }
            set { address = value; }
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


    }
}
