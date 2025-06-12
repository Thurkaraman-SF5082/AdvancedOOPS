using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquareMethod
{
    public class PolySquare
    {
        /*Create a set of methods that will calculate the square of given type number
        Compute square of given integer
        Compute square of given float
        Compute square of given double
        Compute square of given long
        Call the above 5 methods and print the results.*/
        public int Square(int number)
        {
            return number*number;
        }
        public float Square(float number)
        {
            return number*number;
        }
        public double Square(double number)
        {
            return number*number;
        }
        public long Square(long number)
        {
            return number*number;
        }
    }
}