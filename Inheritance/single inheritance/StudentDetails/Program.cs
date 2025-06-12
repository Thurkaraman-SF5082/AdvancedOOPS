using System;
using System.Net.Http.Headers;
using StudentDetails;
namespace studentDetails;

class Program
{
    public static void Main()
    {
        PersonalInfo personal=new PersonalInfo("ram","raman","345678","rtwertwer",new DateTime(2002,05,26),"male");

        StudentInfo student=new StudentInfo("ravi","ettaper","34567890","wertyui4567",new DateTime(2000,10,10),"male","X","biology",2025);

        System.Console.WriteLine(student.ShowStudentInfo());
        
    }
}
