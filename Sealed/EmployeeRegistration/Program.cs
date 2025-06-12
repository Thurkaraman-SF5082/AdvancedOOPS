using System;
namespace EmployeeRegistration;

class Program
{
    public static void Main()
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
        Hack hack=new Hack(456,"sertytuy");
        EmployeeInfo employeeInfo=new EmployeeInfo("drt678",78);

        hack.ShowKeyInfo();

              
    }
}