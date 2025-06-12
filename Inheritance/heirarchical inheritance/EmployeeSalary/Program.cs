using System;
namespace EmployeeSalary;

class Program
{
    public static void Main()
    {
        /*Create a employee Salary calculation method.  Create two temporary and two permanent employees, calculate their salary and show their salary.



        Class SalaryInfo

        Properties: BasicSalary, Month

        Class PermanentEmployee: inherit SalaryInfo

        Properties: EmployeeID, Employee Type, DA=0.2% of basic, HRA= 0.18% of basic, PF – 0.1 % basic, Total Salary

        Method: Calculate TotalSalary – Basic +DA+HRA-PF, ShowSalary

        Class TemporaryEmployee: inherit SalaryInfo

        Properties: EmployeeID, Employee Type, DA=0.15% of basic, HRA= 0.13% of basic, Total Salary

        Method: Calculate TotalSalary – Basic +DA+HRA-PF, ShowSalary*/

        PermanentEmployee permanent=new PermanentEmployee("permanent",50000);
        TemporaryEmployee temporary=new TemporaryEmployee("temp",20000);

        System.Console.WriteLine(permanent.ShowSalary());
        System.Console.WriteLine(temporary.CalculateSalary());
        
    }
}