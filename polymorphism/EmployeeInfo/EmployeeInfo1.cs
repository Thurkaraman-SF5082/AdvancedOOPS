using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    public class EmployeeInfo1:PersonalInfo
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
        private int s_employeeID=0;
        public int EmployeeID{get;set;}
        public EmployeeInfo1(string name,string fatherName,string mobileNumber,string gender):base(name,fatherName,mobileNumber,gender)
        {
            s_employeeID++;
            EmployeeID=s_employeeID;
        }
        public override string Display()
        {
            return $"EmployeeID:{EmployeeID}, Name:{Name}, FatherName:{FatherName}, MobileNumber:{MobileNumber}, Gender:{Gender}";
        }
    }
}