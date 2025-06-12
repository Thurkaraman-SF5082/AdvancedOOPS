using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegistration
{
    public class Hack:EmployeeInfo
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
        public int StoreUserID{get;set;}
        public string StorePassword{get;set;}
        public Hack(int storeUserID,string storePassword)
        {
            StoreUserID=storeUserID;
            StorePassword=storePassword;
        }
        public int ShowKeyInfo()
        {
            return 0;
        }
        public void GetUserInfo()
        {
            //
        }
        public string ShowUserInfo()
        {
            return $"";
        }
    }
}