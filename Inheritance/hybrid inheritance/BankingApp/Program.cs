using System;
namespace BankingApp;

class Program
{
    public static void Main()
    {
        /*Create an application for banking application manipulation create 2 object for saving account and using deposite withdraw and check balance method.

        Class PersonalInfo:

        Properties: Name, Gender, DOB, phone, mobile

        Class IDInfo: inherit PersonalInfo

        Properties: VoterID, AadharID, PAN number

        Interface ICalculate:

        Methods: Deposit, Withdraw, Balance check

        Interface IBankInfo:

        Properties: BankName, IFSC, Branch

        Class SavingAccount: Inherit IDInfo, ICalculate, IBankInfo

        Properties: AccountNumber, AccountType->Savings, Balance

        Methods: Deposit, Withdraw, BalanceCheck*/

        SavingAccount saving=new SavingAccount(66656,"saving","mambalam","HDFC","HDFC5677",5000.50,22,123,"gsg8889hh","ram","4567890","95824982",new DateTime(1111,11,1),"male");

        System.Console.WriteLine(saving.CheckBalance());
        saving.Deposit(150.898);
        System.Console.WriteLine(saving.CheckBalance());
        saving.Withdraw(1500);
        System.Console.WriteLine(saving.CheckBalance());

        
        
    }
}