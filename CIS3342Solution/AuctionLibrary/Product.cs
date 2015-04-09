using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionLibrary
{
    public class Product
    {

        
        public string productname;
        public string productdescription;
        public string sellerusername;
        public DateTime auctionenddate;
        public decimal currentbid;
        public decimal reserveprice;




        public Product(string productname, string productdescription, string sellerusername, DateTime auctionenddate, decimal currentbid, decimal reserveprice)
        {
            this.productname = productname;
            this.productdescription = productdescription;
            this.sellerusername = sellerusername;
            this.auctionenddate = auctionenddate;
            this.currentbid = currentbid;
            this.reserveprice = reserveprice;

        }


        public Product()
        {
        }


        public string Productname
        {
            get { return productname; }
            set { productname = value; }
        }


        public string Productdescription
        {
            get { return productdescription; }
            set { productdescription = value; }
        }

        public string Sellerusername
        {
            get { return sellerusername; }
            set { sellerusername = value; }
        }

        public DateTime Auctionenddate
        {
            get { return auctionenddate; }
            set { auctionenddate = value; }
        }

        public decimal Currentbid
        {
            get { return currentbid; }
            set { currentbid = value; }
        }
        public decimal Reserveprice
        {
            get { return reserveprice; }
            set { reserveprice = value; }
        }


    }
}
