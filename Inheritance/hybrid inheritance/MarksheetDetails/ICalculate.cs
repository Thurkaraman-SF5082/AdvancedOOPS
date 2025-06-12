using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarksheetDetails
{
    public interface ICalculate
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
        double ProjectMark{get;set;}
        void CalculateUG();
    }
}