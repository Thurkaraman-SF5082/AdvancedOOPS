using System;
namespace EmployeeInfo;

class Program
{
    public static void Main()
    {
        /*Create the following Project that will display employee’s info & calculated employee salary

        Class PersonalInfo:
        Properties: Name, FatherName,MobileNumber,Gender
        Methods: Abstract  -> Display.

        Class EmployeeInfo inherits PersonalInfo
        Field, Properties: EmployeeID,
        Method: Overriden -> Display. -> Display Employee ID and personal info

        Class SalaryInfo inherits: EmployeeInfo
        Field, Properties: NumberOfDaysWorked
        Method: Overridden -> Display -> Display Employee PersonalInfo and Display salary based on number of working days * 500.


        Declare Object PersonalInfo without using new PersonalInfo() – Method declaration only.
        Assign EmployeeInfo new Defined object to personal info, assign values to properties and display employee info.
        Assign SalaryInfo new Defined object to personal info, assign values to properties and display SalaryInfo.*/

        PersonalInfo info=new EmployeeInfo1("ram","raman","3456789","male");
        System.Console.WriteLine(info.Display());

        info=new SalaryInfo("sam","saran","234567","female",25);
        System.Console.WriteLine(info.Display());
        
    }
}