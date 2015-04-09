using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{


    public class PizzaObject
    {
        public string type;
        public string size;
        public int quantity;
        public double totalperpizza;
        public double total;

       public PizzaObject(string thistype, string thissize, int thisquantity, double thistotalperpizza, double thistotal)
        {
            type = thistype;
            size = thissize;
            quantity = thisquantity;
            totalperpizza = thistotalperpizza;
            total = thistotal;

        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double Totalperpizza
        {
            get { return totalperpizza; }
            set { totalperpizza = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }
        }



    }




}

