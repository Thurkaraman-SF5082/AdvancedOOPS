using System;
namespace Shop;

class Program
{
    public static void Main()
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

        Dress dress=new LadiesWear("LadiesWear","kurti",500.58);
        System.Console.WriteLine(dress.GetDressInfo());
        System.Console.WriteLine(dress.DisplayInfo());

        dress=new MensWear("Menswear","shirt",850.90);
        System.Console.WriteLine(dress.GetDressInfo());
        System.Console.WriteLine(dress.DisplayInfo());
       

        
    }
}