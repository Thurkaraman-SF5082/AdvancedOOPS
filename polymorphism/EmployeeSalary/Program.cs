using System;
namespace EmployeeSalary;

class Program
{
    public static void Main()
    {
        /*Create application for a employee salary calculation,
        Class PersonDetails
        Property: Name, FatherName,Gender,Qualification

        
        Class FreeLancer inherits PersonDetails
        Property: Role, SalaryAmount, NoOfWorkingDays
        Method : Virtual CalculateSalary method that calculate salary by NoOfWorkingDays*500 and virtual display method that display employees details

        Class Syncfusion inherits FreeLancer
        Field : EmployeeID
        Property: EmployeeID, Worklocation
        Method: Overridden CalculateSalary method that calculate salary by NoOfWorkingDays*500 and Overridden display method that display 
        employees details*/

        FreeLancer free=new FreeLancer("web",20,"ram","raman","male","b.tech");

        Syncfusion syncfusion=new Syncfusion("sde","chennai",22,"sam","saran","female","be");

        System.Console.WriteLine(free.Display());
        System.Console.WriteLine(syncfusion.Display());
        
    }
}