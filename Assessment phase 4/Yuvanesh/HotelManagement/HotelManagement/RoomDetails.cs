
namespace HotelManagement
{
    public class RoomDetails
    {
        private static int s_roomID = 2000;

        private string _roomID;

        public string RoomID { get{return _roomID;} set{_roomID = value; s_roomID = int.Parse(value.Remove(0,3));}}

        public RoomTypeDetails RoomType { get; set; }

        public int NumberOfBeds { get; set; }

        public double PricePerDay { get; set; }

        public RoomDetails() { }

        public RoomDetails(RoomTypeDetails roomType, int numberOfBeds, double price)
        {
            RoomID = $"RID{++s_roomID}";
            RoomType = roomType;
            NumberOfBeds = numberOfBeds;
            PricePerDay = price;
        }
    }
}