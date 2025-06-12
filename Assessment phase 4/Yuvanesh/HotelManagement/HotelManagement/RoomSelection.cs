using System;
namespace HotelManagement
{
    public class RoomSelection
    {
        private static int s_roomSelectionID = 5000;
       
        private string _selectionID;
       
        public string SelectionID { get{return _selectionID;} set{_selectionID = value; s_roomSelectionID = int.Parse(value.Remove(0,3));}}
       
        public string WishListID { get; set; }
        
        public string BookingID { get; set; }
       
        public string RoomID { get; set; }
        
        public DateTime StayingDateFrom { get; set; }
       
        public DateTime StayingDateTo { get; set; }
       
        public double Price { get; set; }
       
        public double NumberOfDays { get; set; }
        
        public BookingStatusDetails BookingStatus { get; set; }

        public RoomSelection() { }
       
        public RoomSelection(string wishListID, string bookingID, string roomID, DateTime fromDate, DateTime toDate, double price, double days, BookingStatusDetails status)
        {
            SelectionID = $"SID{++s_roomSelectionID}";
            WishListID = wishListID;
            BookingID = bookingID;
            RoomID = roomID;
            StayingDateFrom = fromDate;
            StayingDateTo = toDate;
            Price = price;
            NumberOfDays = days;
            BookingStatus = status;
        }

    }
}