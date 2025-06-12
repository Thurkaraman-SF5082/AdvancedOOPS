using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickFoodz
{
    public class CartDetails
    {
        /*Properties: 
        a.	CartID (Auto Increment – CRID4000)
        b.	CustomerID
        c.	FoodID
        d.	FoodCount
        e.	PriceOfCart
        */
        private static int s_cartID = 4000;
        public string CartID { get; set; }
        public string CustomerID { get; set; }
        public string FoodID { get; set; }
        public int FoodCount { get; set; }
        public double PriceOfCart { get; set; }
        public CartDetails(string customerID, string foodID, int foodCount, double priceOfCart)
        {
            CartID = $"CRID{++s_cartID}";
            CustomerID = customerID;
            FoodID = foodID;
            FoodCount = foodCount;
            PriceOfCart = priceOfCart;
        }
        public CartDetails(){}
    }
}