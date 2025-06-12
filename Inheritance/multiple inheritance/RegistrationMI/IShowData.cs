using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationMI
{
    public interface IShowData
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
        public string ShowInfo();
    }
}