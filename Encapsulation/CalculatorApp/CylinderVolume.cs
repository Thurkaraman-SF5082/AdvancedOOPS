using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathsLib;

namespace CalculatorApp
{
    public class CylinderVolume:CircleArea
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
        private double _height=15;
        public double Height{get{return _height;}set{_height=value;}}
        internal double Volume{get;set;}
        // public CylinderVolume(double height,double radius):base(radius)
        // {
        //     Height=height;
        // }
        public double CalculateVolume()
        {
            Volume=CalculateCircleArea()*Height;
            return Volume;
        }
    }
}