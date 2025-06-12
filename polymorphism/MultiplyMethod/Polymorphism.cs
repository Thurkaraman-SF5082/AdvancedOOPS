using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiplyMethod
{
    public class Polymorphism
    {
        /*Create a set of Multiply method inside a class

        Method with one argument and display the Square value of a given number.
        Method with 2 arguments with same argument type and display result.
        Method with 3 arguments with same argument type and display the result.
        Method with 2 arguments with different argument type and display result.
        Method with 3 arguments with different argument type and display the result.
        Call the above 5 methods and print the results.*/
        public double Multiply(int number)
        {
            return number*number;
        }
        public double Multiply(int number1,int number2)
        {
            return number1*number2;
        }
        public double Multiply(int number1,int number2,int number3)
        {
            return number1*number2*number3;
        }
        public double Multiply(int number1,double number2)
        {
            return number1*number2;
        }
        public double Multiply(int number1,int number2,double number3)
        {
            return number1*number2*number3;
        }
    }
}