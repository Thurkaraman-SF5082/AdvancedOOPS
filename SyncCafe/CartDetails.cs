using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncCafe
{
    public class CartDetails
    {
        /*Properties: 
        a.	CartID (Auto Increment – CRID4000)
        b.	CustomerID
        c.	FoodID
        d.	PurchaseCount
        e.	PriceOfCart
        */
        private static int s_cartID = 4000;
        public string CartID { get; set; }
        public string CustomerID { get; set; }
        public string FoodID { get; set; }
        public int PurchaseCount { get; set; }
        public double PriceOfCart { get; set; }
        public CartDetails(string customerID, string foodID, int purchaseCount, double priceOfCart)
        {
            CartID = $"CRID{++s_cartID}";
            CustomerID = customerID;
            FoodID = foodID;
            PurchaseCount = purchaseCount;
            PriceOfCart = priceOfCart;
        }
    }
}