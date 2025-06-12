using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DifferentShapes
{
    public class Cylinders : Shape
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
        public override double Area{get;set;}
        public override double Volume{get;set;}

        public Cylinders(){}
        public Cylinders(double radius,double height,double width)
        {
            Radius=radius;
            Height=height;
            Width=width;
        }

        public override double CalculateArea()
        {
            Area = 2 * 3.14 * Radius*(Radius + Height);
            return Area;
        }
        public override double CalculateVolume()
        {
            Volume = 3.14*Radius*Radius*Height;
            return Volume;
        }
    }
}