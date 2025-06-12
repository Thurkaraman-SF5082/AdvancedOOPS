using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public class StudentInfo:PersonalInfo
    {
        /*
        Class PersonalInfo:

Properties: Name, FatherName, Phone ,Mail, DOB, Gender

Constructor to assign values



Class StudentInfo: inherits PersonalInfo

Propeties: RegisterNumber, Standard, Branch, AcadamicYear

Method:  ShowStudentInfo
        */
        private int s_registerNumber=0;
        public int RegisterNumber { get; set; }
        public string Standard { get; set; }
        public string Branch { get; set; }
        public int AcademicYear { get; set; }
        public StudentInfo(){}
        public StudentInfo(string name,string fatherName,string phone,string mail,DateTime dob,string gender,string standard,string branch,int academicYear):base(name,fatherName,phone,mail,dob,gender)
        {
            s_registerNumber++;
            RegisterNumber=s_registerNumber;
            Standard=standard;
            Branch=branch;
            AcademicYear=academicYear;
        }

        public string ShowStudentInfo()
        {
            return $"RegisterNumber:{RegisterNumber}, Name:{Name}, FatherName:{FatherName}, Phone:{Phone} ,Mail:{Mail}, DOB:{DOB}, Gender:{Gender}, Standard:{Standard}, Branch:{Branch}, AcadamicYear:{AcademicYear}";
        }
    }
}