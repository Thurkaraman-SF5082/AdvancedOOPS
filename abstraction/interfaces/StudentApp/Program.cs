using System;
namespace StudentApp;

class Program
{
    public static void Main()
    {
        /*Create application for student application

 

        Interface IDisplayInfo

        Methods: Dispay

        

        Class StudentInfo inherit IDisplayInfo

        Properties: StudentID, Name, FatherName, Mobile

        Methods: Display

        

        Class EmployeeInfo inherit IDisplayInfo

        Properties: EmployeeID, Name, FatherName

        Methods: Display

        

        Create one object each for student and employee info and display their properties.*/

       IDisplayInfo info=new StudentInfo("ram","raman","345678");
       System.Console.WriteLine(info.DisplayInfo());

       info=new EmployeeInfo("ram","raman");
       System.Console.WriteLine(info.DisplayInfo());
        
    }
}