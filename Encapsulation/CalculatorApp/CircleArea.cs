using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathsLib;

namespace CalculatorApp
{
    public class CircleArea:Maths
    {
        /*Namespace CalculatorApp;

        Class CircleArea inherit Maths
        Field: protected radius
        Property : public Radius, internal area
        Method : CalculateCircleArea = PI*radious2

        Class CylinderVolume inherits CircleArea
        Field: private height
        Property :  public Height, internal volume
        Method : CalculateVolume = CalculateCircleArea *height*/
        protected double _radius=7;
        public double Radius{get{return _radius;}set{_radius=value;}}
        internal double Area{get;set;}
        // public CircleArea(double radius)
        // {
        //     Radius=radius;
        // }

        public double CalculateCircleArea()
        {
            Area = PI*Radius*Radius;
            return Area;
        }
    }
}