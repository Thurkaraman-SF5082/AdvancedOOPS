using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegistration
{
    public sealed class EmployeeInfo
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
        private int s_userID=0;
        public int UserID{get;set;}
        public string Password{get;set;}
        public int KeyInfo{get;set;}
        public EmployeeInfo(string password,int keyInfo)
        {
            s_userID++;
            UserID=s_userID;
            Password=password;
            KeyInfo=keyInfo;
        }
        public void UpdateInfo(string password,int keyInfo)
        {
            Password=password;
            KeyInfo=keyInfo;
        }
        public string DisplayInfo()
        {
            return $"UserID:{UserID}, Password:{Password}, KeyInfo:{KeyInfo}";
        }
    }
}