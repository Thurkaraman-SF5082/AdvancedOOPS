using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationMI
{
    public class PersonalInfo:IShowData
    {
        /*Create application for getting, storing  person’s details create two objects for register person

        Interface IShowData:

        Methods: ShowInfo



        Class Personalnfo inherit IShowData

        Properties: Name, Gender,DOB, phone, mobile, Marital details – Married/single

        Method: ShowInfo



        Interface IFamilyInfo: inherit IShowData

        Properties: FatherName, MotherName, HouseAddress, No.Of.Siblings  

        Method: ShowInfo



        Class RegisterPerson inherits Personalinfo, IShowData, IFamilyInfo

        Properties: RegistrationNumber(Auto), DateOfRegistration,

        Methods: ShowInfo*/
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Status { get; set; }
        
        
        public PersonalInfo(){}
        public PersonalInfo(string name,string gender,DateTime dob,string phone,string mobile,string status)
        {
            Name=name;
            Gender=gender;
            DOB=dob;
            Phone=phone;
            Mobile=mobile;
            Status=status;
        }

        public string ShowInfo()
        {
            return $"Name:{Name}, Gender:{Gender},DOB:{DOB}, phone:{Phone}, mobile:{Mobile}, Marital details:{Status}";
        }
    }
}