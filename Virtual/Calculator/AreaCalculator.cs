using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    public class AreaCalculator
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
        public double Radius{get;set;}
        public AreaCalculator(double radius)
        {
            Radius=radius;
        }
        public virtual double Calculate()
        {
            return 3.14*Radius*Radius;
        }
        public virtual string Display()
        {
            return $"Area = {Calculate()}";
        } 
    }
}