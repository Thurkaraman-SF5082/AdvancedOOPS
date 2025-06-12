using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public class BirthRegistration
    {
        private static int s_birthRegistrationID = 0;
        public int BirthRegistrationID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public BirthRegistration()
        {

        }
        public BirthRegistration(string name, string fatherName, DateTime registrationDate, DateTime birthDate, string gender)
        {
            s_birthRegistrationID++;
            BirthRegistrationID = s_birthRegistrationID;
            Name = name;
            FatherName = fatherName;
            RegistrationDate = registrationDate;
            BirthDate = birthDate;
            Gender = gender;
        }
        public BirthRegistration(int birthRegistrationID,string name, string fatherName, DateTime registrationDate, DateTime birthDate, string gender)
        {
            BirthRegistrationID = birthRegistrationID;
            Name = name;
            FatherName = fatherName;
            RegistrationDate = registrationDate;
            BirthDate = birthDate;
            Gender = gender;
        }
        
        public string DisplayBirthRegistration()
        {
            return $"Birth Registration ID:{BirthRegistrationID}, Name:{Name}, FatherName:{FatherName}, Registartion Date:{RegistrationDate}, Birth Date:{BirthDate}, Gender:{Gender}";
        }
    }
}