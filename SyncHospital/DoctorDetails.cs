using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHospital
{
    public class DoctorDetails:PersonalDetails
    {
//         •	DoctorID (Auto Increment – DID 300)
// •	Experience
// •	Specialization
// •	Fees

        private static int s_doctorID=300;
        public string DoctorID{get;set;}
        public double Experience{get;set;}
        public string Specialization{get;set;}
        public double Fees{get;set;}
        public DoctorDetails(){}
        public DoctorDetails(string name,string fatherName,string gender,string phone,int age,string bloodGroup,double experience,string specialization,double fees):base(name,fatherName,gender,phone,age,bloodGroup)
        {
            DoctorID=$"DID{++s_doctorID}";
            Experience=experience;
            Specialization=specialization;
            Fees=fees;
        }

    }
}