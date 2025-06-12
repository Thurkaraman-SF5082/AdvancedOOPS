using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserInfo
{
    public class FamilyInfo:PersonalInfo
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
        public string FatherName{get;set;}
        public string MotherName{get;set;}
        public int NoOfSiblings{get;set;}
        public string NativePlace{get;set;}
        public FamilyInfo(string name,string fatherName,string mobile,string mail,string gender,string motherName,int noOfSiblings,string nativePlace):base(name,fatherName,mobile,mail,gender)
        {
            MotherName=motherName;
            NoOfSiblings=noOfSiblings;
            NativePlace=nativePlace;
        }
        public void Update(string motherName,int noOfSiblings,string nativePlace)
        {
            MotherName=motherName;
            NoOfSiblings=noOfSiblings;
            NativePlace=nativePlace;
        }
        public sealed override string DisplayInfo()
        {
            return $"Name:{Name}, FatherName:{FatherName}, mobile:{Mobile}, Mail:{Mail}, Gender:{Gender}, Gender:{Gender}, MotherName:{MotherName}, NoOfSiblings:{NoOfSiblings}, NativePlace:{NativePlace}";
        }
    }
}