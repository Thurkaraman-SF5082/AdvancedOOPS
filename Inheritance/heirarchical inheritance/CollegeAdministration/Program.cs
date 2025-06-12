using System;
namespace CollegeAdministration;

class Program
{
    public static void Main()
    {
        /*Create an application for a College Administration, create two objects for teacher, student and principal and show their info.



        Class PersonalInfo:

        Properties: Name, FatherName, DOB, Phone, Gender, Mail



        Class Teacher Inherit PersonalInfo

        Properties: TeacherID, Department, Subject teaching, Qualification, YearOfExperience, DateOfJoining

        Methods:  ShowDetails



        Class StudentInfo inherit PersonalInfo

        Properties: StudentID, Degree, Department, semester

        Methods: ShowDetails



        Class PrincipalInfo inherit PersonalInfo

        Properties: PrincipalID, Qualification, YearOfExperience, DateOfJoining

        Methods: ShowDetails*/


        Teacher teacher=new Teacher("sciene","biology","me",4,new DateTime(2022,11,11),"ram","ramadass","3456789","vft67uhg",new DateTime(1111,11,11),"male");
        
        PrincipalInfo principal=new PrincipalInfo("phd",5,new DateTime(1111,11,11),"ragu","ramadass","3456789","vft67uhg",new DateTime(1111,11,11),"male");

        StudentInfo student=new StudentInfo("be","it","v","ravi","ramadass","3456789","vft67uhg",new DateTime(1111,11,11),"male");

        System.Console.WriteLine(teacher.ShowDetails());
        System.Console.WriteLine(student.ShowDetails());
        System.Console.WriteLine(principal.ShowDetails());
    }
}