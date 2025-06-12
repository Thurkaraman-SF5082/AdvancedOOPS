using System;
namespace SingleInheritance;

class Program
{
    public static void Main()
    {
        BirthRegistration birth=new BirthRegistration("Raman","Ramadass",DateTime.Now,new DateTime(2002,05,26),"Male");
        System.Console.WriteLine(birth.DisplayBirthRegistration());

        AadharRegistration aadhar=new AadharRegistration(10,"ravi","ravvviiiii",DateTime.Now,new DateTime(2002,05,26),"Male","vpm");
        

        System.Console.WriteLine(aadhar.DisplayAadharRegistration());
    }
}