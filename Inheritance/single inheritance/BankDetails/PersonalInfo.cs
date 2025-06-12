using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace BankDetails
{
    public class PersonalInfo
    {
        /*Program to  Manipulate bank account details: Create 3 account holders Show Account Info, deposit, withdraw and Show Balance.

        Class PersonalInfo:

        Properties: Name, FatherName, Phone, Mail, DOB, Gender

        Class AccountInfo : Inherit PersonalInfo

        Properties: AccountNumber, BranchName, IFSCCode, Balance

        Methods: ShowAccountInfo, Deposit , Withdraw, ShowBalance.*/
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public PersonalInfo(){}
        public PersonalInfo(string name,string fatherName,string phone,string mail,DateTime dob,string gender)
        {
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            DOB=dob;
            Gender=gender;
        }
    }
}