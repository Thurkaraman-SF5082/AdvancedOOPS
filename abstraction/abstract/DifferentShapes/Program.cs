using System;
namespace DifferentShapes;

class Program
{
    public static void Main()
    {
        /*﻿﻿Create application for calculate area and volume of different shapes

 

        Abstract class Shape

        Abstract Properties: Area, Volume

        Non abstract properties: Radius, Height, Width, Page - a

        Abstract methods: CalculateArea, CalculateVolume

        

        Class Cylinders inherit Shape

        Overridden methods: CalculateArea - 2 π r(r+h) , CalculateVolume π r2 h

        

        Class Cubes inherit Shape

        Overridden methods: CalculateArea -  6a2 , CalculateVolume - a3

        

        Create objects for cylinder and cube and calculate area and volume of both.*/
        Shape shape=new Cylinders(2,5,3);
        System.Console.WriteLine(shape.CalculateArea());
        System.Console.WriteLine(shape.CalculateVolume());

        shape=new Cubes(4);
        System.Console.WriteLine(shape.CalculateArea());
        System.Console.WriteLine(shape.CalculateVolume());
    }
}