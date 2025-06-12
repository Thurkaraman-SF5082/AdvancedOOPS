using System;
using System.Collections.Generic;
namespace AttendenceClass;

class Program
{
    public static void Main()
    {
        /*Create a class named Attendance that have total working days in month, number of leaves taken, number of permissions taken.

        Create objects month1, month 2, month3 and calculate the three months total working days, number of leaves taken, and number of 
        permissions taken and calculate the total salary by number of days worked * 500 Rs. */
        List<Attendence> attendences=new List<Attendence>();

        Attendence month1=new Attendence(20,2,1);
        Attendence month2=new Attendence(25,1,3);
        Attendence month3=new Attendence(22,5,0);

        Attendence result=month1+month2+month3;
        double total = result.TotalWorkingDays - result.NumberOfLeavesTaken;

        
        System.Console.WriteLine($"Total salary : {total*500}");
        
        
    }
}