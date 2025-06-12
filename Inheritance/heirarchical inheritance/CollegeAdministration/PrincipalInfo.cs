using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdministration
{
    public class PrincipalInfo:PersonalInfo
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
        private int s_principalID=0;
        public int PrincipalID{get;set;}
        public string Qualification{get;set;}
        public int Experience{get;set;}
        
        public DateTime JoiningDate{get;set;}
        
        public PrincipalInfo(){}
        public PrincipalInfo(string qualification,int experience,DateTime joiningDate,string name,string fatherName,string phone,string mail,DateTime dob,string gender):base(name,fatherName,phone,mail,dob,gender)
        {
            s_principalID++;
            PrincipalID=s_principalID;
            Qualification=qualification;
            Experience=experience;
            JoiningDate=joiningDate;
        }

        public string ShowDetails()
        {
            return $"PrincipalID:{PrincipalID},Qualification:{Qualification}, Experience:{Experience},  JoiningDate:{JoiningDate}, {ShowPersonalInfo()}";
        }
    }
}