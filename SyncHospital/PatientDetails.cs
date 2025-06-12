using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHospital
{
    public class PatientDetails : PersonalDetails, ITransaction
    {
        //         Field:
        // •	walletBalance
        //  	    Properties:
        // •	PatientID (Auto Increment - PID1001)
        // •	WalletBalance
        //      Method:
        // •	Recharge
        // •	DeductBalance
        private double _balance;
        public double WalletBalance { get { return _balance; } set { _balance = value; } }
        private static int s_patientID = 1000;
        public string PatientID { get; set; }
        public PatientDetails() { }
        public PatientDetails(string name, string fatherName, string gender, string phone, int age, string bloodGroup, double walletBalance) : base(name, fatherName, gender, phone, age, bloodGroup)
        {
            PatientID = $"PID{++s_patientID}";
            WalletBalance = walletBalance;
        }
        public void WalletRecharge(double amount)
        {
            WalletBalance += amount;
        }
        public void DeductBalance(double amount)
        {
            WalletBalance -= amount;
        }

    }
}