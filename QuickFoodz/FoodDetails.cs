using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickFoodz
{
    public class FoodDetails
    {
        /*Properties: 
        a.	FoodID (Auto Increment – FID2000)
        b.	FoodName
        c.	QuantityAvailable
        d.	PricePerQuantity 
        */
        private static int s_foodID = 2000;
        public string FoodID { get; set; }
        public string FoodName { get; set; }
        public int QuantityAvailable { get; set; }
        public double PricePerQuantity { get; set; }
        public FoodDetails(string foodName, int quantityAvailable, double pricePerQuantity)
        {
            FoodID = $"FID{++s_foodID}";
            FoodName = foodName;
            QuantityAvailable = quantityAvailable;
            PricePerQuantity = pricePerQuantity;
        }
        public FoodDetails(){}
    }
}