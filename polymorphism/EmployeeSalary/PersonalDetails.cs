using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class PersonalDetails
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
        public string Name{get;set;}
        public string FatherName{get;set;}
        public string Gender{get;set;}
        public string Qualification{get;set;}
        public PersonalDetails(string name,string fatherName,string gender,string qualification)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Qualification=qualification;
        }
    }
}