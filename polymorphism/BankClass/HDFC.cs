using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankClass
{
    public class HDFC:Bank
    {
        /*Create a bank class that have an abstract method double return type GetIntresetInfo

        Create a class SBI and override GetIntresetInfo method and return 7.5%.
        Create a class ICICI and override GetIntresetInfo method and return 7.5%.
        Create a class HDFC and override GetIntresetInfo method and return 7.5%.
        Create a class IDBI and override GetIntresetInfo method and return 7.5%.

        Declare object for bank class
        Assign SBI class object to Bank object and Display SBI Interest value by calling GetIntrestInfo
        Assign ICICI class object to Bank object and Display SBI Interest value by calling GetIntrestInfo
        Assign HDFC class object to Bank object and Display SBI Interest value by calling GetIntrestInfo
        Assign IDBI class object to Bank object and Display SBI Interest value by calling GetIntrestInfo*/
        public override double GetIntresetInfo()
        {
            return 8.5;
        }
    }
}