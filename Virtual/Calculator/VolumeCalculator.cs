using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    public class VolumeCalculator:AreaCalculator
    {
        /*Create an application that calculate area and volume

        Class AreaCalculator
        Property: Radius
        Method: virtual Calculate – 3.14 *r*r, virtual display

        Class VolumeCalculator inherit AreaCalculator
        Property: height
        Method: override Calculate - 3.14 *r*r*h,  override display

        Create an object for volume calculator based on provided values display the output
        Create an object for area calculator based on provided values display the output*/
        public double Height{get;set;}
        public VolumeCalculator(double height,double radius):base(radius)
        {
            Height=height;
        }
        public override double Calculate()
        {
            return 3.14*Radius*Radius*Height;
        }
        public override string Display()
        {
            return $"Area = {Calculate()}";
        } 
    }
}