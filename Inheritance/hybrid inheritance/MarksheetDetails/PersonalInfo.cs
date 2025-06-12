using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarksheetDetails
{
    public class PersonalInfo
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
        private int s_registrationNumber=0;
        public int RegistationNumber{get;set;}
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public PersonalInfo(){}
        public PersonalInfo(string name,string fatherName,string phone,DateTime dob,string gender)
        {
            s_registrationNumber++;
            RegistationNumber=s_registrationNumber;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            DOB=dob;
            Gender=gender;
        }
        public string ShowPersonalInfo()
        {
            return $"RegistrationNumber:{RegistationNumber},Name:{Name}, FatherName:{FatherName}, DOB:{DOB}, Phone:{Phone}, Gender:{Gender}";
        }
    }
}