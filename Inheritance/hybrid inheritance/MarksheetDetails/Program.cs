using System;
namespace MarksheetDetails;

class Program
{
    public static void Main()
    {
        /*Class to create application for Hybrid Inheritance using Student Marksheet generation application create two objects for marksheet details object, Calculate total marks of each sem and calculate % mark and show U.G marksheet for it:

        Class PersonalInfo:
        Properties: RegistationNumber, Name, FatherName, Phone, DOB, Gender

        Class TheoryExamMarks : Inhertis PersonalInfo
        Properties: Sem1[], Sem2[], Sem3[], Sem4[] Marks – 6 marks in each sem.

        Interface: ICalculate
        Properties: ProjectMark
        Methods: CalculateUG -> Total, Percentage.
        
        Class Marksheet: inherit TheoryExammarks, ICalculate
        Properties: MarksheetNumber, DateOfIssue, Total, Percentage
        Methods : SHowUGMarkSHeet*/

        MarkSheet mark=new MarkSheet(DateTime.Now,"ram","raman","2345678",new DateTime(1111,11,1),"male",[55,88,99,77,66,44],[85,69,48,97,85,75],[88,65,98,74,81,90],[92,80,43,67,82,70]);

        System.Console.WriteLine(mark.SHowUGMarkSHeet());

        
        
    }
}