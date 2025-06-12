using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendenceClass
{
    public class Attendence
    {
        /*Create a class named Attendance that have total working days in month, number of leaves taken, number of permissions taken.

        Create objects month1, month 2, month3 and calculate the three months total working days, number of leaves taken, and number of 
        permissions taken and calculate the total salary by number of days worked * 500 Rs. */
        public double TotalWorkingDays{get;set;}
        public double NumberOfLeavesTaken{get;set;}
        public double NumberOfPermissionTaken{get;set;}
        public Attendence(){}
        public Attendence(double totalWorkingDays,double numberOfLeavesTaken,double numberOfPermissionTaken)
        {
            TotalWorkingDays=totalWorkingDays;
            NumberOfLeavesTaken=numberOfLeavesTaken;
            NumberOfPermissionTaken=numberOfPermissionTaken;
        }

        public static Attendence operator+ (Attendence v1,Attendence v2)
        {
            Attendence attendence=new Attendence(0,0,0);
            attendence.TotalWorkingDays =v1.TotalWorkingDays+v2.TotalWorkingDays;
            attendence.NumberOfLeavesTaken =v1.NumberOfLeavesTaken+v2.NumberOfLeavesTaken;
            return attendence;
        }
        

    }
}