using System;
namespace MultiplyMethod;

class Program
{
    public static void Main()
    {
        /*Create a set of Multiply method inside a class

        Method with one argument and display the Square value of a given number.
        Method with 2 arguments with same argument type and display result.
        Method with 3 arguments with same argument type and display the result.
        Method with 2 arguments with different argument type and display result.
        Method with 3 arguments with different argument type and display the result.
        Call the above 5 methods and print the results.*/
        Polymorphism polymorphism=new Polymorphism();

        System.Console.WriteLine(polymorphism.Multiply(5));
        System.Console.WriteLine(polymorphism.Multiply(5,10));
        System.Console.WriteLine(polymorphism.Multiply(5,77,6));
        System.Console.WriteLine(polymorphism.Multiply(5,20.22));
        System.Console.WriteLine(polymorphism.Multiply(5,50,0.589));
    }
}