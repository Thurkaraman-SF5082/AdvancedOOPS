using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientDetails
{
    public class DoctorInfo:PatientInfo
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
        public int DoctorID{get;set;}
        public string Name{get;set;}
        public string FatherName{get;set;}
        public DoctorInfo(int doctorID,string name,string fatherName)
        {
            DoctorID=doctorID;
            Name=name;
            FatherName=fatherName;
        }
        public string DisplayInfo()
        {
            return $"DoctorID:{DoctorID}, Name:{Name}, FatherName:{FatherName}";
        }
    }
}