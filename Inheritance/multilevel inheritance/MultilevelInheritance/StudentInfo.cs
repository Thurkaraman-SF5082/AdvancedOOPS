using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public class StudentInfo:PersonalInfo
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

        private int s_registerNumber=0;
        public int RegisterNumber { get; set; }
        public string Standard { get; set; }
        public string Branch { get; set; }
        public int AcadamicYear { get; set; }
        public StudentInfo(){}
        public StudentInfo(string name,string fatherName,string phone,string mail,DateTime dob,string gender):base(name,fatherName,phone,mail,dob,gender)
        {
            s_registerNumber++;
            RegisterNumber=s_registerNumber;
        }
        public StudentInfo(int registrationNumber,string standard,string branch,int academicYear,string name,string fatherName,string phone,string mail,DateTime dob,string gender):base(name,fatherName,phone,mail,dob,gender)
        {
            RegisterNumber=s_registerNumber;
            Standard=standard;
            Branch=branch;
            AcadamicYear=academicYear;
        }

        public void GetStudentInfo(string standard,string branch,int academicYear)
        {
            Standard=standard;
            Branch=branch;
            AcadamicYear=academicYear;
        }

        public string ShowInfo()
        {
            return $"RegisterNumber:{RegisterNumber}, Standard:{Standard}, Branch:{Branch}, AcadamicYear:{AcadamicYear}, Name:{Name}, FatherName:{FatherName},Phone:{Phone},Mail:{Mail}, dob:{DOB},Gender:{Gender}";
        }
    }
}