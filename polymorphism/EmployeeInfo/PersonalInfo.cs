using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    public abstract class PersonalInfo
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
        public string Name{get;set;}
        public string FatherName{get;set;}
        public string MobileNumber{get;set;}
        public string Gender{get;set;}
        public PersonalInfo(){}
        public PersonalInfo(string name,string fatherName,string mobileNumber,string gender)
        {
            Name=name;
            FatherName=fatherName;
            MobileNumber=mobileNumber;
            Gender=gender;
        }
        public abstract string Display();
    }
}