using System;
namespace RegistrationMI;

class Program
{
    public static void Main()
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

        RegisterPerson registerPerson=new RegisterPerson("ram","male",new DateTime(2002,05,26),"234567678","3456789","ramadass","selvi","55fgvvhjjvh",2,"single",new DateTime(2025,05,26));

        System.Console.WriteLine(registerPerson.ShowInfo());
        
    }
}