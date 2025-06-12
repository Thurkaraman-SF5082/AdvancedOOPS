
namespace HotelManagement
{
    public class PersonalDetails
    {

        public string UserName { get; set; }

        public long Mobile { get; set; }

        public long AadharNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public FoodTypeDetails FoodType { get; set; }

        public GenderDetails Gender { get; set; }

        public PersonalDetails() { }
        public PersonalDetails(string userName, long mobile, long aadhar, string email, string address, FoodTypeDetails foodType, GenderDetails gender)
        {
            UserName = userName;
            Mobile = mobile;
            AadharNumber = aadhar;
            Email = email;
            Address = address;
            FoodType = foodType;
            Gender = gender;
        }

    }
}