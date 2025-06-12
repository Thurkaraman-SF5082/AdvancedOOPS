using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp
{
    public interface IDisplayInfo
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
        string DisplayInfo();
    }
}