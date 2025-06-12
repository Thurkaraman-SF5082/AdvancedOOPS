using System;
namespace CalculatorClass;

class Program
{
    public static void Main()
    {
        /*Create a class Calculator that will get semester marks of 6 subjects.

        Create four objects named Sem1, Sem 2, Sem 3, Sem 4 using calculate method that will calculate the total mark, percentage of 6 subject.
        Create a operator overloaded method that will calculate the total mark of 4 semesters and display the total marks and percentage. */

        
        Calculator sem1=new Calculator(88,99,55,77,66,44);
        Calculator sem2=new Calculator(99,66,44,77,88,55);
        Calculator sem3=new Calculator(85,65,94,75,69,48);
        Calculator sem4=new Calculator(87,58,94,61,90,53);

        Calculator result = sem1+sem2+sem3+sem4;
        double total= result.Subject1+result.Subject2+result.Subject3+result.Subject4+result.Subject5+result.Subject6;

        System.Console.Write($"Average Total of 600 : sem1 + sem2 + sem3 + sem4 = {total/4}\nPercentage = {total/24}");
    }
}