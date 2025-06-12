using System;
using System.Collections.Generic;
using System.IO;

namespace HotelManagement
{
    public class Operations
    {
        public CustomList<UserRegistration> users = new();
        public CustomList<RoomDetails> rooms = new();
        public CustomList<RoomSelection> roomSelections = new();
        public CustomList<WishList> WishLists = new();
        public CustomList<BookingDetails> bookings = new();
        UserRegistration currentLoggedInUser;
        public void AddDefaultData()
        {

            //adding users default Data
            UserRegistration user1 = new UserRegistration("Ravichandran", 995875777, 347777378383, "ravi@gmail.com", "Chennai", FoodTypeDetails.Veg, GenderDetails.Male, 500);
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
            //adding WishList details
            WishList WishList1 = new WishList("SF1001", "RID2001", 750, new DateTime(2024, 11, 12, 9, 0, 0), new DateTime(2024, 11, 13, 9, 0, 0));
            WishList WishList2 = new WishList("SF1001", "RID2002", 700, new DateTime(2024, 11, 12, 6, 0, 0), new DateTime(2024, 11, 13, 12, 30, 0));
            WishList WishList3 = new WishList("SF1002", "RID2001", 750, new DateTime(2025, 2, 27, 9, 0, 0), new DateTime(2025, 2, 28, 10, 0, 0));
            WishList WishList4 = new WishList("SF1001", "RID2001", 750, new DateTime(2025, 3, 3, 10, 0, 0), new DateTime(2025, 3, 4, 11, 0, 0));
            WishLists.AddRange(new CustomList<WishList> { WishList1, WishList2, WishList3, WishList4 });
            //Adding default Booking details
            BookingDetails booking1 = new BookingDetails("SF1001", 1450, new DateTime(2024, 11, 10), BookingStatusDetails.Booked);
            BookingDetails booking2 = new BookingDetails("SF1002", 2000, new DateTime(2024, 11, 10), BookingStatusDetails.Cancelled);
            bookings.AddRange(new CustomList<BookingDetails> { booking1, booking2 });

        }
        public string AddUser(UserRegistration user)
        {
            users.Add(user);
            return user.UserID;
        }
        public void WriteToCSV()
        {
            new FileManager<UserRegistration>().WriteToCSV(users);
            new FileManager<RoomDetails>().WriteToCSV(rooms);
            new FileManager<RoomSelection>().WriteToCSV(roomSelections);
            new FileManager<WishList>().WriteToCSV(WishLists);
            new FileManager<BookingDetails>().WriteToCSV(bookings);
        }
        public void ReadFromCSV()
        {
            users = new FileManager<UserRegistration>().ReadFromCSV();
            rooms = new FileManager<RoomDetails>().ReadFromCSV();
            roomSelections = new FileManager<RoomSelection>().ReadFromCSV();
            WishLists = new FileManager<WishList>().ReadFromCSV();
            bookings = new FileManager<BookingDetails>().ReadFromCSV();
        }

        public bool Login(string userID)
        {
            //Validating user ID
            new SearchUtility<UserRegistration>().BinarySearch(users, userID, "UserID", out UserRegistration element);
            // foreach (UserRegistration user in users)
            // {
            //     if (user.UserID == userID)
            //     {
            //         currentLoggedInUser = user;
            //         return true;
            //     }
            // }
            if (element != null)
            {
                currentLoggedInUser = element;
                return true;
            }
            return false;
        }
        public CustomList<UserRegistration> ViewCustomerProfile()
        {
            CustomList<UserRegistration> user = new CustomList<UserRegistration>();
            foreach (UserRegistration user1 in users)
            {
                if (user1.UserID == currentLoggedInUser.UserID)
                {
                    user.Add(user1);
                }
            }
            return user;
        }
        public double ShowWalletBalance()
        {
            return currentLoggedInUser.WalletBalance;
        }

