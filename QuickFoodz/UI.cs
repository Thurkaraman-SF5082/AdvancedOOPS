using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickFoodz
{
    public class UI
    {
        Operation operation = new Operation();

        public void MainMenu()
        {
            //operation.DefaultData();
            operation.ReadFromCSV();
            bool flag = true;

            do
            {
                System.Console.WriteLine("1. CustomerRegistration\n2. CustomerLogin\n3. Exit\nEnter option :");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            //CustomerRegistration
                            CustomerRegistration();
                            break;
                        }
                    case 2:
                        {
                            //CustomerLogin
                            CustomerLogin();
                            break;
                        }
                    case 3:
                        {
                            //Exit
                            operation.WriteToCSV();
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }

        public void CustomerRegistration()
        {
            /*1.	Need to get the below details from the customer for the customer registration. 
            •	CustomerName 
            •	FatherName
            •	Gender 
            •	MobileNumber 
            •	DateOfBirth
            •	MailID 
            •	WalletBalance 
            2.	On completion of the customer registration, you need to display the CustomerID (auto generated CustomerID) and add the customer details to the customers CustomList. 
            */
            System.Console.WriteLine("Enter your Name:");
            string customerName = Console.ReadLine();
            System.Console.WriteLine("Enter your Father Name:");
            string fatherName = Console.ReadLine();
            System.Console.WriteLine("Enter your Gender:");
            GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(), true);
            System.Console.WriteLine("Enter your mobile number:");
            string mobileNumber = Console.ReadLine();
            System.Console.WriteLine("Enter yopu dob:");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            System.Console.WriteLine("Enter your mail ID:");
            string mailID = Console.ReadLine();
            System.Console.WriteLine("Enter your wallet balance:");
            double walletBalance = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your location :");
            string location=Console.ReadLine();

            CustomerDetails customer = new CustomerDetails(customerName, fatherName, gender, mobileNumber, dob, mailID,location, walletBalance);

            System.Console.WriteLine($"Registration successful. Your customer ID is {operation.AddUser(customer)}");
        }
        public void CustomerLogin()
        {
            /*1.	Ask and get the “CustomerID” of the customer and check if the 'CustomerID' exists in the customers CustomList. 
            2.	If the “CustomerID” does not exist, then show “Invalid Customer ID”. 
            3.	If “CustomerID” exists, then show the sub menu given below. 
            */

            System.Console.WriteLine("Enter your customer ID :");
            string customerID = Console.ReadLine().ToUpper();

            if (operation.CheckCustomer(customerID))
            {
                System.Console.WriteLine("Login successful");
                SubMenu();
            }
            else
            {
                System.Console.WriteLine("Invalid Customer ID");
            }
        }
        public void SubMenu()
        {
            /*a.	ShowCustomerDetails 
            b.	ShowFoodDetails 
            c.	WalletRecharge 
            d.	AddToCart
            e.	FoodOrder
            f.	CancelBooking
            g.	BookingHistory 
            h.	ShowBalance 
            i.	Exit 
            */
            bool flag = true;

            do
            {
                System.Console.WriteLine("1. ShowCustomerDetails\n2. ShowFoodDetails\n3. WalletRecharge\n4. AddToCart\n5. FoodOrder\n6. CancelBooking\n7. BookingHistory\n8. ShowBalance\n9. Exit\nEnter option :");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            //ShowCustomerDetails
                            ShowCustomerDetails();
                            break;
                        }
                    case 2:
                        {
                            //ShowFoodDetails
                            ShowFoodDetails();
                            break;
                        }
                    case 3:
                        {
                            //WalletRecharge
                            WalletRecharge();
                            break;
                        }
                    case 4:
                        {
                            //AddToCart
                            AddToCart();
                            break;
                        }
                    case 5:
                        {
                            //Purchase
                            FoodOrder();
                            break;
                        }
                    case 6:
                        {
                            //CancelBooking
                            CancelBooking();
                            break;
                        }
                    case 7:
                        {
                            //BookingHistory
                            BookingHistory();
                            break;
                        }
                    case 8:
                        {
                            //ShowBalance
                            ShowBalance();
                            break;
                        }
                    case 9:
                        {
                            //exit
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }
        public void ShowCustomerDetails()
        {
            foreach (CustomerDetails customer in operation.ShowCustomerDetails())
            {
                System.Console.WriteLine($"{customer.CustomerID,-15} |{customer.CustomerName,-15} |{customer.FatherName,-15} |{customer.Gender,-15} |{customer.DOB,-15} |{customer.MobileNumber,-15} |{customer.MailID,-15} |{customer.WalletBalance,-15}");
            }

        }
        public void ShowFoodDetails()
        {
            new GridView<FoodDetails>().DisplayDetails(operation.ShowFoodDetails());
            // foreach (FoodDetails food in operation.ShowFoodDetails())
            // {
            //     System.Console.WriteLine($"{food.FoodID,-15} |{food.FoodName,-15} |{food.QuantityAvailable,-15} |{food.PricePerQuantity,-15}");
            // }
        }

        public string WalletRecharge()
        {
            System.Console.WriteLine("Do you wish to recharge :");
            string wish = Console.ReadLine().ToUpper();
            if (wish == "YES")
            {
                System.Console.WriteLine("Enter amount to be recharged :");
                int amount = int.Parse(Console.ReadLine());
                operation.WalletRecharge(amount);
                return wish;
            }
            else
            {
                return wish;
            }
        }
        public void ShowBalance()
        {
            System.Console.WriteLine($"Your balance is {operation.ShowBalance()}");
        }
        public void BookingHistory()
        {
            /*1.	Show the current customer’s booking history by traversing the bookingsCustomList.
            2.	Ask the customer to choose a BookingID. If the BookingID is not valid, then show “Invalid BookingID” and show Sub Menu Options.
            3.	If the BookingID is valid, then show the chosen booking’s purchased details. After that show the Sub Menu Options.
            */
            CustomList<BookingDetails> historyCheck = operation.BookingHistory();

            if (historyCheck.Count > 0)
            {
                int count = 0;
                foreach (BookingDetails booking in historyCheck)
                {
                    System.Console.WriteLine($"{booking.BookID,-15} |{booking.CustomerID,-15} |{booking.TotalPrice,-15} |{booking.DateOfOrder.ToString("dd/MM/yyyy"),-15} |{booking.BookingStatus,-15}");
                }

                System.Console.WriteLine("Choose a Booking ID :");
                string bookingID = Console.ReadLine().ToUpper();


                foreach (PurchasedItems purchasedItems in operation.GetPurchasedItems())
                {
                    if (purchasedItems.BookingID == bookingID)
                    {
                        count++;
                        System.Console.WriteLine($"{purchasedItems.ItemID,-15} |{purchasedItems.CartID,-15} |{purchasedItems.BookingID,-15} |{purchasedItems.FoodID,-15} |{purchasedItems.PurchaseCount,-15} |{purchasedItems.PriceOfPurchase,-15}");
                    }
                }
                if (count == 0)
                {
                    System.Console.WriteLine("Invalid BookingID");
                }
            }
            else
            {
                System.Console.WriteLine("There is no booking history");
            }

        }
        public void CancelBooking()
        {
            //display booking details of current customer
            //get book id to cancel
            //check for book id - return 0 show “Invalid BookingID”
            //update book status as cancelled
            //return totalprice to wallet balance
            //return purchase count to food details count
            CustomList<BookingDetails> historyCheck = operation.BookingHistory();

            if (historyCheck.Count > 0)
            {
                foreach (BookingDetails booking in operation.BookingHistory())
                {
                    System.Console.WriteLine($"{booking.BookID,-15} |{booking.CustomerID,-15} |{booking.TotalPrice,-15} |{booking.DateOfOrder.ToString("dd/MM/yyyy"),-15} |{booking.BookingStatus,-15}");
                }
                System.Console.WriteLine("Choose a Booking ID to cancel:");
                string bookingID = Console.ReadLine().ToUpper();

                switch (operation.CancelBooking(bookingID))
                {
                    case 0:
                        {
                            System.Console.WriteLine("Invalid BookingID");
                            break;
                        }
                    case 1:
                        {
                            System.Console.WriteLine("Booking Cancelled Successfully");
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("Choosed Booking ID is already cancelled");
                            break;
                        }
                }
            }
            else
            {
                System.Console.WriteLine("There is no booking history to cancel");
            }
        }
        public void AddToCart()
        {
            //display foods with available stock by traversing the foods CustomList.
            //get food id
            //validate food id by traversing the foods CustomList - return 0 - FoodID is Invalid. Please enter the FoodID again
            //ask food quantity to purchase
            //create cart object and add to cart CustomList - UserID, FoodID, FoodCount, PriceOfCart
            //return 1 - Food Successfully added to Cart
            //ask to add another food
            //if "yes" repeat the above steps
            bool flag = true;
            do
            {
                foreach (FoodDetails food in operation.GetAvailableFoodDetails())
                {
                    System.Console.WriteLine($"{food.FoodID,-15} |{food.FoodName,-15} |{food.QuantityAvailable,-15} |{food.PricePerQuantity,-15}");
                }
                System.Console.WriteLine("Enter food ID :");
                string foodID = Console.ReadLine().ToUpper();

                System.Console.WriteLine("Enter count of food :");
                int count = int.Parse(Console.ReadLine());

                switch (operation.AddToCart(foodID, count))
                {
                    case 0:
                        {
                            System.Console.WriteLine("FoodID is Invalid. Please enter the FoodID again");
                            break;
                        }
                    case 1:
                        {
                            System.Console.WriteLine("Food Successfully added to Cart");
                            break;
                        }
                }
                System.Console.WriteLine("Do ypu wish to add another food to cart :");
                string wish = Console.ReadLine().ToUpper();
                if (wish != "YES")
                {
                    flag = false;
                }
            } while (flag);
        }
        public void FoodOrder()
        {
            /*a.	ConfirmPurchase
            b.	ModifyCart
            c.	DeleteCart
            d.	Exit
            */
            /*1.	Traverse and show the cartItems CustomList and check the FoodCount of each cartItem. 
            If it is available in foodsCustomList stock, then show as “In stock” else “out of stock” in same row. 
            Calculate TotalPrice of available stock items.*/

            foreach (CartDetails cart in operation.GetCartDetails())
            {
                foreach (FoodDetails food in operation.ShowFoodDetails())
                {
                    if (cart.FoodID == food.FoodID)
                    {
                        if (cart.FoodCount > food.QuantityAvailable)
                        {
                            System.Console.WriteLine($"{cart.CartID,-15} |{cart.CustomerID,-15} |{cart.FoodID,-15} |{cart.FoodCount,-15} |{cart.PriceOfCart,-15} |Out of stock");
                        }
                        else
                        {
                            System.Console.WriteLine($"{cart.CartID,-15} |{cart.CustomerID,-15} |{cart.FoodID,-15} |{cart.FoodCount,-15} |{cart.PriceOfCart,-15} |In stock");

                        }
                    }
                }
            }
            System.Console.WriteLine($"Total Price : {operation.GetTotalPrice()}");

            bool flag = true;
            do
            {
                System.Console.WriteLine("1. ConfirmPurchase\n2. ModifyCart\n3. DeleteCart\n4. Exit\nEnter option :");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            //ConfirmPurchase
                            ConfirmOrder();
                            break;
                        }
                    case 2:
                        {
                            //ModifyCart
                            ModifyCart();
                            break;
                        }
                    case 3:
                        {
                            //DeleteCart
                            DeleteCart();
                            break;
                        }
                    case 4:
                        {
                            //exit
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }
        public void DeleteCart()
        {
            CustomList<CartDetails> temp = operation.GetCartDetails();
            //display all cart items
            foreach (CartDetails cart in temp)
            {
                System.Console.WriteLine($"{cart.CartID,-15} |{cart.CustomerID,-15} |{cart.FoodID,-15} |{cart.FoodCount,-15} |{cart.PriceOfCart,-15}");
            }
            //select 1 cart id to delete
            if (temp.Count > 0)
            {
                System.Console.WriteLine("Select cart ID to delete :");
                string cartID = Console.ReadLine().ToUpper();

                switch (operation.DeleteCart(cartID))
                {
                    case 0:
                        {
                            System.Console.WriteLine("Invalid CartID");
                            break;
                        }
                    case 1:
                        {
                            System.Console.WriteLine("Cart deleted successfully");
                            break;
                        }
                }
            }
            else
            {
                System.Console.WriteLine("No cart details was found");
            }
            //validate cart id - return 0 - Invalid CartID
            //remove cart from cart CustomList
            //return 1 - Cart deleted successfully
        }
        public void ModifyCart()
        {
            CustomList<CartDetails> temp = operation.GetCartDetails();
            //display all cart items
            foreach (CartDetails cart in temp)
            {
                System.Console.WriteLine($"{cart.CartID,-15} |{cart.CustomerID,-15} |{cart.FoodID,-15} |{cart.FoodCount,-15} |{cart.PriceOfCart,-15}");
            }
            //select 1 cart id to modify
            if (temp.Count > 0)
            {
                System.Console.WriteLine("Select cart ID to modify :");
                string cartID = Console.ReadLine().ToUpper();

                System.Console.WriteLine("Enter food count to update :");
                int foodCount = int.Parse(Console.ReadLine());

                switch (operation.ModifyCart(cartID, foodCount))
                {
                    case 0:
                        {
                            System.Console.WriteLine("Invalid CartID");
                            break;
                        }
                    case 1:
                        {
                            System.Console.WriteLine("Cart Modified successfully");
                            break;
                        }
                }
            }
            else
            {
                System.Console.WriteLine("No cart details was found");
            }
            //validate cart id - return 0 - Invalid CartID
            //update cart from cart CustomList
            //return 1 - Cart modified successfully
        }
        public void ConfirmOrder()
        {
            //check cartlist count of current user >0 - return 0 
            //compare wallet balance and total price - return 1 - 
            //Insufficient balance to make your purchase. Needed amount to make your purchase is ______
            //ask customer wish to recharge - if "no" - return 3 - show purchase menu
            //if "yes" get amount and recharge
            //compare wallet balance and total price - return 1 - 
            //Insufficient balance to make your purchase. Needed amount to make your purchase is ______
            //ask customer wish to recharge - if "no" - return 3 - show purchase menu
            //if "yes" get amount and recharge

            //check cartlist count of current user >0 - return 0 
            CustomList<CartDetails> temp = operation.GetCartDetails();

            if (temp.Count > 0)
            {
                //compare wallet balance and total price - return 1
                foreach (CartDetails cart in temp)
                {
                    System.Console.WriteLine($"{cart.CartID,-15} |{cart.CustomerID,-15} |{cart.FoodID,-15} |{cart.FoodCount,-15} |{cart.PriceOfCart,-15}");
                }


                switch (operation.ConfirmPurchase(out string value1))
                {
                    case 1:
                        {
                            System.Console.WriteLine($"Insufficient balance to make your purchase. Needed amount to make your purchase is {operation.GetTotalPrice() - operation.ShowBalance()}");
                            bool flag1 = true;
                            do
                            {
                                if (WalletRecharge() == "YES")
                                {
                                    if (operation.CheckBalance())
                                    {
                                        operation.ContinuePurchase(out string value);
                                        System.Console.WriteLine($"Booking Successful. Your BookingID is{value}");
                                        flag1 = false;
                                    }
                                    else
                                    {
                                        System.Console.WriteLine($"Insufficient balance to make your purchase. Needed amount to make your purchase is {operation.GetTotalPrice() - operation.ShowBalance()}");
                                    }
                                }
                                else
                                {
                                    flag1 = false;
                                }
                            } while (flag1);

                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine($"Booking Successful. Your BookingID is {value1}");
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("All cart items are out of stock");
                            break;
                        }
                }
            }
            else
            {
                System.Console.WriteLine("No cart details was found");
            }
        }
    }
}