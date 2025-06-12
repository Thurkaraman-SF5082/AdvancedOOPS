using System;
namespace Calculator;

class Program
{
    public static void Main()
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

        AreaCalculator area=new AreaCalculator(7);

        VolumeCalculator volume=new VolumeCalculator(12,6);

        System.Console.WriteLine(area.Display());

        System.Console.WriteLine(volume.Display());

        
    }
}