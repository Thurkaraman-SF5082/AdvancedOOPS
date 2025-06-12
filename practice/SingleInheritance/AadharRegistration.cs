using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public class AadharRegistration : BirthRegistration
    {
        private static int s_aadharRegistrationID = 0;
        public int AadharRegistrationID { get; set; }
        public string Address { get; set; }
        public AadharRegistration()
        {
            
        }
        public AadharRegistration(int birthRegistrationID,string name, string fatherName, DateTime registrationDate, DateTime birthDate, string gender,string address):base(birthRegistrationID,name,fatherName,registrationDate,birthDate,gender)
        {
            s_aadharRegistrationID++;
            AadharRegistrationID = s_aadharRegistrationID;
            Address=address;
        }
        public string DisplayAadharRegistration()
        {
            return $"Aadhar ID:{AadharRegistrationID}, {DisplayBirthRegistration()}, Address:{Address}";
        }
    }
}