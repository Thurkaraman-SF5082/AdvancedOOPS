using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHospital
{
    public class AppoinmentDetails
    {
        //         •	AppointmentID (Auto Increment – AID501)
        // •	PatientID
        // •	DoctorID
        // •	Appointment Date
        // •	Appointment Slot
        // •	Status – (Enum – Booked, Cancelled)
        // •	Fees
        private static int s_appoinmentID=500;
        public string AppointmentID{get;set;}
        public string PatientID{get;set;}
        public string DoctorID{get;set;}
        public DateTime AppoinmentDate{get;set;}
        public string AppoinmentSlot{get;set;}
        public AppoinmentStatus Status{get;set;}
        public double Fees{get;set;}
        public AppoinmentDetails(){}
        public AppoinmentDetails(string patientID,string doctorID,DateTime appoinmentDate,string appoinmentSlot,AppoinmentStatus status,double fees)
        {
            AppointmentID=$"AID{++s_appoinmentID}";
            PatientID=patientID;
            DoctorID=doctorID;
            AppoinmentDate=appoinmentDate;
            AppoinmentSlot=appoinmentSlot;
            Status=status;
            Fees=fees;
        }

    }
}