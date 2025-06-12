using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CircleCalculator:Calculator
    {
        /*Create an application for calculator manipulation

        Class Calculator:
        Method: Abstract area, volume

        Class CircleCalculator inherit Calculator
        Methods: sealed override void area - 3.14 * r 2

        Class Calculator CylinderCalculator: inherit  Calculator
        Method: override area ,Volume that used circle area for 3.14 * r 2*/
        double r;

        public sealed override double Area()
        {
            return 3.14*r*r;
        }
        public override double Volume()
        {
            return 3.14*r*r;
        }
    }
}