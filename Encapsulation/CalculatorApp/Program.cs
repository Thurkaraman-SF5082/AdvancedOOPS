using System;
namespace CalculatorApp;
using MathsLib;

class Program
{
    public static void Main()
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
        CircleArea area=new CircleArea();
        System.Console.WriteLine(area.CalculateCircleArea());

        CylinderVolume volume=new CylinderVolume();
        System.Console.WriteLine(volume.CalculateVolume());
    }
}