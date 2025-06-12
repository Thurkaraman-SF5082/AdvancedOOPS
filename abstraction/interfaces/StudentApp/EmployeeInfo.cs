using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp
{
    public class EmployeeInfo:IDisplayInfo
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
        private int s_employeeID=0;
        public int EmployeeID{get;set;}
        public string Name{get;set;}
        public string FatherName{get;set;}
        public string Mobile{get;set;}
        public EmployeeInfo(){}
        public EmployeeInfo(string name,string fatherName)
        {
            s_employeeID++;
            EmployeeID=s_employeeID;
            Name=name;
            FatherName=fatherName;
            
        }
        public string DisplayInfo()
        {
            return $"EmployeeID:{EmployeeID}, Name:{Name}, FatherName:{FatherName}";
        }
    }
}