using System;
namespace StudentCounselling;

class Program
{
    public static void Main()
    {
        /*Create an application to handle student Counselling information: create 2 objects for PGCouncelling class

        Interface IPersonalInfo:
        Properties: AdharNumber, Name, FatherName, Phone, DOB, Gender

        Interface IHSCInfo: Inherits IPersonalInfo
        Properties: HSCMarksheetNumber, Physics, chemistry, maths, Total, percentage Marks
        Methods: ShowHSCMarksheet, CalculateHSC -> Total, percentage. 

        Interface IUGInfo: Inhertis IPersonalInfo
        Properties: UGMarksheetNumber, Sem1, Sem2, Sem3, Sem4 Marks, Total and Percentage
        Methods: SHowUGMarkSHeet, CalculateUG -> Total, percentage.

        Class PGCouncelling inherits IHSCInfo, IUGInfo
        Properties: ApplicationID, DateOfApplication, FeeStatus.
        Method: UpdateInfo, ShowInfo, PayFees -> 500 Rs.*/
        PGCounselling counselling=new PGCounselling(DateTime.Now,"NIl",3456789,"ram","raman","23456789",new DateTime(1111,11,1),"male",55,88,99,77,11,88,99,77,88);

        System.Console.WriteLine(counselling.ShowHSCMarksheet());
        System.Console.WriteLine(counselling.ShowUGMarksheet());

        System.Console.WriteLine(counselling.ShowInfo());

        System.Console.WriteLine(counselling.PayFees());
        System.Console.WriteLine(counselling.ShowInfo());
    }
}