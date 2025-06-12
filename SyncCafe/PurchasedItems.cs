using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncCafe
{
    public class PurchasedItems
    {
        /*Properties: 
        a.	PurchaseID (Auto Increment – PRID5000)
        b.	CartID 
        c.	BookingID
        d.	FoodID
        e.	PurchaseCount
        f.	PriceOfPurchase
        */
        private static int s_purchaseID = 5000;
        public string PurchaseID { get; set; }
        public string CartID { get; set; }
        public string BookingID { get; set; }
        public string FoodID { get; set; }
        public int PurchaseCount { get; set; }
        public double PriceOfPurchase { get; set; }
        public PurchasedItems(string cartID, string bookingID, string foodID, int purchaseCount, double priceOfPurchase)
        {
            PurchaseID = $"PRID{++s_purchaseID}";
            CartID = cartID;
            BookingID = bookingID;
            FoodID = foodID;
            PurchaseCount = purchaseCount;
            PriceOfPurchase = priceOfPurchase;
        }
    }
}