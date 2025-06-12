using System;
namespace CarModels;

class Program
{
    public static void Main()
    {
        /*Create an application to handle Car Models. Create 2 objects each for ShiftDezire and Eco calculate milage, Show details of cars.



        Class Car

        Property: FuleType, NumberOfSeats, Color, TankCapacity, NumberOfKmDriven

        Method: CalculateMilage



        Interface  IBrand

        Property: BrandName, ModelName

        Method: Show Details



        Class ShiftDezire inherit Car, IBrand

        Property:   MakingID(Auto), EngineNumber, ChasisNumber

        Method: Show Details



        Class Eco  inherit Car, IBrand

        Property:   MakingID(Auto),, EngineNumber, ChasisNumber

        Method: Show Details*/

        IBrand brand=new ShiftDezire(50,62,"dezire","model","diesel",3,"red",30,1000);
        System.Console.WriteLine(brand.ShowDetails());

        brand=new Eco(50,62,"eco","model","petrol",3,"red",30,500);
        System.Console.WriteLine(brand.ShowDetails());


        
        
    }
}