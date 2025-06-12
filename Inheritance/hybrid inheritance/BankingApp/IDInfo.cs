using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApp
{
    public class IDInfo:PersonalInfo
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
        int VoterID{get;set;}
        int AadharID{get;set;}
        string PAN{get;set;}
        public IDInfo(){}
        public IDInfo(int voterID,int aadharID,string pan,string name,string phone,string mobile,DateTime dob,string gender):base(name,phone,mobile,dob,gender)
        {
            VoterID=voterID;
            AadharID=aadharID;
            PAN=pan;
        }
    }
}