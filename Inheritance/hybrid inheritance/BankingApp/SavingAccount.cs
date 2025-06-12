using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApp
{
    public class SavingAccount : IDInfo, ICalculate, IBankInfo
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
        private double _balance;
        public long AccountNumber { get; set; }
        public string AccountType { get; set; }
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public string Branch { get; set; }
        public double Balance { get { return _balance; } set { _balance = value; } }

        public SavingAccount(){}
        public SavingAccount(long accountNumber,string accountType,string branch,string bankName,string ifsc,double balance,int voterID,int aadharID,string pan,string name,string phone,string mobile,DateTime dob,string gender):base(voterID,aadharID,pan,name,phone,mobile,dob,gender)
        {
            AccountNumber=accountNumber;
            AccountType=accountType;
            Branch=branch;
            BankName=bankName;
            IFSC=ifsc;
            Balance=balance;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
        public double CheckBalance()
        {
            return Balance;
        }
    }
}