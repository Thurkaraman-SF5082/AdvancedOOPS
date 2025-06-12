using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeApp
{
    public class Sphere:Dimention
    {
        /*Create an application that calculate area of different shapes

        Class Dimention
        Property: value1, value 2, Area
        Methods: virtual calculate  -> value1* value2, displayarea

        Class Rectangle inherit Dimension
        Property: Length, height
        Methods: overriden calculate -> use base class calculate method – Length* Height , displayarea

        Class Sphere inherit Dimension
        Property : Radius
        Method: overrided calculate -> 4*3.14*Radius* Radius, displayarea. 
        Create each one object for rectangle, sphere class. Calculate area of two shapes and display the area information.*/
        public int Radius{get;set;}

        public Sphere(int radius):base(radius,radius)
        {

        }
        public override double Calculate()
        {
            return 4*3.14*Value1*Value1;
        }
        public override string Display()
        {
            return $"Area = {Calculate()}";
        }
    }
}