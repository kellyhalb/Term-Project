using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace PizzaLibrary
{
    public class OrderDetail
    {
        public double increase;
        public double pizzaprice;
        public double totalforonepizzatype;
        DBConnect objDB;


        public OrderDetail()
        {
            objDB = new DBConnect();
        }

        private double pricebysize(string pizzaSize)
        {
            if (pizzaSize == "Small")
            { increase = 1; }
            if (pizzaSize == "Medium")
            { increase = 1.25; }
            if (pizzaSize == "Large")
            { increase = 1.5; }
            return increase;
        }

        public double GetBasePrice(string pizzaType)
        {
            string sqlBasePrice = "SELECT BasePrice from Pizza WHERE PizzaType = '" + pizzaType + "'";

            DataSet myDS = objDB.GetDataSet(sqlBasePrice);
            //DataRow myDR = objDB.GetRow(myDS, 0);

            double price = Convert.ToDouble(myDS.Tables[0].Rows[0][0]);

            return price;
        }

        public double PizzaCost(string pizzaType, string pizzaSize)
        {
            double basePrice = GetBasePrice(pizzaType);
            double pizzaprice = pricebysize(pizzaSize); 
            double result= pizzaprice * basePrice;

            return result;
        }

        public double OnePizzaTypeTotalCost(double pizzaprice, int quantityOrdered)
        {
            totalforonepizzatype = pizzaprice * quantityOrdered;

            return totalforonepizzatype;
        }
 

        public void UpdateDBTotals(string pizzaType, int quantityOrdered,  double price)
        {
            double totalsales = OnePizzaTypeTotalCost(price, quantityOrdered) + GetTotalSalesforOnePizza(pizzaType);
            int totalquantity = quantityOrdered + GetQuantityforOnePizza(pizzaType);
            string sqlupdateDB = "UPDATE Pizza Set TotalSales=" + totalsales + ", TotalQuantityOrdered =" + totalquantity + " WHERE PizzaType='" + pizzaType + "'";

            objDB.DoUpdate(sqlupdateDB);
            
        }


        //METHODS TO RETRIEVE FROM DATABASE

        public double GetTotalSalesforOnePizza(string pizzaType)
        {
            string sqlRetrievePizza = "SELECT TotalSales from Pizza WHERE PizzaType = '" + pizzaType + "'";

            DataSet myDS = objDB.GetDataSet(sqlRetrievePizza);
            DataRow myDR = objDB.GetRow(myDS, 0);

            return double.Parse(myDR["TotalSales"].ToString());

        }

        public int GetQuantityforOnePizza(string pizzaType)
        {
            string sqlRetrieveQuantity = "SELECT TotalQuantityOrdered from Pizza WHERE PizzaType = '" + pizzaType + "'";

            DataSet myDS = objDB.GetDataSet(sqlRetrieveQuantity);
            DataRow myDR = objDB.GetRow(myDS, 0);

            return int.Parse(myDR["TotalQuantityOrdered"].ToString());
        }

}
}