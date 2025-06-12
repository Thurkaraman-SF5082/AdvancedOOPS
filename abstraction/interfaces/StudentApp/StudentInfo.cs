using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp
{
    public class StudentInfo:IDisplayInfo
    {
        /*Create application for student application

 

        Interface IDisplayInfo

        Methods: Dispay

        

        Class StudentInfo inherit IDisplayInfo

        Properties: StudentID, Name, FatherName, Mobile

        Methods: Display

        

        Class EmployeeInfo inherit IDisplayInfo

        Properties: EmployeeID, Name, FatherName

        Methods: Display

        

        Create one object each for student and employee info and display their properties.*/
        private int s_studentID=0;
        public int StudentID{get;set;}
        public string Name{get;set;}
        public string FatherName{get;set;}
        public string Mobile{get;set;}
        public StudentInfo(){}
        public StudentInfo(string name,string fatherName,string mobile)
        {
            s_studentID++;
            StudentID=s_studentID;
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
        }
        public string DisplayInfo()
        {
            return $"StudentID:{StudentID}, Name:{Name}, FatherName:{FatherName}, Mobile:{Mobile}";
        }
    }
}