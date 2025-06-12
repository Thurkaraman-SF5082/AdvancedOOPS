using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationMI
{
    public class RegisterPerson:PersonalInfo,IShowData,IFamilyInfo
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
        private int s_registrationNumber=0;
        public int RegistrationNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public string FatherName{get;set;}
        public string MotherName{get;set;}
        public string HouseAddress{get;set;}
        public int NoOfSiblings{get;set;}
        public RegisterPerson(){

        }
        public RegisterPerson(string name,string gender,DateTime dob,string phone,string mobile,string fatherName,string motherName,string houseAddress,int noOfSiblings,string status,DateTime dateOfRegistration):base(name,gender,dob,phone,mobile,status)
        {
            s_registrationNumber++;
            RegistrationNumber=s_registrationNumber;
            FatherName=fatherName;
            MotherName=motherName;
            HouseAddress=houseAddress;
            NoOfSiblings=noOfSiblings;
            DateOfRegistration=dateOfRegistration;
        }

        public string ShowInfo()
        {
            return $"RegistrationNumber:{RegistrationNumber}, DateOfRegistration:{DateOfRegistration}, Name:{Name}, Gender:{Gender},DOB:{DOB}, phone:{Phone}, mobile:{Mobile}, FatherName:{FatherName}, MotherName:{MotherName}, HouseAddress:{HouseAddress}, No.Of.Siblings:{NoOfSiblings}, Marital details:{Status}";
        }
    }
}