using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathsLib
{
    public class Maths
    {
        /*Namespace MathsLib;

        Class Maths

        Field : protected internal PI =3.14; internal g= 9.8

        Method: CalculateWeight = Mass (user input) * g;*/
        protected internal double PI=3.14;
        internal double g=9.8;
        public double CalculateWeight(double Mass)
        {
            double result= Mass*g;
            return result;
        }
    }
}