using System;
namespace BankClass;

class Program
{
    public static void Main()
    {
        /*Create a bank class that have an abstract method double return type GetIntresetInfo

        Create a class SBI and override GetIntresetInfo method and return 7.5%.
        Create a class ICICI and override GetIntresetInfo method and return 7.5%.
        Create a class HDFC and override GetIntresetInfo method and return 7.5%.
        Create a class IDBI and override GetIntresetInfo method and return 7.5%.

        Declare object for bank class
        Assign SBI class object to Bank object and Display SBI Interest value by calling GetIntrestInfo
        Assign ICICI class object to Bank object and Display SBI Interest value by calling GetIntrestInfo
        Assign HDFC class object to Bank object and Display SBI Interest value by calling GetIntrestInfo
        Assign IDBI class object to Bank object and Display SBI Interest value by calling GetIntrestInfo*/

        Bank bank=new SBI();
        System.Console.WriteLine($"sbi:{bank.GetIntresetInfo()}%");

        bank=new ICICI();
        System.Console.WriteLine($"icici:{bank.GetIntresetInfo()}%");

        bank=new HDFC();
        System.Console.WriteLine($"hdfc:{bank.GetIntresetInfo()}%");

        bank=new IDBI();
        System.Console.WriteLine($"idbi:{bank.GetIntresetInfo()}%");
        
    }
}