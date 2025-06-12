using System;
namespace HotelManagement
{
    public class WishList
    {

        private static int s_wishListID = 3000;

        private string _wishListID;

        public string WishListID
        {
            get { return _wishListID; }
            set
            {
                _wishListID = value;
                s_wishListID = int.Parse(value.Remove(0, 4));
            }
        }

        public string UserID { get; set; }

        public string RoomID { get; set; }

        public double PriceOfRoom { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public WishList(string userID, string roomID, double priceOfRoom, DateTime fromDate, DateTime toDate)
        {
            WishListID = $"WSID{++s_wishListID}";
            UserID = userID;
            RoomID = roomID;
            PriceOfRoom = priceOfRoom;
            FromDate = fromDate;
            ToDate = toDate;
        }

        public WishList() { }
    }
}