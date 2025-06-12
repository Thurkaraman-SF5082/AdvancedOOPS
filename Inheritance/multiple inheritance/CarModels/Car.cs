using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarModels
{
    public class Car
    {
        /*Create an application to handle Car Models. Create 2 objects each for ShiftDezire and Eco calculate milage, Show details of cars.



        Class Car

        Property: FuelType, NumberOfSeats, Color, TankCapacity, NumberOfKmDriven

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
        public string FuelType { get; set; }
        public int NumberOfSeats { get; set; }
        public string Color { get; set; }
        public double TankCapacity { get; set; }
        public double NumberOfKmDriven { get; set; }
        public Car() { }
        public Car(string fueltype, int numberOfSeats, string color, double tankCapacity, double numberOfKmDriven)
        {
            FuelType=fueltype;
            NumberOfSeats=numberOfSeats;
            Color=color;
            TankCapacity=tankCapacity;
            NumberOfKmDriven=numberOfKmDriven;
        }

        public double CalculateMilage()
        {
            double milage=NumberOfKmDriven/TankCapacity;
            return milage;
        }
    }
}