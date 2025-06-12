using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHospital
{
    public interface ITransaction
   {
//         Property:
// •	WalletBalance
//  Method:
// •	WalletRecharge
// •	DeductBalance
        double WalletBalance{get;set;}
        public void WalletRecharge(double amount);
        public void DeductBalance(double amount);

    }
}