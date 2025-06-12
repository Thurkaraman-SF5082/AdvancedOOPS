using System;

namespace HotelManagement
{
    public class BookingDetails
    {
        private static int s_bookingID = 4000;
        private string _bookingID;
        public string BookingID { get{return _bookingID;} set{_bookingID = value; s_bookingID = int.Parse(value.Remove(0,3));}}
        public string UserID { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        public BookingStatusDetails BookingStatus { get; set; }
        public BookingDetails(string userID, double totalPrice, DateTime bookingDate, BookingStatusDetails bookingStatus)
        {
            BookingID = $"BID{++s_bookingID}";
            UserID = userID;
            TotalPrice = totalPrice;
            DateOfBooking = bookingDate;
            BookingStatus = bookingStatus;
        }
        public BookingDetails() { }

    }
}