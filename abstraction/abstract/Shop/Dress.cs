using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop
{
    public abstract class Dress
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
        public abstract string DressType{get;set;}
        public abstract string DressName{get;set;}
        public abstract double Price{get;set;}
        public abstract double TotalPrice{get;set;}

        public abstract string GetDressInfo();
        public abstract string DisplayInfo();
    }
}