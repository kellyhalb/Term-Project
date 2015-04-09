using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary
{
    public class RestaurantObject
    {
        public string restname;
        public string restaddress;
        public string restphone;
        public string restcuisine;
        public int restpricelevel;
        public int restrating;

        public RestaurantObject(string thisname, string thisaddress, string thisphone, string thiscuisine, int thispricelevel, int thisrating)
        {
            restname = thisname;
            restaddress = thisaddress;
            restphone = thisphone;
            restcuisine = thiscuisine;
            restpricelevel = thispricelevel;
            restrating = thisrating;

        }



        public string RestName
        {
            get { return restname; }
            set { restname = value; }
        }

        public string RestAddress
        {
            get { return restaddress; }
            set { restaddress = value; }
        }

        public string Restphone
        {
            get { return restphone; }
            set { restphone = value; }
        }

        public string Restcuisine
        {
            get { return restcuisine; }
            set { restcuisine = value; }
        }

        public int Restpricelevl
        {
            get { return restpricelevel; }
            set { restpricelevel = value; }
        }
        public int Restrating
        {
            get { return restrating; }
            set { restrating = value; }
        }




    }
}
