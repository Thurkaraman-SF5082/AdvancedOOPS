using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankDetails
{
    public class AccountInfo:PersonalInfo
    {
        /*Program to  Manipulate bank account details: Create 3 account holders Show Account Info, deposit, withdraw and Show Balance.

        Class PersonalInfo:

        Properties: Name, FatherName, Phone, Mail, DOB, Gender

        Class AccountInfo : Inherit PersonalInfo

        Properties: AccountNumber, BranchName, IFSCCode, Balance

        Methods: ShowAccountInfo, Deposit , Withdraw, ShowBalance.*/

        public string AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        private static int _balance;
        public int Balance { get{return _balance;} set{_balance=value;} }
        public AccountInfo(){}
        public AccountInfo(string accountNumber,string branchName,string ifscCode,int balance,string name,string fatherName,string phone,string mail,DateTime dob,string gender):base(name,fatherName,phone,mail,dob,gender)
        {
            AccountNumber=accountNumber;
            BranchName=branchName;
            IFSCCode=ifscCode;
            Balance=balance;
        }
        public void Deposit(int amount)
        {
            Balance +=amount;
        }
        public void Withdraw(int amount)
        {
            Balance -=amount;
        }
        public int ShowBalance()
        {
            return Balance;
        }
        public string ShowAccountInfo()
        {
            return $"AccountNumber:{AccountNumber}, BranchName:{BranchName}, IFSCCode:{IFSCCode}, Balance:{Balance}, Name:{Name}, FatherName:{FatherName}, Phone:{Phone}, Mail:{Mail}, DOB:{DOB}, Gender:{Gender}";
        }
    }
}