using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DifferentShapes
{
    public class Cubes:Shape
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

        public Cubes(){}
        public Cubes(double page)
        {
            Page=page;
        }

        public override double CalculateArea()
        {
            Area = 6*Page*Page;
            return Area;
        }
        public override double CalculateVolume()
        {
            Volume = Page*Page*Page;
            return Volume;
        }
    }
}