using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public partial class EmployeeInfo
    {
        /*Create an application for employee info

        Create a class file named EmployeeProps
        Inside that create a partial class EmployeeInfo and provide properties -  EmployeeID,Name,Gender,DOB, Mobile
        Create another class file named EmployeeConstructors
        Inside that create a partial class EmployeeInfo and provide Constructor
        Create another class file named EmployeeMethods
        Inside that create a partial class EmployeeInfo and provide Methods -> Update, Display


        Create one employee object for employee info and use update and display info methods*/

        private int s_employeeID=0;
        public int EmployeeID{get;set;}
        public string Name{get;set;}
        public string Gender{get;set;}
        public DateTime DOB{get;set;}
        public string Mobile{get;set;}
        
    }
}