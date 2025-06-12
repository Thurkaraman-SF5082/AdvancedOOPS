using System;
namespace StudentDetails1;

class Program
{
    public static void Main()
    {
        /*Create an application for student info

        Create a class file named StudentProps
        Inside that create a partial class Studentinfo and provide properties -  StudentID,Name,Gender,DOB, Mobile, Physics, Chemistry, Maths Marks
        Create another class file named StudentConstructors
        Inside that create a partial class Studentinfo and provide Constructor
        Create another class file named StudentMethods
        Inside that create a partial class Studentinfo and provide Methods -> Calculate total and percentage, and Display*/
        
        StudentInfo info=new StudentInfo("ram","male",new DateTime(1111,11,1),"3456789",88,66,99);

        System.Console.WriteLine(info.Display());
    }
}