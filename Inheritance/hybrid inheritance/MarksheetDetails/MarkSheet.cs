using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarksheetDetails
{
    public class MarkSheet:TheoryExamMarks,ICalculate
    {
        /*Class to create application for Hybrid Inheritance using Student Marksheet generation application create two objects 
        for marksheet details object, Calculate total marks of each sem and calculate % mark and show U.G marksheet for it:

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
        private int s_marksheetNumber=0;
        public int MarksheetNumber{get;set;}
        public DateTime DateOfIssue{get;set;}
        public double Total{get;set;}
        public double Percentage{get;set;}
        public double ProjectMark{get;set;}
        public MarkSheet(DateTime dateOfIssue,string name,string fatherName,string phone,DateTime dob,string gender,double[] sem1,double[] sem2,double[] sem3,double[] sem4):base(name,fatherName,phone,dob,gender,sem1,sem2,sem3,sem4)
        {
            s_marksheetNumber++;
            MarksheetNumber=s_marksheetNumber;
            DateOfIssue=dateOfIssue;
        }
        public void CalculateUG()
        {
            Total = (Sem1.Sum()+Sem2.Sum()+Sem3.Sum()+Sem4.Sum())/4;
            Percentage = Total/6;
        }
        public string SHowUGMarkSHeet()
        {
            CalculateUG();
            return $"MarksheetNumber:{MarksheetNumber}, DateOfIssue:{DateOfIssue}, Total:{Total}, Percentage:{Percentage}, RegistationNumber:{RegistationNumber}, Name:{Name}, FatherName:{FatherName}, Phone:{Phone}, DOB:{DOB}, Gender:{Gender}";
        }
    }
}