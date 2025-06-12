using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarModels
{
    public interface IBrand
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
        string BrandName{get;set;}
        string ModelName{get;set;}
        public string ShowDetails();
    }
}