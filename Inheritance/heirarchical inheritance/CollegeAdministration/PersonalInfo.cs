using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdministration
{
    public class PersonalInfo
    {
        /*Create an application for a College Administration, create two objects for teacher, student and principal and show their info.



        Class PersonalInfo:

        Properties: Name, FatherName, DOB, Phone, Gender, Mail



        Class Teacher Inherit PersonalInfo

        Properties: TeacherID, Department, Subject teaching, Qualification, YearOfExperience, DateOfJoining

        Methods:  ShowDetails



        Class StudentInfo inherit PersonalInfo

        Properties: StudentID, Degree, Department, semester

        Methods: ShowDetails



        Class PrincipalInfo inherit PersonalInfo

        Properties: PrincipalID, Qualification, YearOfExperience, DateOfJoining

        Methods: ShowDetails*/

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
        public string ShowPersonalInfo()
        {
            return $"Name:{Name}, FatherName:{FatherName}, DOB:{DOB}, Phone:{Phone}, Gender:{Gender}, Mail:{Mail}";
        }
    }
}