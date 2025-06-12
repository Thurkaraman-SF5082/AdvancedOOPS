using System;
namespace CarInfo;

class Program
{
    public static void Main()
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
        Car car=new MaruthiSwift("petrol",8,1000000,"suv");
        System.Console.WriteLine(car.DisplayDetails());

        car=new SuzukiCiaz("diesel",5,500000,"sedan");
        System.Console.WriteLine(car.DisplayDetails());

        
    }
}