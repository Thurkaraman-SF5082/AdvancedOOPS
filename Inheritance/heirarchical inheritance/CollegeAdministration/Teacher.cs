using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdministration
{
    public class Teacher:PersonalInfo
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
        private int s_teacherID=0;
        public int TeacherID{get;set;}
        public string Department{get;set;}
        public string Subject{get;set;}
        public string Qualification{get;set;}
        public int Experience{get;set;}
        public DateTime JoiningDate{get;set;}
        public Teacher(){}
        public Teacher(string department,string subject,string qualification,int experience,DateTime joiningDate,string name,string fatherName,string phone,string mail,DateTime dob,string gender):base(name,fatherName,phone,mail,dob,gender)
        {
            s_teacherID++;
            TeacherID=s_teacherID;
            Department=department;
            Subject=subject;
            Qualification=qualification;
            Experience=experience;
            JoiningDate=joiningDate;
        }

        public string ShowDetails()
        {
            return $"TeacherID:{TeacherID}, {ShowPersonalInfo()}, Department:{Department}, Subject teaching:{Subject}, Qualification:{Qualification}, YearOfExperience:{Experience}, DateOfJoining:{JoiningDate}";
        }
    }
}