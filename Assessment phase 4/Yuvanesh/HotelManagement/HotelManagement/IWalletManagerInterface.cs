
namespace HotelManagement
{
    public interface IWalletManagerInterface
    {
        public double WalletBalance { get; set; }
       
        public void WalletRecharge(double amount);
        
        public void DeductBalance(double amount);
    }
}