using System;
namespace MultilevelInheritance;

class Program
{
    public static void Main()
    {
        /*
        Program for getting and showing student details: based on menu Create 2 student details Calculate Total, percentage, show marksheet and need to show if he wants.

        Class PersonalInfo:

        Properties: Name, FatherName,Phone,Mail, dob,Gender

        Constructor to assign values

        Class StudentInfo: inherits PersonalInfo

        Propeties: RegisterNumber, Standard, Branch, AcadamicYear

        Method: GetStudentInfo, ShowInfo

        Class HSCDetails: Inherits StudentInfo

        Properties: HSCMarksheetNumber, Physics, Chemistry, Maths, Total, Percentage marks

        Methods: GetMarks, Calculate – Total and percentage, Show Marksheet.*/

        PersonalInfo personal1=new PersonalInfo("ram","raman","234567678","sawe4567uh",new DateTime(2002,05,26),"male");

        StudentInfo student1=new StudentInfo("ravi","etta","3456789","frt67898i",new DateTime(1999,01,11),"male");

        HSCDetails hSC =new HSCDetails(111,"x","science",2025,"ravi","etta","3456789","frt67898i",new DateTime(1999,01,11),"male");

        student1.GetStudentInfo("x","science",2025);

        hSC.GetMarks(88,90,69);
        hSC.Calculate();

        System.Console.WriteLine(student1.ShowInfo());
        System.Console.WriteLine(hSC.Total);
        System.Console.WriteLine(hSC.Percentage);
        System.Console.WriteLine(hSC.ShowMarksheet());
    }
}