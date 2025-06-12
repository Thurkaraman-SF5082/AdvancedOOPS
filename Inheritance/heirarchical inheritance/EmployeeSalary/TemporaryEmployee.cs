using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class TemporaryEmployee:SalaryInfo
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
        private int s_employeeID=0;
        public int EmployeeID{get;set;}
        public string EmployeeType{get;set;}
        public double DA{get;set;}
        public double HRA{get;set;}
        
        public double TotalSalary{get;set;}
        public TemporaryEmployee(){}
        public TemporaryEmployee(string employeeType,double basicSalary):base(basicSalary)
        {
            s_employeeID++;
            EmployeeID=s_employeeID;
            EmployeeType=employeeType;
        }

        //Method: Calculate TotalSalary – Basic +DA+HRA-PF, ShowSalaryDA=0.15% of basic, HRA= 0.13% of basic
        public double CalculateSalary()
        {
            DA=0.15*BasicSalary;
            HRA=0.13*BasicSalary;
            TotalSalary=BasicSalary+DA+HRA;
            return TotalSalary;
        }

        public string  ShowSalary()
        {
            return $"TotalSalary:{CalculateSalary()}";
        }
    }
}