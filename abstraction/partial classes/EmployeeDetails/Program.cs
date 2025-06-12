using System;
namespace EmployeeDetails;

class Program
{
    public static void Main()
    {
        /*Create an application for employee info

        Create a class file named EmployeeProps
        Inside that create a partial class EmployeeInfo and provide properties -  EmployeeID,Name,Gender,DOB, Mobile
        Create another class file named EmployeeConstructors
        Inside that create a partial class EmployeeInfo and provide Constructor
        Create another class file named EmployeeMethods
        Inside that create a partial class EmployeeInfo and provide Methods -> Update, Display


        Create one employee object for employee info and use update and display info methods*/
        
        EmployeeInfo info=new EmployeeInfo("ram","male",new DateTime(1111,11,1),"3456789");

        System.Console.WriteLine(info.Display());

        info.Update("ragu","male",new DateTime(2222,2,1),"8888888");
        System.Console.WriteLine(info.Display());
    }
}