using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdministration
{
    public class StudentInfo:PersonalInfo
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
        private int s_studentID=0;
        public int StudentID{get;set;}
        public string Degree{get;set;}
        public string Department{get;set;}
        
        public string Semester{get;set;}
        
        public StudentInfo(){}
        public StudentInfo(string degree,string department,string semester,string name,string fatherName,string phone,string mail,DateTime dob,string gender):base(name,fatherName,phone,mail,dob,gender)
        {
            s_studentID++;
            StudentID=s_studentID;
            Degree=degree;
            Department=department;
            Semester=semester;
        }

        public string ShowDetails()
        {
            return $"StudentID:{StudentID},Degree:{Degree}, Department:{Department},  Semester:{Semester}, {ShowPersonalInfo()}";
        }
    }
}