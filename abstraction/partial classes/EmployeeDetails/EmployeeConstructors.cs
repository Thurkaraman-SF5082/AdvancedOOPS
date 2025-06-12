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
        public EmployeeInfo(){}
        public EmployeeInfo(string name,string gender,DateTime dob,string mobile)
        {
            s_employeeID++;
            EmployeeID=s_employeeID;
            Name=name;
            Gender=gender;
            DOB=dob;
            Mobile=mobile;
        }
    }
}