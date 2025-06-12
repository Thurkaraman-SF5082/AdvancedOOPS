using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails1
{
    public partial class StudentInfo
    {
        /*Create an application for student info

        Create a class file named StudentProps
        Inside that create a partial class Studentinfo and provide properties -  StudentID,Name,Gender,DOB, Mobile, Physics, Chemistry, Maths Marks
        Create another class file named StudentConstructors
        Inside that create a partial class Studentinfo and provide Constructor
        Create another class file named StudentMethods
        Inside that create a partial class Studentinfo and provide Methods -> Calculate total and percentage, and Display*/
        private int s_studentID=0;
        public int StudentID{get;set;}
        public string Name{get;set;}
        public string Gender{get;set;}
        public DateTime DOB{get;set;}
        public string Mobile{get;set;}
        public int Physics{get;set;}
        public int Chemistry{get;set;}
        public int Maths{get;set;}
    }
}