using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserInfo
{
    public class PersonalInfo
    {
        /*Create an application that get user info

        Class PersonalInfo:
        Properties: Name, FatherName, mobile, Mail, Gender
        Method: virtual Update, DisplayInfo, 

        Class FamilyInfo: Inherit PersonalInfo
        Properties: FatherName, MotherName, NoOfSiblings, Mail
        Method: Sealed override Update, DisplayInfo

        Class EmployeeInfo: Inherit FamilyInfo
        Properties: EmployeeID, DateOfJoining
        Method: override Update and override DisplayInfo

        Create object for the Employee info and find the issue.*/
        
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
        public virtual void Update(string name,string fatherName,string mobile,string mail,string gender)
        {
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
            Mail=mail;
            Gender=gender;
        }
        public virtual string DisplayInfo()
        {
            return $"Name:{Name}, FatherName:{FatherName}, mobile:{Mobile}, Mail:{Mail}, Gender:{Gender}, Gender:{Gender}";
        }
    }
}