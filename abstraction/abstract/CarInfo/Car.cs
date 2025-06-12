using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo
{
    public abstract class Car
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
        private int _noOfWheels=4;
        private int _noOfDoors=4;
        public abstract string EngineType{get;set;}
        public abstract int NoOfSeats{get;set;}
        public abstract double Price{get;set;}
        public abstract string CarType{get;set;}
        public int ShowWheels()
        {
            return _noOfWheels;
        }
        public int ShowDoors()
        {
            return _noOfDoors;
        }
        public abstract string DisplayDetails();
    }
}