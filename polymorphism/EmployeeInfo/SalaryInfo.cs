using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    public class SalaryInfo:EmployeeInfo1
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
        private int _numberOfDaysWorked;
        public int NumberOfDaysWorked{get{return _numberOfDaysWorked;}set{_numberOfDaysWorked=value;}}
        public SalaryInfo(string name,string fatherName,string mobileNumber,string gender,int numberOfDaysWorked):base(name,fatherName,mobileNumber,gender)
        {
            NumberOfDaysWorked=numberOfDaysWorked;
        }
        public override string Display()
        {
            return $"{base.Display()}, Salary:{NumberOfDaysWorked*500}";
        }
    }
}