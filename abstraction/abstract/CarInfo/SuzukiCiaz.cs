using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo
{
    public class SuzukiCiaz:Car
    {
        /*Create an application for Car Information

        Class Car:

        Field: No. of wheels=4, No.Of.Doors = 4,

        Properties: Engine type -Petrol,diesel,cng, No.Of.Seats, Price, CarType -hatchback,sedan, suv

        Methods : ShowWheels, show doors

        Abstract methods: get engine type, get no. of seats, get price, get car type, Display  car detail

        Class MaruthiSwift : inherit Cars

        override methods: get engine type, get no. of seats, get price, get car type, Display  car detail

        class SuzukiCiaz: inherit Cars

        override methods: get engine type, get no. of seats, get price, get car type, Display  car detail

        Create object for maruthi swift and Suzuki ciaz and call abstract methods to get and display.*/
        public override string EngineType{get;set;}
        public override int NoOfSeats{get;set;}
        public override double Price{get;set;}
        public override string CarType{get;set;}
        
        public SuzukiCiaz(){}
        public SuzukiCiaz(string engineType,int noOfSeats,double price,string carType)
        {
            EngineType=engineType;
            NoOfSeats=noOfSeats;
            Price=price;
            CarType=carType;
        }
        public override string DisplayDetails()
        {
            return $"Engine type:{EngineType}, No.Of.Seats:{NoOfSeats}, Price:{Price}, CarType:{CarType}";
        }
    }
}