using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegistration
{
    public class PersonalInfo
    {
        /*Create an application for a employee registration application.

        Class  PersonalInfo:
        Properties: Name, FatherName, Mobile, Mail, Gender
        Method: UpdateInfo

        Sealed Class EmployeeInfo:
        Properties: UserID, Password, KeyInfo = 100
        Methods: UpdateInfo, DisplayInfo

        Class Hack Inherit EmployeeInfo
        Properties: StoreUserID, StorePassword
        Method: ShowKeyInfo, GetUserInfo, ShowUserInfo

        Create object for employeeInfo and assign values to properties display value.
        Try to Create an object for Hack class. To Show the Key info*/
        public string Name{get;set;}
        public string FatherName{get;set;}
        public string Mobile{get;set;}
        public string Mail{get;set;}
        public string Gender{get;set;}

        public PersonalInfo(string name,string fatherName,string mobile,string mail,string gender)
        {
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
            Mail=mail;
            Gender=gender;
        }

        public void UpdateInfo(string name,string fatherName,string mobile,string mail,string gender)
        {
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
            Mail=mail;
            Gender=gender;
        }
    }
}