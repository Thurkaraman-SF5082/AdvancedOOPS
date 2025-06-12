using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public class HSCDetails:StudentInfo
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

        private int s_hscMarksheetNumber=0;
        public int HSCMarksheetNumber { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public int Percentage { get; set; }
        public HSCDetails(){}
        public HSCDetails(int registrationNumber,string standard,string branch,int academicYear,string name,string fatherName,string phone,string mail,DateTime dob,string gender):base(registrationNumber,standard,branch,academicYear,name,fatherName,phone,mail,dob,gender)
        {
            s_hscMarksheetNumber++;
            HSCMarksheetNumber=s_hscMarksheetNumber;  
            RegisterNumber=registrationNumber;          
        }
        public void GetMarks(int physics,int chemistry,int maths)
        {
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }

        public void Calculate()
        {
            Total= Physics+Chemistry+Maths;
            Percentage=Total/3;
        }
        public string ShowMarksheet()
        {
            return $"HSCMarksheetNumber:{HSCMarksheetNumber},RegisterNumber:{RegisterNumber}, Standard:{Standard}, Branch:{Branch}, AcadamicYear:{AcadamicYear},Name:{Name}, FatherName:{FatherName},Phone:{Phone},Mail:{Mail}, dob:{DOB},Gender:{Gender}, Physics:{Physics}, Chemistry:{Chemistry}, Maths:{Maths}, Total:{Total}, Percentage marks:{Percentage}";
        }

    }
}