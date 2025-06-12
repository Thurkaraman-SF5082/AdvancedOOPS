using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickFoodz
{
    public class PurchasedItems
    {
        /*Properties: 
        a.	ItemID (Auto Increment – ITID5000)
        b.	CartID 
        c.	BookingID
        d.	FoodID
        e.	PurchaseCount
        f.	PriceOfPurchase
        */
        private static int s_itemID = 5000;
        public string ItemID { get; set; }
        public string CartID { get; set; }
        public string BookingID { get; set; }
        public string FoodID { get; set; }
        public int PurchaseCount { get; set; }
        public double PriceOfPurchase { get; set; }
        public PurchasedItems(string cartID, string bookingID, string foodID, int purchaseCount, double priceOfPurchase)
        {
            ItemID = $"ITID{++s_itemID}";
            CartID = cartID;
            BookingID = bookingID;
            FoodID = foodID;
            PurchaseCount = purchaseCount;
            PriceOfPurchase = priceOfPurchase;
        }
        public PurchasedItems(){}
    }
}