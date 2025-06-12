using System;
namespace ShapeApp;

class Program
{
    public static void Main()
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

        Rectangle rectangle=new Rectangle(15,20);

        Sphere sphere=new Sphere(8);

        System.Console.WriteLine(rectangle.Display());

        System.Console.WriteLine(sphere.Display());        
    }
}