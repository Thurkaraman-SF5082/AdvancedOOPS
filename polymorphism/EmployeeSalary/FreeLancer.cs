using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class FreeLancer:PersonalDetails
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
        public string Role{get;set;}
        public double SalaryAmount{get;set;}
        public int NoOfWorkingDays{get;set;}
        public FreeLancer(string role,int noOfWorkingDays,string name,string fatherName,string gender,string qualification):base(name,fatherName,gender,qualification)
        {
            Role=role;
            NoOfWorkingDays=noOfWorkingDays;
        }
        public virtual double CalculateSalary()
        {
            SalaryAmount=NoOfWorkingDays*500;
            return SalaryAmount;
        }
        public virtual string Display()
        {
            return $"Role:{Role}, SalaryAmount:{CalculateSalary()}, NoOfWorkingDays:{NoOfWorkingDays}, Name:{Name}, FatherName:{FatherName}, Gender:{Gender}, Qualification:{Qualification}";
        }

    }
}