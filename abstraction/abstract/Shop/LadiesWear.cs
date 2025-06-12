using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop
{
    public class LadiesWear:Dress
    {
        /*Create an application that calculate discount in shop

        Class Dress:
        Abstract Properties: dress type->Ladieswear, menswear, childrenswear, dress name, price, total price
        Abstract Methods: getdressinfo, Display Info

        Class Ladieswear:
        Overridden Methods: getdressinfo, Display Info -> calculate 20% discount and display the bil

        Class Menswear:
        Overridden Methods: getdressinfo, Display Info -> calculate 30% discount and display the bill

        Create objects for ladies wear and mens wear, use getdress info to get dress details and displayinfo to display the bill.*/
        public override string DressType{get;set;}
        public override string DressName{get;set;}
        public override double Price{get;set;}
        public override double TotalPrice{get;set;}
        public LadiesWear(){}
        public LadiesWear(string dressType,string dressName,double price)
        {
            DressType=dressType;
            DressName=dressName;
            Price=price;
        }

        public override string GetDressInfo()
        {
            return DressType;
        }
        public override string DisplayInfo()
        {
            return $"dress type:{DressType}, dress name:{DressName}, price:{Price}, total price:{Calculate()}";
        }
        public double Calculate()
        {
            TotalPrice=Price-(0.20*Price);
            return TotalPrice;
        }
    }
}