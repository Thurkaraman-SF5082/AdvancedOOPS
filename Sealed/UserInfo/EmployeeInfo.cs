using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserInfo
{
    public class EmployeeInfo:FamilyInfo
    {
        /*Create an application that get user info

        Class PersonalInfo:
        Properties: Name, FatherName, Mobile, Mail, Gender
        Method: virtual Update, DisplayInfo, 

        Class FamilyInfo: Inherit PersonalInfo
        Properties: FatherName, MotherName, NoOfSiblings, NativePlace
        Method: Sealed override Update, DisplayInfo

        Class EmployeeInfo: Inherit FamilyInfo
        Properties: EmployeeID, DateOfJoining
        Method: override Update and override DisplayInfo

        Create object for the Employee info and find the issue.*/
        public int EmployeeID{get;set;}
        public DateTime JoiningDate{get; set;}
        public EmployeeInfo(int employeeID,DateTime joiningDate,string name,string fatherName,string mobile,string mail,string gender,string motherName,int noOfSiblings,string nativePlace):base(name,fatherName,mobile,mail,gender,motherName,noOfSiblings,nativePlace)
        {
            EmployeeID=employeeID;
            JoiningDate=joiningDate;
        }
        public override void Update(int EmployeeID,DateTime JoiningDate)
        {
            EmployeeID=employeeID;
            JoiningDate=joiningDate;
        }
        public override string DisplayInfo()
        {
            return $"EmployeeID:{EmployeeID}, JoiningDate:{JoiningDate}, Name:{Name}, FatherName:{FatherName}, mobile:{Mobile}, Mail:{Mail}, Gender:{Gender}, Gender:{Gender}, MotherName:{MotherName}, NoOfSiblings:{NoOfSiblings}, NativePlace:{NativePlace}";
        }
    }
}