using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class Syncfusion:FreeLancer
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
        private int s_employeeID=0;
        public int EmployeeID{get;set;}
        public string WorkLocation{get;set;}
        public Syncfusion(string role,string workLocation,int noOfWorkingDays,string name,string fatherName,string gender,string qualification):base(role,noOfWorkingDays,name,fatherName,gender,qualification)
        {
            s_employeeID++;
            EmployeeID=s_employeeID;
            WorkLocation=workLocation;
        }
        public override double CalculateSalary()
        {
            SalaryAmount=NoOfWorkingDays*500;
            return SalaryAmount;
        }
        public override string Display()
        {
            return $"EmployeeID:{EmployeeID}, Role:{Role}, WorkLocation:{WorkLocation}, SalaryAmount:{CalculateSalary()}, NoOfWorkingDays:{NoOfWorkingDays}, Name:{Name}, FatherName:{FatherName}, Gender:{Gender}, Qualification:{Qualification}";
        }
    }
}