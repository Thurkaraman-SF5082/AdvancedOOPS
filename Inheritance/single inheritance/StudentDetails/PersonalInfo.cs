using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public class PersonalInfo
    {
        /*
        Class PersonalInfo:

Properties: Name, FatherName, Phone ,Mail, DOB, Gender

Constructor to assign values



Class StudentInfo: inherits PersonalInfo

Propeties: RegisterNumber, Standard, Branch, AcadamicYear

Method:  ShowStudentInfo
        */
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