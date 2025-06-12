using System;
namespace BankDetails;

class Program
{
    public static void Main()
    {
        /*Program to  Manipulate bank account details: Create 3 account holders Show Account Info, deposit, withdraw and Show Balance.

        Class PersonalInfo:

        Properties: Name, FatherName, Phone, Mail, DOB, Gender

        Class AccountInfo : Inherit PersonalInfo

        Properties: AccountNumber, BranchName, IFSCCode, Balance

        Methods: ShowAccountInfo, Deposit , Withdraw, ShowBalance.*/

        AccountInfo account=new AccountInfo("132","mambalam","hdfc333",5000,"rave","ettapar","345678","dsdert5678i",new DateTime(2000,05,21),"male");

        System.Console.WriteLine(account.ShowAccountInfo());
        System.Console.WriteLine($"Balance: {account.ShowBalance()}");

        System.Console.WriteLine("Enter amount:");
        int amount=int.Parse(Console.ReadLine());
        account.Deposit(amount);

        System.Console.WriteLine($"Balance: {account.ShowBalance()}");



    }
}