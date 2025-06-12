using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickFoodz
{
    public interface IBalance
    {
        /*Properties: WalletBalance
        Methods: WalletRecharge, DeductBalance (Have to get the amount through parameters for both the methods).
        */
        double WalletBalance{get;set;}
        void WalletRecharge(double amount);
        void DeductBalance(double amount);
    }
}