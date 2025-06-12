using System;
namespace SquareMethod;

class Program
{
    public static void Main()
    {
        /*Create a set of methods that will calculate the square of given type number
        Compute square of given integer
        Compute square of given float
        Compute square of given double
        Compute square of given long
        Call the above 5 methods and print the results.*/

        PolySquare square=new PolySquare();

        System.Console.WriteLine(square.Square(5));
        System.Console.WriteLine(square.Square(5.55));
        System.Console.WriteLine(square.Square(5.6595945));
        System.Console.WriteLine(square.Square(53456788));
    }
}