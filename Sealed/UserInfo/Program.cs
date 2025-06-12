using System;
namespace UserInfo;

class Program
{
    public static void Main()
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
        EmployeeInfo employee=new EmployeeInfo(1,new DateTime(1111,11,1),"ram","raman","2345678","dr5678u","male","selvi",2,"vpm");

        System.Console.WriteLine(employee.DisplayInfo());

    }
}