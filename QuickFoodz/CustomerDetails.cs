using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuickFoodz;

namespace QuickFoodz
{
    public class CustomerDetails:PersonalDetails,IBalance
    {
        /*Field: 
        a.	_balance (Private field) 
        Properties: 
        a.	CustomerID (Auto Increment – CID1000) 
        b.	WalletBalance
                Methods: 
        a.	WalletRecharge: Get the recharge amount through parameters and update wallet balance of the current user. 
        b.	DeductBalance: Get the deducted amount through parameters and update wallet balance of the current user. 
        */
        private double _balance;
        private static int s_customerID=1000;
        public string CustomerID{get;set;}
        public double WalletBalance{get{return _balance;}set{_balance=value;}}
        public CustomerDetails(string customerName,string fatherName,GenderDetails gender,string mobileNumber,DateTime dob,string mailID,string location,double walletBalance):base(customerName,fatherName,gender,mobileNumber,dob,mailID,location)
        {
            CustomerID=$"CID{++s_customerID}";
            WalletBalance=walletBalance;
        }
        public CustomerDetails(){}
        public void WalletRecharge(double amount)
        {
            WalletBalance +=amount;
        }
        public void DeductBalance(double amount)
        {
            WalletBalance -=amount;
        }

    }
}