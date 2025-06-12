using System;
namespace PatientDetails;

class Program
{
    public static void Main()
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
        
        PatientInfo patient=new PatientInfo(1,"ram","raman",12,"vpm","cold");

        System.Console.WriteLine(patient.DisplayInfo());

        DoctorInfo doctor=new DoctorInfo(11,"ram","raman");

        System.Console.WriteLine(doctor.DisplayInfo());
              
    }
}