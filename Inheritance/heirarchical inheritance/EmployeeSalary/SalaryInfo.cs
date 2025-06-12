using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class SalaryInfo
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
        public double BasicSalary{get;set;}
        public int Month{get;set;}
        public SalaryInfo(){}
        public SalaryInfo(double basicSalary)
        {
            BasicSalary=basicSalary;
        }
    }
}