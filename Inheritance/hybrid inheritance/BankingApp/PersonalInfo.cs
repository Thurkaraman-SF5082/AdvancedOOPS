using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApp
{
    public class PersonalInfo
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
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public PersonalInfo(){}
        public PersonalInfo(string name,string phone,string mobile,DateTime dob,string gender)
        {
            Name=name;
            Phone=phone;
            Mobile=mobile;
            DOB=dob;
            Gender=gender;
        }
        public string ShowPersonalInfo()
        {
            return $"Name:{Name}, DOB:{DOB}, Phone:{Phone}, Gender:{Gender}, Mobile:{Mobile}";
        }
    }
}