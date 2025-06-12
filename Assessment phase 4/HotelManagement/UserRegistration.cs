
namespace HotelManagement
{
    public class UserRegistration : PersonalDetails, IWalletManagerInterface
    {
        private double _balance;

        private static int s_userID = 1000;

        private string _userID;

        public string UserID
        {
            get { return _userID; }
            set
            {
                _userID = value;
                s_userID = int.Parse(value.Remove(0, 2));
            }
        }

        public double WalletBalance { get { return _balance; } set { _balance = value; } }

        public UserRegistration(string userName, long mobile, long aadhar, string email, string address, FoodTypeDetails foodType, GenderDetails gender, double balance) : base(userName, mobile, aadhar, email, address, foodType, gender)
        {
            UserID = $"SF{++s_userID}";
            _balance = balance;
        }

        public UserRegistration() { }
        public void WalletRecharge(double amount)
        {
            _balance += amount;
        }


        public void DeductBalance(double amount)
        {
            _balance -= amount;
        }

    }
}