using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarModels
{
    public class ShiftDezire:Car,IBrand
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
        private int s_makingID=0;
        public int MakingID { get; set; }
        public int EngineNumber { get; set; }
        public int ChasisNumber { get; set; }
        public string  BrandName { get; set; }
        public string ModelName { get; set; }
        public ShiftDezire(){}
        public ShiftDezire(int engineNumber,int chasisNumber,string brandName,string modelName,string fueltype, int numberOfSeats, string color, double tankCapacity, double numberOfKmDriven):base(fueltype,numberOfSeats,color,tankCapacity,numberOfKmDriven)
        {
            s_makingID++;
            MakingID=s_makingID;
            EngineNumber=engineNumber;
            ChasisNumber=chasisNumber;
            BrandName=brandName;
            ModelName=modelName;
        }

        public string ShowDetails()
        {
            return $"MakingID:{MakingID}, EngineNumber:{EngineNumber}, ChasisNumber:{ChasisNumber}, BrandName:{BrandName}, ModelName:{ModelName},FuleType:{FuelType}, NumberOfSeats:{NumberOfSeats}, Color:{Color}, TankCapacity:{TankCapacity}, NumberOfKmDriven:{NumberOfKmDriven}, Milage:{CalculateMilage()}";
        }
    }
}