using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace HotelManagement
{
    public class Operations
    {
        public CustomList<UserRegistration> users = new();
        public CustomList<RoomDetails> rooms = new();
        public CustomList<RoomSelection> roomSelections = new();
        public CustomList<WishList> wishLists = new();
        public CustomList<BookingDetails> bookings = new();
        UserRegistration currentLoggedInUser;
        public void AddDefaultData()
        {

            //adding users default Data
            UserRegistration user1 = new UserRegistration("Ravichandran", 995875777, 347777378383, "ravi@gmail.com", "Chennai", FoodTypeDetails.Veg, GenderDetails.Male, 5000);
            UserRegistration user2 = new UserRegistration("Baskaran", 448844848, 474777477477, "baskar@gmail.com", "Chennai", FoodTypeDetails.NonVeg, GenderDetails.Male, 6000);
            users.AddRange(new CustomList<UserRegistration> { user1, user2 });
            //adding Room Details
            RoomDetails room1 = new RoomDetails(RoomTypeDetails.Standard, 2, 500);
            RoomDetails room2 = new RoomDetails(RoomTypeDetails.Standard, 4, 700);
            RoomDetails room3 = new RoomDetails(RoomTypeDetails.Standard, 2, 500);
            RoomDetails room4 = new RoomDetails(RoomTypeDetails.Standard, 2, 500);
            RoomDetails room5 = new RoomDetails(RoomTypeDetails.Standard, 2, 500);
            RoomDetails room6 = new RoomDetails(RoomTypeDetails.Delux, 2, 1000);
            RoomDetails room7 = new RoomDetails(RoomTypeDetails.Delux, 2, 1000);
            RoomDetails room8 = new RoomDetails(RoomTypeDetails.Delux, 4, 1400);
            RoomDetails room9 = new RoomDetails(RoomTypeDetails.Delux, 4, 1400);
            RoomDetails room10 = new RoomDetails(RoomTypeDetails.Suit, 2, 2000);
            RoomDetails room11 = new RoomDetails(RoomTypeDetails.Suit, 2, 2000);
            RoomDetails room12 = new RoomDetails(RoomTypeDetails.Suit, 2, 2000);
            RoomDetails room13 = new RoomDetails(RoomTypeDetails.Suit, 4, 2500);
            rooms.AddRange(new CustomList<RoomDetails> { room1, room2, room3, room4, room5, room6, room7, room8, room9, room10, room11, room12, room13 });
            //adding room Selection details
            RoomSelection roomSelection1 = new RoomSelection("WSID3001", "BID4001", "RID2001", new DateTime(2024, 11, 11, 6, 0, 0), new DateTime(2024, 11, 12, 14, 0, 0), 750, 1.5, BookingStatusDetails.Booked);
            RoomSelection roomSelection2 = new RoomSelection("WSID3002", "BID4001", "RID2002", new DateTime(2024, 11, 11, 10, 0, 0), new DateTime(2024, 11, 12, 9, 0, 0), 700, 1, BookingStatusDetails.Booked);
            RoomSelection roomSelection3 = new RoomSelection("WSID3003", "BID4002", "RID2003", new DateTime(2024, 11, 12, 9, 0, 0), new DateTime(2024, 11, 13, 9, 0, 0), 500, 1, BookingStatusDetails.Cancelled);
            RoomSelection roomSelection4 = new RoomSelection("WSID3004", "BID4002", "RID2006", new DateTime(2024, 11, 12, 6, 0, 0), new DateTime(2024, 11, 13, 12, 30, 0), 700, 1, BookingStatusDetails.Booked);
            roomSelections.AddRange(new CustomList<RoomSelection> { roomSelection1, roomSelection2, roomSelection3, roomSelection4 });
            //adding WishCustomList details
            WishList wishCustomList1 = new WishList("SF1001", "RID2001", 750, new DateTime(2024, 11, 12, 9, 0, 0), new DateTime(2024, 11, 13, 9, 0, 0));
            WishList wishCustomList2 = new WishList("SF1001", "RID2002", 700, new DateTime(2024, 11, 12, 6, 0, 0), new DateTime(2024, 11, 13, 12, 30, 0));
            WishList wishCustomList3 = new WishList("SF1002", "RID2001", 750, new DateTime(2025, 2, 27, 9, 0, 0), new DateTime(2025, 2, 28, 10, 0, 0));
            WishList wishCustomList4 = new WishList("SF1001", "RID2001", 750, new DateTime(2025, 3, 3, 10, 0, 0), new DateTime(2025, 3, 4, 11, 0, 0));
            wishLists.AddRange(new CustomList<WishList> { wishCustomList1, wishCustomList2, wishCustomList3, wishCustomList4 });
            //Adding default Booking details
            BookingDetails booking1 = new BookingDetails("SF1001", 1450, new DateTime(2024, 11, 10), BookingStatusDetails.Booked);
            BookingDetails booking2 = new BookingDetails("SF1002", 2000, new DateTime(2024, 11, 10), BookingStatusDetails.Cancelled);
            bookings.AddRange(new CustomList<BookingDetails> { booking1, booking2 });

            new Grid<UserRegistration>().Display(users);

        }
        public string AddUser(UserRegistration user)
        {
            users.Add(user);
            return user.UserID;
        }

        public bool Login(string userID)
        {
            // traversing to check the correct user
            foreach (UserRegistration user in users)
            {
                if (user.UserID == userID)
                {
                    currentLoggedInUser = user;
                    return true;
                }
            }
            return false;
        }

        // method to get CustomerProfile
        public UserRegistration GetUserProfile()
        {
            return currentLoggedInUser;
        }
        // method to get WalletBalance
        public double GetWalletBalance()
        {
            return currentLoggedInUser.WalletBalance;
        }
        // method to do WalletRecharge
        public void DoWalletRecharge(double amount)
        {
            currentLoggedInUser.WalletRecharge(amount);
        }
        // method to GetEmptyRoomCustomList
        public CustomList<RoomDetails> GetEmptyRoomList()
        {
            // creating temp CustomList to Store Empty rooms
            CustomList<RoomDetails> emptyRoomCustomList = new CustomList<RoomDetails>();
            // traversing through RoomCustomList
            foreach (RoomDetails room in rooms)
            {
                bool flag = true;
                // traversing throug selection to check available rooms
                foreach (RoomSelection roomSelection in roomSelections)
                {
                    // cheking is the room is empty or not
                    if (roomSelection.RoomID == room.RoomID)
                    {
                        if (roomSelection.BookingStatus != BookingStatusDetails.Booked)
                        {
                            emptyRoomCustomList.Add(room);
                        }
                        flag = false;
                    }
                }
                // if the room id is not matched then there is no room in the selection CustomList
                // so its a free room so adding it to the CustomList
                if (flag)
                {
                    emptyRoomCustomList.Add(room);
                }
            }
            return emptyRoomCustomList;
        }
        // method to GetCart
        public CustomList<WishList> GetCurrentWishList()
        {
            // temp CustomList
            CustomList<WishList> temp = new CustomList<WishList>();
            foreach (WishList wish in wishLists)
            {
                if (wish.UserID == currentLoggedInUser.UserID)
                {
                    temp.Add(wish);
                }
            }
            return temp;
        }
        // method for AddToWishCustomList
        public int AddToWishList(string roomID, DateTime fromDate, DateTime toDate)
        {
            CustomList<RoomDetails> emptyRoom = GetEmptyRoomList();
            // traversing through all rooms for id Mathc
            // but we can traverse through only empty room if dont want to to check other room id's
            foreach (RoomDetails room in rooms)
            {
                if (room.RoomID == roomID)
                {
                    // traversing through empty room for the correct room id
                    foreach (RoomDetails roomDetails in emptyRoom)
                    {
                        if (emptyRoom.Count != 0 && roomDetails.RoomID == roomID)
                        {
                            // cheking the date
                            foreach (RoomSelection roomSelection in roomSelections)
                            {
                                // cheking dates if it is free or not
                                // problem in date condition
                                if (roomSelection.RoomID == roomID)
                                {
                                    if (fromDate > roomSelection.StayingDateTo)
                                    {
                                        WishList wish = new WishList(currentLoggedInUser.UserID, roomID, roomDetails.PricePerDay, fromDate, toDate);
                                        wishLists.Add(wish);
                                        return 2;
                                    }
                                }
                            }
                        }
                    }
                    return 1;
                }
            }
            // for invalid id
            return 0;
        }
        // method to get RoomCustomList
        public CustomList<RoomDetails> GetRoomList()
        {
            return rooms;
        }
        // method to get selection CustomList
        public CustomList<RoomSelection> GetRoomSelectionList()
        {
            return roomSelections;
        }
        // method to get Booking History
        public CustomList<BookingDetails> GetBookingHistory()
        {
            // temp CustomList to return current user's booking history
            CustomList<BookingDetails> temp = new CustomList<BookingDetails>();
            foreach (BookingDetails booking in bookings)
            {
                if (booking.UserID == currentLoggedInUser.UserID)
                {
                    temp.Add(booking);
                }
            }
            return temp;
        }
        // method to get GetBookedBookingHistory
        public CustomList<BookingDetails> GetBookedBookingHistory()
        {
            // temp CustomList store th booked history
            CustomList<BookingDetails> temp = new CustomList<BookingDetails>();
            foreach (BookingDetails booking in GetBookingHistory())
            {
                if (booking.BookingStatus == BookingStatusDetails.Booked)
                {
                    temp.Add(booking);
                }
            }
            return temp;
        }
        // method to cancel Booking
        public bool CancelBooking(string bookingID)
        {
            // traversing through booking History
            foreach (BookingDetails booking in bookings)
            {
                if (booking.BookingID == bookingID)
                {
                    booking.BookingStatus = BookingStatusDetails.Cancelled;
                    // updating the wallet after cancelling
                    currentLoggedInUser.WalletRecharge(booking.TotalPrice);
                    // traversing through selection CustomList to change status to cancelled
                    foreach (RoomSelection roomSelection in roomSelections)
                    {
                        if (roomSelection.BookingID == bookingID)
                        {
                            roomSelection.BookingStatus = BookingStatusDetails.Cancelled;
                        }
                    }
                    return true;
                }
            }
            return false;
        }
        // method for RooMAvailable for Current User's wish CustomList
        public CustomList<WishList> GetWishListRoomsAvailable(out double totalPrice)
        {
            totalPrice = 0;
            // temp CustomList to store the available rooms
            CustomList<WishList> temp = new CustomList<WishList>();
            foreach (WishList wish in GetCurrentWishList())
            {
                bool flag = true;
                foreach (RoomSelection roomSelection in roomSelections)
                {
                    // cheking the roomID with the wishRoomID
                    if (roomSelection.RoomID == wish.RoomID)
                    {
                        if (wish.FromDate > roomSelection.StayingDateTo)
                        {
                            // cheking if the wishRoom is booked 
                            if (roomSelection.BookingStatus != BookingStatusDetails.Booked)
                            {
                                // cheking dates if it is free or not
                                // problem in date check

                                temp.Add(wish);
                                // adding total price using wish CustomList
                                totalPrice += WishPrice(wish);
                            }
                        }
                        else
                        {
                            // if the room is not available in the selection CustomList then 
                            flag = false;
                        }
                    }
                }
                if (flag)
                {
                    temp.Add(wish);
                    totalPrice += WishPrice(wish);
                }
            }
            return temp;
        }
        // method for One Cart Price
        public double WishPrice(WishList wish)
        {
            double wishPrice = 0;
            TimeSpan span = wish.ToDate - wish.FromDate;
            int days = span.Days;
            foreach (RoomDetails room in rooms)
            {
                if (room.RoomID == wish.RoomID)
                {
                    wishPrice = room.PricePerDay * days;
                }
            }
            return wishPrice;
        }

        // method to deleteWishCustomList
        public bool DeleteWishList(string wishID)
        {
            // creating a duplicate wish CustomList to delete the current wish CustomList
            CustomList<WishList> duplicateWish = new CustomList<WishList>();
            foreach (WishList wish1 in wishLists)
            {
                duplicateWish.Add(wish1);
            }
            foreach (WishList wish in duplicateWish)
            {
                // cheking the wishCustomList id
                if (wish.WishListID == wishID)
                {
                    wishLists.Remove(wish);
                    return true;
                }
            }
            return false;
        }
        // method for Confirm Booking
        public bool ConfirmBooking(out double neededAmount, out string bookingID)
        {
            CustomList<WishList> CustomListToBook = GetWishListRoomsAvailable(out double totalPrice);
            // returning neededAmount
            neededAmount = totalPrice - currentLoggedInUser.WalletBalance;
            bookingID = "";
            if (currentLoggedInUser.WalletBalance >= totalPrice)
            {
                // adding the data to booking details
                BookingDetails booking = new BookingDetails(currentLoggedInUser.UserID, totalPrice, DateTime.Now, BookingStatusDetails.Booked);
                bookings.Add(booking);
                // returning booking id
                bookingID = booking.BookingID;
                // deducting balance after Booking
                currentLoggedInUser.DeductBalance(totalPrice);
                // adding details to selection CustomList
                // for that traversing using wishCustomList
                foreach (WishList wish in CustomListToBook)
                {
                    // to find No of days
                    TimeSpan span = wish.ToDate - wish.FromDate;
                    int days = span.Days;
                    RoomSelection roomSelection = new RoomSelection(wish.WishListID, booking.BookingID, wish.RoomID, wish.FromDate, wish.ToDate, wish.PriceOfRoom, days, BookingStatusDetails.Booked);
                    roomSelections.Add(roomSelection);
                }
                // removing data from the CustomList after booking
                // for that traversing through wishCustomList
                // but we can't remove a data while using a foreach so creating a duplicate CustomList to handle this
                CustomList<WishList> duplicateWish = new CustomList<WishList>();
                foreach (WishList wish1 in wishLists)
                {
                    duplicateWish.Add(wish1);
                }
                foreach (WishList wishCustomList in duplicateWish)
                {
                    foreach (WishList wish in CustomListToBook)
                    {
                        if (wish.WishListID == wishCustomList.WishListID)
                        {
                            wishLists.Remove(wish);
                        }
                    }
                }
                return true;
            }
            return false;
        }

        // method for writeto csv
        public void WrtiteToCsv()
        {
            new FileManager<UserRegistration>().WriteToCsv(users);
            new FileManager<RoomDetails>().WriteToCsv(rooms);
            new FileManager<RoomSelection>().WriteToCsv(roomSelections);
            new FileManager<WishList>().WriteToCsv(wishLists);
            new FileManager<BookingDetails>().WriteToCsv(bookings);
        }

        // method for ReadFromCsv
        public void ReadFromCsv()
        {
            users = new FileManager<UserRegistration>().ReadFromCsv();
            rooms = new FileManager<RoomDetails>().ReadFromCsv();
            roomSelections = new FileManager<RoomSelection>().ReadFromCsv();
            wishLists = new FileManager<WishList>().ReadFromCsv();
            bookings = new FileManager<BookingDetails>().ReadFromCsv();
        }
    }
}