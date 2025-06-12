using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientDetails
{
    public sealed class PatientInfo
    {
        /*Create an application for patient detail manipulation
 
        Sealed Class PatientInfo:
        Properties: PatientID, Name, FatherName, BedNo, NativePlace, AdmittedFor
        Method: DisplayInfo

        Class DoctorInfo: Inherit PatientInfo
        Properties: DoctorID, Name, FatherName
        Methods: DisplayInfo

        Create a patient object and display his info
        Create a doctor object and display info*/
        public int PatientID{get;set;}
        public string Name{get;set;}
        public string FatherName{get;set;}
        public int BedNo{get;set;}
        public string NativePlace{get;set;}
        public string AdmittedFor{get;set;}
        public PatientInfo(int patientID,string name,string fatherName,int bedNo,string nativePlace,string admittedFor)
        {
            PatientID=patientID;
            Name=name;
            FatherName=fatherName;
            BedNo=bedNo;
            NativePlace=nativePlace;
            AdmittedFor=admittedFor;
        }
        public string DisplayInfo()
        {
            return $"PatientID:{PatientID}, Name:{Name}, FatherName:{FatherName}, BedNo:{BedNo}, NativePlace:{NativePlace}, AdmittedFor:{AdmittedFor}";
        }
    }
}