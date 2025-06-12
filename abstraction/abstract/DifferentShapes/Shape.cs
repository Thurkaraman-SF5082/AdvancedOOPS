using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DifferentShapes
{
    public abstract class Shape
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
        public abstract double Area{get;set;}
        public abstract double Volume{get;set;}
        public double Radius{get;set;}
        public double Height{get;set;}
        public double Width{get;set;}
        public double Page{get;set;}

        public abstract double CalculateArea();
        
        public abstract double CalculateVolume();
    }
}