        public double WalletRecharge(double amount)
        {
            currentLoggedInUser.WalletRecharge(amount);
            return ShowWalletBalance();
        }
        public CustomList<BookingDetails> GetBookingDetails()
        {
            //getting booking details of current user
            CustomList<BookingDetails> currentBooking = new CustomList<BookingDetails>();

            foreach (BookingDetails booking in bookings)
            {
                if (booking.UserID == currentLoggedInUser.UserID)
                {
                    currentBooking.Add(booking);
                }
            }
            return currentBooking;
        }
        public CustomList<RoomSelection> GetRoomDetails(string bookingID)
        {
            //getting room selection details of selected booking ID
            CustomList<RoomSelection> roomDetails = new CustomList<RoomSelection>();

            foreach (RoomSelection roomSelection in roomSelections)
            {
                if (roomSelection.BookingID == bookingID)
                {
                    roomDetails.Add(roomSelection);
                }
            }
            return roomDetails;
        }
        public int CancelBooking(string bookingID)
        {
            //validate the booking id - return 0 - invalid id
            foreach (BookingDetails booking in GetBookingDetails())
            {
                if (booking.BookingID == bookingID)
                {
                    //if valid update booking status as cancelled
                    booking.BookingStatus = BookingStatusDetails.Cancelled;

                    //return total price to the customerr wallet
                    currentLoggedInUser.WalletRecharge(booking.TotalPrice);

                    //traverse room selection CustomList & update status as cancelled by checking booking id
                    foreach (RoomSelection roomSelection in roomSelections)
                    {
                        if (roomSelection.BookingID == bookingID)
                        {
                            roomSelection.BookingStatus = BookingStatusDetails.Cancelled;
                            //return 1 - show “Booking Cancelled Successfully”.
                            return 1;
                        }
                    }
                }
            }
            return 0;
        }
        public CustomList<RoomDetails> GetRoomDetails()
        {
            //Traverse the RoomCustomList and show available rooms by comparing RoomID with room selection CustomList
            // checking it is in not “Booked” state
            // CustomList<RoomDetails> roomDetails=new CustomList<RoomDetails>();

            // foreach(RoomDetails room in rooms)
            // {
            //     foreach(RoomSelection roomSelection in roomSelections)
            //     {
            //         if(room.RoomID==roomSelection.RoomID && roomSelection.BookingStatus!=BookingStatusDetails.Booked)
            //         {
            //             roomDetails.Add(room);
            //         }
            //     }
            // }
            return rooms;
        }
        public int AddToWishList(string roomID, DateTime fromDate, DateTime toDate)
        {
            //get room id from user to add WishList
            //validate room id - return 0 - Room is already Booked
            foreach (RoomDetails room in GetRoomDetails())
            {
                foreach (RoomSelection roomSelection in roomSelections)
                {
                    if (roomID == roomSelection.RoomID)
                    {
                        if (roomSelection.BookingStatus != BookingStatusDetails.Booked || roomSelection.StayingDateTo < fromDate)
                        {
                            //add to wish CustomList
                            TimeSpan days = toDate - fromDate;
                            double day = days.TotalDays;
                            WishList WishList = new WishList(currentLoggedInUser.UserID, roomID, day * room.PricePerDay, fromDate, toDate);
                            WishLists.Add(WishList);
                            return 1;
                        }
                    }
                }
                return 0;
            }
            return 2;
            //if valid - check room availablility,room id,from date,to date,& booking status by traversing room selection CustomList 
            //if valid - create WishList obj - UserID, RoomID, PriceOfRoom, FromDate, ToDate for the selected room
            //add it to wish CustomList - return 1 - Booking Successfully added to WishList
            //Ask the customer if they wish to add another room to their cart
            //if yes - repeat the process
            //if no - exit
        }
        public CustomList<WishList> GetWishLists()
        {
            //get wishes of current user
            CustomList<WishList> wishes = new CustomList<WishList>();

            foreach (WishList wish in WishLists)
            {
                if (wish.UserID == currentLoggedInUser.UserID)
                {
                    wishes.Add(wish);
                }
            }
            return wishes;
        }
        public CustomList<RoomSelection> GetRoomSelections()
        {
            return roomSelections;
        }
        public int DeleteWishList(string WishListID)
        {
            //Validate if the WishListID is valid or not by traversing the WishList
            foreach (WishList WishList in WishLists)
            {
                if (WishList.WishListID == WishListID)
                {
                    //if valid - remove from CustomList - return 1 - Selected room is deleted from WishList successfully
                    WishLists.Remove(WishList);
                    return 1;
                }
            }
            //if invalid - return 0 - Invalid WishListID
            return 0;
        }
        public int ConfirmBooking(out CustomList<string> data, out string booking1ID)
        {
            data = default(CustomList<string>);
            booking1ID = default(string);
            //create string CustomList to store WishList id
            CustomList<string> store = new CustomList<string>();
            //traverse WishList & room selection - check room availability(from date,to date,booking status)
            foreach (WishList wish in GetWishLists())
            {
                foreach (RoomSelection selection in roomSelections)
                {
                    if (selection.RoomID == wish.RoomID)
                    {
                        if (selection.BookingStatus == BookingStatusDetails.Booked)
                        {
                            //
                            if (selection.StayingDateTo < wish.FromDate)
                            {
                                //continue booking
                                store.Add(wish.WishListID);
                            }
                        }
                        else
                        {
                            //continue booking
                            store.Add(wish.WishListID);
                        }
                    }
                }
            }
            if (store.Count > 0)
            {
                //find total amount to book available rooms (WishList id in string CustomList)
                double totalPrice = GetTotalPrice(store, out CustomList<WishList> finalCustomList);

                //compare total price & user wallet balance
                if (currentLoggedInUser.WalletBalance >= totalPrice)
                {
                    //continue booking
                    ContinueBooking(totalPrice, finalCustomList, store, out string bookingID);
                    booking1ID = bookingID;
                    return 2;
                }
                //return 0 - Insufficient balance to book your rooms. Needed amount to book your rooms is ______
                data = store;
                return 1;

            }
            return 0;
        }
        public void ContinueBooking(double totalPrice, CustomList<WishList> finalCustomList, CustomList<string> store, out string bookingID)
        {
            //deduct total price from user wallet
            currentLoggedInUser.DeductBalance(totalPrice);

            //create booking object (bookinID,CustomerID, TotalPrice, DateOfBooking as now, BookingStatus as “Booked”)
            BookingDetails booking = new BookingDetails(currentLoggedInUser.UserID, totalPrice, DateTime.Now, BookingStatusDetails.Booked);
            //traverse WishList - check room availability
            foreach (WishList wish in finalCustomList)
            {
                TimeSpan days = wish.ToDate - wish.FromDate;
                double day = days.TotalDays;

                //create roomselection object & add to CustomList
                RoomSelection selection = new RoomSelection(wish.WishListID, booking.BookingID, wish.RoomID, wish.FromDate, wish.ToDate, totalPrice, day, BookingStatusDetails.Booked);
                roomSelections.Add(selection);
            }

            //remove booked rooms from WishList by using string CustomList
            int count = 0;
            foreach (string id in store)
            {
                foreach (WishList wish in WishLists)
                {
                    if (id == wish.WishListID)
                    {
                        count++;
                        WishLists.Remove(wish);
                        if (store.Count == count)
                        {
                            break;
                        }
                    }
                }
            }
            bookingID = booking.BookingID;
            bookings.Add(booking);
            //add booking object to booking CustomList
        }

        public double GetTotalPrice(CustomList<string> store, out CustomList<WishList> finalCustomList)
        {
            double totalPrice = 0;
            CustomList<WishList> CustomList = new CustomList<WishList>();
            foreach (WishList wish in GetWishLists())
            {
                foreach (string id in store)
                {
                    if (id == wish.WishListID)
                    {
                        totalPrice += wish.PriceOfRoom;
                        CustomList.Add(wish);
                    }
                }
            }
            finalCustomList = CustomList;
            return totalPrice;
        }

    }
}