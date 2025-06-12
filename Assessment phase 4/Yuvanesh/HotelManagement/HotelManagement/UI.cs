using System;
using System.Collections.Generic;
namespace HotelManagement
{
    public class UI
    {
        Operations operations = new Operations();
        public void Mainmenu()
        {
            // operations.AddDefaultData();
            operations.ReadFromCsv();
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
            operations.WrtiteToCsv();
        }

        public void Registration()
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
            Console.WriteLine("Enter your Food Type Veg/Non veg");
            FoodTypeDetails foodType = Enum.Parse<FoodTypeDetails>(Console.ReadLine(), true);
            Console.WriteLine("Enter your Gender ");
            GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(), true);
            Console.WriteLine("Enter your Wallet Balance");
            double balance = Convert.ToDouble(Console.ReadLine());
            //On completion of the user registration, we need to display the “Registration successful” then show you UserID (auto-generated UserID).
            UserRegistration user = new UserRegistration(userName, mobile, aadhar, mailID, address, foodType, gender, balance);
            Console.WriteLine($"Registration Successfull Your Registration ID is {operations.AddUser(user)}");
        }
        public void Login()
        {
            //Ask and get the “UserID” from the user. Check the “UserID” in the users list.
            Console.WriteLine("Welcome to Login Page");
            Console.WriteLine("Enter your userID");
            string userID = Console.ReadLine().ToUpper();
            if (operations.Login(userID))
            {
                System.Console.WriteLine("Yay! You Logged In😊");
                Submenu();
            }
            else
            {
                System.Console.WriteLine("Invalid User ID");
            }
        }
        public void Submenu()
        {
            Console.WriteLine("******Submenu Page********");

            int submenuOption;
            do
            {
                Console.WriteLine("Enter one option");
                Console.WriteLine("1.ViewCustomerProfile\n2.AddToWishList\n3.BookRoom\n4.CancelBooking\n5.BookingHistory\n6.WalletRecharge\n7.ShowWalletBalance\n8.Show Wish List\n9.Exit ");
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
                            ShowWishList();
                            break;
                        }
                    case 9:
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
            } while (submenuOption != 9);
        }
        public void ViewCustomerProfile()
        {
            new Grid<UserRegistration>().Display([operations.GetUserProfile()]);
        }
        public void AddToWishList()
        {
            // flag to break the loop
            bool flag = true;
            do
            {
                // getting FromDate from the user
                System.Console.WriteLine("Enter the Start Date and time for the Room");
                DateTime fromDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm tt", null);
                // getting ToDate from the user
                System.Console.WriteLine("Enter the End Date and time for the Room");
                DateTime toDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm tt", null);
                // cheking wheter the given date is valid or not
                if (fromDate > toDate)
                {
                    System.Console.WriteLine("Your date is Invalid, Enter Valid Date Mate");
                    break;
                }
                CustomList<RoomDetails> availableRooms = operations.GetEmptyRoomList();
                new Grid<RoomDetails>().Display(availableRooms);
                // cheking if the room is empyty or not
                if (availableRooms.Count != 0)
                {
                    string option = "";
                    // getting RoomID from the user
                    System.Console.WriteLine("Enter the RoomID to ADD in wishlist");
                    string roomID = Console.ReadLine().ToUpper();
                    switch (operations.AddToWishList(roomID, fromDate, toDate))
                    {
                        case 0:
                            {
                                System.Console.WriteLine("Invalid Room ID");
                                flag = false;
                                break;
                            }
                        case 1:
                            {
                                System.Console.WriteLine("Room Already Booked");
                                flag = false;
                                break;
                            }
                        case 2:
                            {
                                System.Console.WriteLine("Booking Successfully Added to Wishlist");
                                // asking user to add another cart
                                System.Console.WriteLine("Do You Wish to add Another room Y/N");
                                option = Console.ReadLine().ToUpper();
                                break;
                            }
                    }
                    // breaking the loop if No
                    if (option == "N")
                    {
                        break;
                    }
                }
                else
                {
                    System.Console.WriteLine("There is No Available Rooms😢");
                }


            } while (flag);

        }
        public void BookRoom()
        {
            CustomList<WishList> currentWish = operations.GetCurrentWishList();
            CustomList<RoomSelection> roomSelections = operations.GetRoomSelectionList();
            if (currentWish.Count != 0)
            {
                foreach (WishList wish in currentWish)
                {
                    bool flag = true;
                    foreach (WishList wish1 in operations.GetWishListRoomsAvailable(out double totalPrice))
                    {
                        if (wish1.WishListID == wish.WishListID)
                        {
                            System.Console.WriteLine($"{wish1.WishListID,10} | {wish1.RoomID,10} | {wish1.FromDate.ToString("dd/MM/yyyy"),-10} | {wish1.ToDate.ToString("dd/MM/yyyy"),-10} | {wish1.PriceOfRoom} Available");
                            flag = false;
                        }
                    }
                    if (flag)
                    {
                        System.Console.WriteLine($"{wish.WishListID,10} | {wish.RoomID,10} | {wish.FromDate.ToString("dd/MM/yyyy"),-10} | {wish.ToDate.ToString("dd/MM/yyyy"),-10} | {wish.PriceOfRoom} Booked");
                    }
                }
                RoomBookingMenu();
            }
            else
            {
                System.Console.WriteLine("No Wish List Found");
            }

        }

        public void RoomBookingMenu()
        {
            int mainMenuOption;
            do
            {
                Console.WriteLine("Enter one option");
                Console.WriteLine("1.ConfirmBooking\n2.DeleteWishList\n3.Exit");
                mainMenuOption = int.Parse(Console.ReadLine());
                switch (mainMenuOption)
                {
                    case 1:
                        {
                            ConfirmBooking();
                            break;
                        }
                    case 2:
                        {
                            DeleteWishList();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Exiting from BookingOptions/........");
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

        public void CancelBooking()
        {
            CustomList<BookingDetails> bookedList = operations.GetBookedBookingHistory();
            if (bookedList.Count != 0)
            {
                // Printing the Booked History in booking list to cancel
                new Grid<BookingDetails>().Display(bookedList);
                // getting booking id from the user
                System.Console.WriteLine("Enter the Booking ID to cancel");
                string bookingID = Console.ReadLine();
                if (operations.CancelBooking(bookingID))
                {
                    System.Console.WriteLine("Booking Cancelled Successfully");
                }
                else
                {
                    System.Console.WriteLine("Invalid Booking ID");
                }
            }
            else
            {
                System.Console.WriteLine("No Booking Details Found to Cancel");
            }


        }
        public void ShowWalletBalance()
        {
            System.Console.WriteLine($"Your Wallet Balance is {operations.GetWalletBalance()}");
        }

        public void BookingHistory()
        {
            // getting current users BookingHistory
            CustomList<BookingDetails> currentBooking = operations.GetBookingHistory();
            if (currentBooking.Count != 0)
            {
                new Grid<BookingDetails>().Display(currentBooking);
            }
            else
            {
                System.Console.WriteLine("No Booking History Found");
            }
        }

        public void WalletRecharge()
        {
            // getting amount from the user for Recharge
            System.Console.WriteLine("Enter the Amount to Recharge");
            double amount = Convert.ToDouble(Console.ReadLine());
            operations.DoWalletRecharge(amount);
            System.Console.WriteLine("Recharge Successfull");
            ShowWalletBalance();
        }
        // method to showWishList
        public void ShowWishList()
        {
            new Grid<WishList>().Display(operations.GetCurrentWishList());
        }
        // method for DeleteWishList
        public void DeleteWishList()
        {
            CustomList<WishList> currentWish = operations.GetCurrentWishList();
            if (currentWish.Count != 0)
            {
                // showing the wishlist to the user
                new Grid<WishList>().Display(currentWish);
                // getting wishlist id to delete
                System.Console.WriteLine("Enter WishList ID to delete");
                string wishListID = Console.ReadLine();
                if (operations.DeleteWishList(wishListID))
                {
                    System.Console.WriteLine("Selected Room is Deleted from wishlist Successfully");
                }
                else
                {
                    System.Console.WriteLine("Invalid WishListID");
                }
            }
            else
            {
                System.Console.WriteLine("No WishList found to Delete");
            }
        }
        // method for confirm Booking
        public void ConfirmBooking()
        {
            if (operations.GetWishListRoomsAvailable(out double totalprice).Count != 0)
            {
                // flag to break the loop
                bool flag = true;
                do
                {
                    if (operations.ConfirmBooking(out double neededAmount, out string bookingID))
                    {
                        System.Console.WriteLine($"Booking Successfull, Your ID is {bookingID}");
                        flag = false;
                    }
                    else
                    {
                        System.Console.WriteLine($"Insufficient Balance You need {neededAmount} to Purchase");
                        // getting user to wallet recharge
                        System.Console.WriteLine("Do You Wish to Recharge Your Wallet Y/N");
                        string option = Console.ReadLine().ToUpper();
                        if (option == "N")
                        {
                            break;
                        }
                        WalletRecharge();
                    }
                } while (flag);
            }
            else
            {
                System.Console.WriteLine("There is No wishList to Purchase");
            }
        }
    }
}