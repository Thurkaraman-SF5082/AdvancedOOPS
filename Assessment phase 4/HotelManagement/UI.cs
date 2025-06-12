using System;
using System.Collections.Generic;
namespace HotelManagement
{
    public class UI
    {
        Operations operations = new Operations();
        public void Mainmenu()
        {
            try
            {//operations.AddDefaultData();
                operations.ReadFromCSV();
                Console.WriteLine(" Welcome to SyncHotel");

                int mainMenuOption;
                do
                {
                    Console.WriteLine("Enter one option");
                    Console.WriteLine("1.UserRegistration\n2.User Login\n3.Exit");
                    mainMenuOption = int.Parse(Console.ReadLine());
                    switch (mainMenuOption)
                    {
                        case 1:
                            {
                                Registration();
                                break;
                            }
                        case 2:
                            {
                                Login();
                                break;
                            }
                        case 3:
                            {
                                operations.WriteToCSV();
                                Console.WriteLine("Exiting from Application/........");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid Option!!");
                                break;
                            }
                    }
                } while (mainMenuOption != 3);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                System.Console.WriteLine(e.Message);
                System.Console.WriteLine("Enter appropriate number to choose options");
            }
        }

        public void Registration()
        {
            try
            {
                Console.WriteLine("Enter your Name");
                string userName = Console.ReadLine();
                Console.WriteLine("Enter your Mobile Number");
                long mobile = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter your Aaadhar Number");
                long aadhar = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter your Mail ID");
                string mailID = Console.ReadLine();
                Console.WriteLine("Enter your Address");
                string address = Console.ReadLine();
                Console.WriteLine("Enter your Food Type Veg/NonVeg");
                FoodTypeDetails foodType = Enum.Parse<FoodTypeDetails>(Console.ReadLine(), true);
                Console.WriteLine("Enter your Gender ");
                GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(), true);
                Console.WriteLine("Enter your Wallet Balance");
                double balance = Convert.ToDouble(Console.ReadLine());

                //On completion of the user registration, we need to display the “Registration successful” then show you UserID (auto-generated UserID).
                UserRegistration user = new UserRegistration(userName, mobile, aadhar, mailID, address, foodType, gender, balance);
                Console.WriteLine($"Registration Successfull Your Registration ID is {operations.AddUser(user)}");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                System.Console.WriteLine(e.Message);
                System.Console.WriteLine("Enter input in a valid format");
            }
        }
        public void Login()
        {
            //Ask and get the “UserID” from the user. Check the “UserID” in the users CustomList.
            Console.WriteLine("Welcome to Login Page");
            Console.WriteLine("Enter your userID");
            string userID = Console.ReadLine().ToUpper();

            if (operations.Login(userID))
            {
                System.Console.WriteLine("Login successful");
                Submenu();
            }
            else
            {
                System.Console.WriteLine("Invalid user ID");
            }
        }
        public void Submenu()
        {
            try
            {
                Console.WriteLine("******Submenu Page********");

                int submenuOption;
                do
                {
                    Console.WriteLine("Enter one option");
                    Console.WriteLine("1.ViewCustomerProfile\n2.AddToWishList\n3.BookRoom\n4.CancelBooking\n5.BookingHistory\n6.WalletRecharge\n7.ShowWalletBalance\n8.Exit ");
                    submenuOption = int.Parse(Console.ReadLine());
                    switch (submenuOption)
                    {
                        case 1:
                            {
                                ViewCustomerProfile();
                                break;
                            }
                        case 2:
                            {
                                AddToWishList();
                                break;
                            }
                        case 3:
                            {
                                BookRoom();
                                break;
                            }
                        case 4:
                            {
                                CancelBooking();
                                break;
                            }
                        case 5:
                            {
                                BookingHistory();
                                break;
                            }
                        case 6:
                            {
                                WalletRecharge();
                                break;
                            }
                        case 7:
                            {
                                ShowWalletBalance();
                                break;
                            }
                        case 8:
                            {
                                Console.WriteLine("Exiting to Main Menu");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid Option");
                                break;
                            }
                    }
                } while (submenuOption != 8);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                System.Console.WriteLine(e.Message);
                System.Console.WriteLine("Enter appropriate number to choose options");
            }
        }
        public void ViewCustomerProfile()
        {
            //Display user details
            new Gridview<UserRegistration>().DisplayDetails(operations.ViewCustomerProfile());
            // foreach (UserRegistration user in operations.ViewCustomerProfile())
            // {
            //     System.Console.WriteLine($"{user.UserID} {user.Mobile} {user.AadharNumber} {user.Email} {user.Address} {user.FoodType} {user.Gender} {user.WalletBalance}");
            // }

        }
        public void AddToWishList()
        {
            try
            {
                string wish = "";
                do
                {
                    //Ask and get the FromDate and ToDate with Time from the user.
                    System.Console.WriteLine("Enter date and time of login : 'dd/MM/yyyy HH:mm:ss'");
                    DateTime fromDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm:ss", null);

                    System.Console.WriteLine("Enter date and time of log out : 'dd/MM/yyyy HH:mm:ss'");
                    DateTime toDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm:ss", null);

                    //Traverse the RoomCustomList and show available rooms by comparing RoomID with room selection CustomList ,checking it is in not “Booked” state 
                    new Gridview<RoomDetails>().DisplayDetails(operations.GetRoomDetails());
                    // foreach (RoomDetails room in operations.GetRoomDetails())
                    // {
                    //     System.Console.WriteLine($"{room.RoomID} {room.RoomType} {room.NumberOfBeds} {room.PricePerDay}");
                    // }
                    //get room id from user to add WishList
                    System.Console.WriteLine("Enter room ID to WishList :");
                    string roomID = Console.ReadLine().ToUpper();

                    switch (operations.AddToWishList(roomID, fromDate, toDate))
                    {
                        case 0:
                            {
                                System.Console.WriteLine("Room is already Booked");
                                break;
                            }
                        case 1:
                            {
                                System.Console.WriteLine("Booking Successfully added to WishList");
                                break;
                            }
                        case 2:
                            {
                                System.Console.WriteLine("Invalid RoomID");
                                break;
                            }
                    }
                    System.Console.WriteLine("Do you wish to add another room :");
                    wish = Console.ReadLine().ToUpper();
                } while (wish == "YES");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                System.Console.WriteLine(e.Message);
                System.Console.WriteLine("Enter date time in valid format 'dd/MM/yyyy HH:mm:ss'");
            }
        }
        public void BookRoom()
        {
            try
            {
                CustomList<WishList> wishes = operations.GetWishLists();
                foreach (WishList wish in wishes)
                {
                    foreach (RoomSelection selection in operations.GetRoomSelections())
                    {
                        if (wish.WishListID == selection.WishListID)
                        {
                            if (selection.BookingStatus != BookingStatusDetails.Booked)
                            {
                                //Available
                                System.Console.WriteLine($"{wish.WishListID,-15} |{wish.UserID,-15} |{wish.RoomID,-15} |{wish.FromDate,-15} |{wish.ToDate,-15} |{wish.PriceOfRoom,-15} |Available");
                            }
                            else if (wish.FromDate > selection.StayingDateTo)
                            {
                                //Available
                                System.Console.WriteLine($"{wish.WishListID,-15} |{wish.UserID,-15} |{wish.RoomID,-15} |{wish.FromDate,-15} |{wish.ToDate,-15} |{wish.PriceOfRoom,-15} |Available");
                            }
                            else
                            {
                                //Booked
                                System.Console.WriteLine($"{wish.WishListID,-15} |{wish.UserID,-15} |{wish.RoomID,-15} |{wish.FromDate,-15} |{wish.ToDate,-15} |{wish.PriceOfRoom,-15} |Booked");
                            }
                        }
                    }
                }

                int option;
                do
                {

                    //ask user to navigate which section
                    System.Console.WriteLine("1. ConfirmBooking\n2. DeleteWishList\n3. Exit\nEnter option :");
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            {
                                //ConfirmBooking
                                if (wishes.Count > 0)
                                {
                                    ConfirmBooking();
                                }
                                else
                                {
                                    System.Console.WriteLine("There is no wish CustomList to proceed");
                                }
                                break;
                            }
                        case 2:
                            {
                                //DeleteWishList
                                if (wishes.Count > 0)
                                {
                                    DeleteWishList();
                                }
                                else
                                {
                                    System.Console.WriteLine("There is no wish CustomList to proceed");
                                }
                                break;
                            }
                        case 3:
                            {
                                //Exit
                                break;
                            }
                        default:
                            {
                                System.Console.WriteLine("Enter valid input");
                                break;
                            }
                    }

                } while (option != 3);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                System.Console.WriteLine(e.Message);
                System.Console.WriteLine("Enter input in a valid format");
            }
        }
        public void ConfirmBooking()
        {
            //create string CustomList to store WishList id
            //traverse WishList & room selection - check room availability(from date,to date,booking status)
            //find total amount to book available rooms (WishList id in string CustomList)
            //compare total price & user wallet balance
            //return 0 - Insufficient balance to book your rooms. Needed amount to book your rooms is ______
            //ask user wish to recharge
            //if yes - ask amount and recharge 
            //compare total price & user wallet balance
            //if not enough repeat the process
            //deduct total price from user wallet
            //create booking object (bookinID,CustomerID, TotalPrice, DateOfBooking as now, BookingStatus as “Booked”)
            //traverse WishList - check room availability
            //create roomselection object & add to CustomList
            //remove booked rooms from WishList by using string CustomList
            //add booking object to booking CustomList - return 1 -  show “Booking Successful. Your BookingID is _____
            switch (operations.ConfirmBooking(out CustomList<string> store, out string bookingID))
            {
                case 0:
                    {
                        System.Console.WriteLine("No rooms are available to book in the WishList");
                        break;
                    }
                case 1:
                    {
                        string wish = "";
                        double balance;
                        double totalPrice = operations.GetTotalPrice(store, out CustomList<WishList> finalCustomList);
                        //ask user to recharge untill wallet balance is enough to book rooms if they wish
                        do
                        {
                            balance = operations.ShowWalletBalance();
                            System.Console.WriteLine($"Insufficient balance to book your rooms. Needed amount to book your rooms is {totalPrice - balance}");
                            System.Console.WriteLine("Do you wish to recharge :");
                            wish = Console.ReadLine().ToUpper();
                            if (wish == "YES")
                            {
                                WalletRecharge();
                                if (totalPrice <= operations.ShowWalletBalance())
                                {
                                    operations.ContinueBooking(totalPrice, finalCustomList, store, out string booking1ID);
                                    System.Console.WriteLine($"Booking Successful. Your BookingID is {booking1ID}");
                                    wish = "NO";
                                }
                            }
                        } while (wish == "YES");

                        break;
                    }
                case 2:
                    {
                        System.Console.WriteLine($"Booking Successful. Your BookingID is {bookingID}");
                        break;
                    }
            }
        }
        public void DeleteWishList()
        {
            //Show all the WishListItems of the current customer.
            new Gridview<WishList>().DisplayDetails(operations.GetWishLists());
            // foreach (WishList wish in operations.GetWishLists())
            // {
            //     System.Console.WriteLine($"{wish.WishListID,-15} |{wish.UserID,-15} |{wish.RoomID,-15} |{wish.FromDate,-15} |{wish.ToDate,-15} |{wish.PriceOfRoom,-15}");
            // }

            //Ask the customer to select one WishListID to delete
            System.Console.WriteLine("Enter WishList ID to delete :");
            string WishListID = Console.ReadLine().ToUpper();

            switch (operations.DeleteWishList(WishListID))
            {
                case 0:
                    {
                        System.Console.WriteLine("Invalid WishListID");
                        break;
                    }
                case 1:
                    {
                        System.Console.WriteLine("Selected room is deleted from WishList successfully");
                        break;
                    }
            }
        }

        public void CancelBooking()
        {
            //Show the current customer’s booking details by traversing the bookings CustomList whose BookingStatus is booked.
            int count = 0;

            foreach (BookingDetails booking in operations.GetBookingDetails())
            {
                if (booking.BookingStatus == BookingStatusDetails.Booked)
                {
                    count++;
                    System.Console.WriteLine($"|{booking.BookingID,15} |{booking.UserID,15} |{booking.BookingStatus,15} |{booking.DateOfBooking.ToString("dd/MM/yyyy"),15} |{booking.TotalPrice,15}");
                }
            }

            if (count > 0)
            {
                //Ask the customer to choose one BookingID to cancel
                System.Console.WriteLine("Choose one booking ID to cancel :");
                string bookingID = Console.ReadLine().ToUpper();

                switch (operations.CancelBooking(bookingID))
                {
                    case 0:
                        {
                            System.Console.WriteLine("Invalid Booking ID");
                            break;
                        }
                    case 1:
                        {
                            System.Console.WriteLine("Booking Cancelled Successfully");
                            break;
                        }
                }
            }
            else
            {
                System.Console.WriteLine("There is no booking details to cancel");
            }
        }
        public void ShowWalletBalance()
        {
            System.Console.WriteLine($"Your Wallet balance is {operations.ShowWalletBalance()}");
        }

        public void BookingHistory()
        {
            //Show the current customer’s booking history by traversing the bookingsCustomList
            CustomList<BookingDetails> booking = operations.GetBookingDetails();
            if (booking.Count > 0)
            {
                new Gridview<BookingDetails>().DisplayDetails(booking);
                // foreach (BookingDetails details in booking)
                // {
                //     System.Console.WriteLine($"{details.BookingID} {details.UserID} {details.BookingStatus} {details.DateOfBooking.ToString("dd/MM/yyyy")} {details.TotalPrice}");
                // }
                //Ask the customer to choose a BookingID
                System.Console.WriteLine("Please choose a booking ID :");
                string bookingID = Console.ReadLine().ToUpper();

                //getting room selection details of selected booking ID
                CustomList<RoomSelection> roomSelections = operations.GetRoomDetails(bookingID);
                if (roomSelections.Count > 0)
                {
                    new Gridview<RoomSelection>().DisplayDetails(roomSelections);
                    // foreach (RoomSelection room in roomSelections)
                    // {
                    //     System.Console.WriteLine($"{room.SelectionID} {room.RoomID} {room.BookingID} {room.WishListID} {room.BookingStatus} {room.StayingDateFrom.ToString("dd/MM/yyyy")} {room.StayingDateTo.ToString("dd/MM/yyyy")} {room.NumberOfDays} {room.Price}");
                    // }
                }
                else
                {
                    System.Console.WriteLine("Invalid booking ID");
                }
            }
            else
            {
                System.Console.WriteLine("Details not found. You haven't booked any room.");
            }
        }

        public void WalletRecharge()
        {
            //ask and get amount from user
            System.Console.WriteLine("Enter amount to be recharged :");
            double amount = double.Parse(Console.ReadLine());

            System.Console.WriteLine($"Your current balance is {operations.WalletRecharge(amount)}");
        }
    }
}