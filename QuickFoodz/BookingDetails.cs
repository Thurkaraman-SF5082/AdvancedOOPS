using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickFoodz
{
    public class BookingDetails
    {
        /*Properties: 
        a.	BookingID (Auto Increment – BID3000)
        b.	CustomerID
        c.	TotalPrice
        d.	DateOfBooking
        e.	BookingStatus {Enum – Initiated, Booked, Cancelled}
        */
        private static int s_bookingID = 3000;
        public string BookID { get; set; }
        public string CustomerID { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOfOrder { get; set; }
        public BookingStatus BookingStatus { get; set; }
        public BookingDetails(string customerID, double totalPrice, DateTime dateOfOrder, BookingStatus bookingStatus)
        {
            BookID = $"BID{++s_bookingID}";
            CustomerID = customerID;
            TotalPrice = totalPrice;
            DateOfOrder = dateOfOrder;
            BookingStatus = bookingStatus;
        }
        public BookingDetails(){}

    }
}