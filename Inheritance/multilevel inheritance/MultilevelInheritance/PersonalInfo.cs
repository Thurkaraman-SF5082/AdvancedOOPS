using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public class PersonalInfo
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
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public PersonalInfo(){}
        public PersonalInfo(string name,string fatherName,string phone,string mail,DateTime dob,string gender)
        {
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            DOB=dob;
            Gender=gender;
        }
    }
}