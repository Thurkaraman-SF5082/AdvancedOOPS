using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncCafe
{
    public class UI
    {
        Operation operation = new Operation();

        public void MainMenu()
        {
            operation.DefaultData();
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
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }

        public void CustomerRegistration()
        {
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

            CustomerDetails customer = new CustomerDetails(customerName, fatherName, gender, mobileNumber, dob, mailID, walletBalance);

            System.Console.WriteLine($"Registration successful. Your customer ID is {operation.AddUser(customer)}");
        }
        public void CustomerLogin()
        {
            /*1.	Ask and get the “CustomerID” of the customer and check if the 'CustomerID' exists in the customers list. 
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
            bool flag = true;

            do
            {
                System.Console.WriteLine("1. ShowCustomerDetails\n2. ShowFoodDetails\n3. WalletRecharge\n4. AddToCart\n5. Purchase\n6. CancelBooking\n7. BookingHistory\n8. ShowBalance\n9. Exit\nEnter option :");
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
                            Purchase();
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
            // foreach (CustomerDetails customer in operation.ShowCustomerDetails())
            // {
            //     System.Console.WriteLine($"{customer.CustomerID,-15} |{customer.CustomerName,-15} |{customer.FatherName,-15} |{customer.Gender,-15} |{customer.DOB,-15} |{customer.MobileNumber,-15} |{customer.MailID,-15} |{customer.WalletBalance,-15}");
            // }
            List<CustomerDetails> customer=operation.ShowCustomerDetails();
            customer.ForEach(customer=> System.Console.WriteLine($"{customer.CustomerID,-15} |{customer.CustomerName,-15} |{customer.FatherName,-15} |{customer.Gender,-15} |{customer.DOB,-15} |{customer.MobileNumber,-15} |{customer.MailID,-15} |{customer.WalletBalance,-15}"));
        }
        public void ShowFoodDetails()
        {
            // foreach (FoodDetails food in operation.ShowFoodDetails())
            // {
            //     System.Console.WriteLine($"{food.FoodID,-15} |{food.FoodName,-15} |{food.QuantityAvailable,-15} |{food.PricePerQuantity,-15}");
            // }
            List<FoodDetails> foodDetails=operation.ShowFoodDetails();
            foodDetails.ForEach(food=> System.Console.WriteLine($"{food.FoodID,-15} |{food.FoodName,-15} |{food.QuantityAvailable,-15} |{food.PricePerQuantity,-15}"));
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
            /*1.	Show the current customer’s booking history by traversing the bookingsList.
            2.	Ask the customer to choose a BookingID. If the BookingID is not valid, then show “Invalid BookingID” and show Sub Menu Options.
            3.	If the BookingID is valid, then show the chosen booking’s purchased details. After that show the Sub Menu Options.
            */
            List<BookingDetails> historyCheck = operation.BookingHistory();

            if (historyCheck.Count > 0)
            {
                int count = 0;
                historyCheck.ForEach(booking=> System.Console.WriteLine($"{booking.BookID,-15} |{booking.CustomerID,-15} |{booking.TotalPrice,-15} |{booking.DateOfBooking.ToString("dd/MM/yyyy"),-15} |{booking.BookingStatus,-15}"));
                // foreach (BookingDetails booking in historyCheck)
                // {
                //     System.Console.WriteLine($"{booking.BookID,-15} |{booking.CustomerID,-15} |{booking.TotalPrice,-15} |{booking.DateOfBooking.ToString("dd/MM/yyyy"),-15} |{booking.BookingStatus,-15}");
                // }

                System.Console.WriteLine("Choose a Booking ID :");
                string bookingID = Console.ReadLine().ToUpper();


                foreach (PurchasedItems purchasedItems in operation.GetPurchasedItems())
                {
                    if (purchasedItems.BookingID == bookingID)
                    {
                        count++;
                        System.Console.WriteLine($"{purchasedItems.PurchaseID,-15} |{purchasedItems.CartID,-15} |{purchasedItems.BookingID,-15} |{purchasedItems.FoodID,-15} |{purchasedItems.PurchaseCount,-15} |{purchasedItems.PriceOfPurchase,-15}");
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
            List<BookingDetails> historyCheck = operation.BookingHistory();

            if (historyCheck.Count > 0)
            {
                historyCheck.ForEach(booking=>System.Console.WriteLine($"{booking.BookID,-15} |{booking.CustomerID,-15} |{booking.TotalPrice,-15} |{booking.DateOfBooking.ToString("dd/MM/yyyy"),-15} |{booking.BookingStatus,-15}"));
                // foreach (BookingDetails booking in operation.BookingHistory())
                // {
                //     System.Console.WriteLine($"{booking.BookID,-15} |{booking.CustomerID,-15} |{booking.TotalPrice,-15} |{booking.DateOfBooking.ToString("dd/MM/yyyy"),-15} |{booking.BookingStatus,-15}");
                // }
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
            //display foods with available stock by traversing the foods list.
            //get food id
            //validate food id by traversing the foods list - return 0 - FoodID is Invalid. Please enter the FoodID again
            //ask food quantity to purchase
            //create cart object and add to cart list - UserID, FoodID, PurchaseCount, PriceOfCart
            //return 1 - Food Successfully added to Cart
            //ask to add another food
            //if "yes" repeat the above steps
            bool flag = true;
            do
            {
                // foreach (FoodDetails food in operation.GetAvailableFoodDetails())
                // {
                //     System.Console.WriteLine($"{food.FoodID,-15} |{food.FoodName,-15} |{food.QuantityAvailable,-15} |{food.PricePerQuantity,-15}");
                // }
                operation.GetAvailableFoodDetails().ForEach(food=>System.Console.WriteLine($"{food.FoodID,-15} |{food.FoodName,-15} |{food.QuantityAvailable,-15} |{food.PricePerQuantity,-15}"));
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
                System.Console.WriteLine("Do you wish to add another food to cart :");
                string wish = Console.ReadLine().ToUpper();
                if (wish != "YES")
                {
                    flag = false;
                }
            } while (flag);
        }
        public void Purchase()
        {
            /*a.	ConfirmPurchase
            b.	ModifyCart
            c.	DeleteCart
            d.	Exit
            */
            /*1.	Traverse and show the cartItems List and check the PurchaseCount of each cartItem. 
            If it is available in foodsList stock, then show as “In stock” else “out of stock” in same row. 
            Calculate TotalPrice of available stock items.*/

            foreach (CartDetails cart in operation.GetCartDetails())
            {
                foreach (FoodDetails food in operation.ShowFoodDetails())
                {
                    if (cart.FoodID == food.FoodID)
                    {
                        if (cart.PurchaseCount > food.QuantityAvailable)
                        {
                            System.Console.WriteLine($"{cart.CartID,-15} |{cart.CustomerID,-15} |{cart.FoodID,-15} |{cart.PurchaseCount,-15} |{cart.PriceOfCart,-15} |Out of stock");
                        }
                        else
                        {
                            System.Console.WriteLine($"{cart.CartID,-15} |{cart.CustomerID,-15} |{cart.FoodID,-15} |{cart.PurchaseCount,-15} |{cart.PriceOfCart,-15} |In stock");

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
                            ConfirmPurchase();
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
            List<CartDetails> temp = operation.GetCartDetails();
            //display all cart items
            // foreach (CartDetails cart in temp)
            // {
                temp.ForEach(cart=> System.Console.WriteLine($"{cart.CartID,-15} |{cart.CustomerID,-15} |{cart.FoodID,-15} |{cart.PurchaseCount,-15} |{cart.PriceOfCart,-15}"));
            // }
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
            //remove cart from cart list
            //return 1 - Cart deleted successfully
        }
        public void ModifyCart()
        {
            List<CartDetails> temp = operation.GetCartDetails();
            //display all cart items
            // foreach (CartDetails cart in temp)
            // {
                temp.ForEach(cart=> System.Console.WriteLine($"{cart.CartID,-15} |{cart.CustomerID,-15} |{cart.FoodID,-15} |{cart.PurchaseCount,-15} |{cart.PriceOfCart,-15}"));
            // }
            //select 1 cart id to modify
            if (temp.Count > 0)
            {
                System.Console.WriteLine("Select cart ID to modify :");
                string cartID = Console.ReadLine().ToUpper();

                System.Console.WriteLine("Enter purchase count to update :");
                int purchaseCount = int.Parse(Console.ReadLine());

                switch (operation.ModifyCart(cartID, purchaseCount))
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
            //update cart from cart list
            //return 1 - Cart modified successfully
        }
        public void ConfirmPurchase()
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
            List<CartDetails> temp = operation.GetCartDetails();

            if (temp.Count > 0)
            {
                //compare wallet balance and total price - return 1
                foreach (CartDetails cart in temp)
                {
                    System.Console.WriteLine($"{cart.CartID,-15} |{cart.CustomerID,-15} |{cart.FoodID,-15} |{cart.PurchaseCount,-15} |{cart.PriceOfCart,-15}");
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