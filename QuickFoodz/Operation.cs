using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickFoodz
{
    public class Operation
    {
        CustomList<CustomerDetails> customers = new CustomList<CustomerDetails>();
        CustomList<FoodDetails> foods = new CustomList<FoodDetails>();
        CustomList<CartDetails> carts = new CustomList<CartDetails>();
        CustomList<BookingDetails> bookings = new CustomList<BookingDetails>();
        CustomList<PurchasedItems> purchasedItems = new CustomList<PurchasedItems>();
        CustomerDetails currentCustomer;
        public void DefaultData()
        {
            CustomerDetails customer1 = new CustomerDetails("Ravi", "Ettapparajan", GenderDetails.Male, "974774646", new DateTime(1999, 11, 11), "ravi@gmail.com", "chennai", 10000);
            CustomerDetails customer2 = new CustomerDetails("Baskaran", "Sethurajan", GenderDetails.Male, "847575775", new DateTime(1999, 11, 11), "baskaran@gmail.com", "chennai", 15000);

            customers.AddRange(new CustomList<CustomerDetails>() { customer1, customer2 });

            FoodDetails food1 = new FoodDetails("Chicken Briyani 1Kg", 100, 12);
            FoodDetails food2 = new FoodDetails("Mutton Briyani 1Kg", 150, 10);
            FoodDetails food3 = new FoodDetails("Veg Full Meals", 80, 30);
            FoodDetails food4 = new FoodDetails("Noodles", 100, 40);
            FoodDetails food5 = new FoodDetails("Dosa", 40, 40);
            FoodDetails food6 = new FoodDetails("Idly (2 pieces)", 20, 50);
            FoodDetails food7 = new FoodDetails("Pongal", 40, 20);
            FoodDetails food8 = new FoodDetails("Vegetable Briyani", 80, 15);
            FoodDetails food9 = new FoodDetails("Lemon Rice", 50, 30);
            FoodDetails food10 = new FoodDetails("Veg Pulav", 120, 30);
            FoodDetails food11 = new FoodDetails("Chicken 65 (200 Grams)", 75, 30);

            foods.AddRange(new CustomList<FoodDetails>() { food1, food2, food3, food4, food5, food5, food6, food7, food8, food9, food10, food11 });

            BookingDetails booking1 = new BookingDetails("CID1001", 580, new DateTime(2022, 11, 26), BookingStatus.Booked);
            BookingDetails booking2 = new BookingDetails("CID1002", 870, new DateTime(2022, 11, 26), BookingStatus.Booked);
            BookingDetails booking3 = new BookingDetails("CID1001", 820, new DateTime(2022, 11, 26), BookingStatus.Cancelled);

            bookings.AddRange(new CustomList<BookingDetails>() { booking1, booking2, booking3 });

            CartDetails cart1 = new CartDetails("CID1002", "FID2002", 4, 200);
            CartDetails cart2 = new CartDetails("CID1001", "FID2001", 2, 80);
            CartDetails cart3 = new CartDetails("CID1002", "FID2003", 1, 40);

            carts.AddRange(new CustomList<CartDetails>() { cart1, cart2, cart3 });

            PurchasedItems purchased1 = new PurchasedItems("CRID4001", "BID3001", "FID2001", 2, 200);
            PurchasedItems purchased2 = new PurchasedItems("CRID4002", "BID3001", "FID2002", 2, 300);
            PurchasedItems purchased3 = new PurchasedItems("CRID4003", "BID3001", "FID2003", 1, 80);
            PurchasedItems purchased4 = new PurchasedItems("CRID4004", "BID3002", "FID2001", 1, 100);
            PurchasedItems purchased5 = new PurchasedItems("CRID4005", "BID3002", "FID2002", 4, 600);
            PurchasedItems purchased6 = new PurchasedItems("CRID4006", "BID3002", "FID2010", 1, 120);
            PurchasedItems purchased7 = new PurchasedItems("CRID4007", "BID3003", "FID2002", 2, 300);
            PurchasedItems purchased8 = new PurchasedItems("CRID4008", "BID3003", "FID2008", 4, 320);
            PurchasedItems purchased9 = new PurchasedItems("CRID4009", "BID3003", "FID2001", 2, 200);

            purchasedItems.AddRange(new CustomList<PurchasedItems>() { purchased1, purchased2, purchased3, purchased4, purchased5, purchased6, purchased7, purchased7, purchased8 });

        }
        public string AddUser(CustomerDetails customer)
        {
            customers.Add(customer);
            return customer.CustomerID;
        }
        public void WriteToCSV()
        {
            new FileManager<CustomerDetails>().WriteToCSV(customers);
            new FileManager<FoodDetails>().WriteToCSV(foods);
            new FileManager<CartDetails>().WriteToCSV(carts);
            new FileManager<BookingDetails>().WriteToCSV(bookings);
            new FileManager<PurchasedItems>().WriteToCSV(purchasedItems);
        }
        public void ReadFromCSV()
        {
            customers = new FileManager<CustomerDetails>().ReadFromCSV();
            foods = new FileManager<FoodDetails>().ReadFromCSV();
            carts = new FileManager<CartDetails>().ReadFromCSV();
            bookings = new FileManager<BookingDetails>().ReadFromCSV();
            purchasedItems = new FileManager<PurchasedItems>().ReadFromCSV();
        }
        public bool CheckCustomer(string customerID)
        {
            new SearchUtility<CustomerDetails>().BinarySearch(customers,customerID,"CustomerID",out CustomerDetails element);
            // foreach (CustomerDetails customer in customers)
            // {
            //     if (customer.CustomerID == customerID)
            //     {
            //         currentCustomer = customer;
            //         return true;
            //     }
            // }
            if(element!=null)
            {
                currentCustomer=element;
                return true;
            }
            return false;
        }
        /// <summary>
        /// add current user details to a list
        /// </summary>
        /// <returns>returns current customer details</returns>
        public CustomList<CustomerDetails> ShowCustomerDetails()
        {
            CustomList<CustomerDetails> customerDetails = new CustomList<CustomerDetails>();
            customerDetails.Add(currentCustomer);
            return customerDetails;
        }
        public CustomList<FoodDetails> ShowFoodDetails()
        {
            return foods;
        }
        public void WalletRecharge(double amount)
        {
            currentCustomer.WalletRecharge(amount);
        }
        public double ShowBalance()
        {
            return currentCustomer.WalletBalance;
        }
        public CustomList<BookingDetails> BookingHistory()
        {
            CustomList<BookingDetails> details = new CustomList<BookingDetails>();

            foreach (BookingDetails booking in bookings)
            {
                if (booking.CustomerID == currentCustomer.CustomerID)
                {
                    details.Add(booking);
                }
            }
            return details;
        }

        public CustomList<PurchasedItems> GetPurchasedItems()
        {
            return purchasedItems;
        }
        public int CancelBooking(string bookingID)
        {
            //check for book id - return 0 show “Invalid BookingID”
            foreach (BookingDetails booking in BookingHistory())
            {
                if (booking.BookID == bookingID)
                {
                    if (booking.BookingStatus == BookingStatus.Cancelled)
                    {
                        return 2;
                    }
                    else
                    {
                        //update book status as cancelled
                        booking.BookingStatus = BookingStatus.Cancelled;
                        //return totalprice to wallet balance
                        currentCustomer.WalletRecharge(booking.TotalPrice);
                        //return purchase count to food details count
                        foreach (PurchasedItems purchasedItems in purchasedItems)
                        {
                            if (purchasedItems.BookingID == bookingID)
                            {
                                foreach (FoodDetails food in foods)
                                {
                                    if (food.FoodID == purchasedItems.FoodID)
                                    {
                                        food.QuantityAvailable += purchasedItems.PurchaseCount;
                                    }
                                }
                            }
                        }
                        return 1;
                    }
                }
            }
            return 0;
        }
        public int AddToCart(string foodID, int count)
        {
            //validate food id by traversing the foods CustomList - return 0 - FoodID is Invalid. Please enter the FoodID again
            foreach (FoodDetails food in GetAvailableFoodDetails())
            {
                if (food.FoodID == foodID)
                {
                    //create cart object and add to cart CustomList - UserID, FoodID, foodCount, PriceOfCart
                    CartDetails cart = new CartDetails(currentCustomer.CustomerID, foodID, count, count * food.PricePerQuantity);
                    carts.Add(cart);
                    //return 1 - Food Successfully added to Cart
                    return 1;
                }
            }
            return 0;

        }
        public CustomList<FoodDetails> GetAvailableFoodDetails()
        {
            CustomList<FoodDetails> availableFoods = new CustomList<FoodDetails>();

            foreach (FoodDetails food in foods)
            {
                if (food.QuantityAvailable > 0)
                {
                    availableFoods.Add(food);
                }
            }
            return availableFoods;
        }
        public int DeleteCart(string cartID)
        {
            //validate cart id - return 0 - Invalid CartID
            foreach (CartDetails cart in GetCartDetails())
            {
                if (cart.CartID == cartID)
                {
                    //remove cart from cart CustomList
                    //return 1 - Cart deleted successfully
                    carts.Remove(cart);
                    return 1;
                }
            }
            return 0;
        }
        public CustomList<CartDetails> GetCartDetails()
        {
            CustomList<CartDetails> currentCart = new CustomList<CartDetails>();
            foreach (CartDetails cart in carts)
            {
                if (cart.CustomerID == currentCustomer.CustomerID)
                {
                    currentCart.Add(cart);
                }
            }
            return currentCart;
        }
        public int ModifyCart(string cartID, int foodCount)
        {
            //validate cart id - return 0 - Invalid CartID
            foreach (CartDetails cart in GetCartDetails())
            {
                if (cart.CartID == cartID)
                {
                    //update cart from cart CustomList
                    //return 1 - Cart modified successfully
                    cart.FoodCount = foodCount;
                    foreach (FoodDetails food in foods)
                    {
                        if (food.FoodID == cart.FoodID)
                        {
                            cart.PriceOfCart = foodCount * food.PricePerQuantity;
                        }
                    }
                    return 1;
                }
            }
            return 0;
        }
        public int ConfirmPurchase(out string value1)
        {
            if (GetAvailableCartDetails().Count > 0)
            {
                //compare wallet balance and total price - return 1

                if (currentCustomer.WalletBalance >= GetTotalPrice())
                {
                    ContinuePurchase(out string value);
                    value1 = value;
                    return 2;
                }
                else
                {
                    value1 = null;
                    return 1;
                }
            }
            else
            {
                value1 = null;
                return 3;
            }

        }
        public int ContinuePurchase(out string value)
        {
            //deduct total price from wallet if balance is enough
            //Create booking object - BookingID, CustomerID, TotalPrice, DateOfBooking as now, BookingStatus as “Booked”.
            //create string list (cart item id stored)
            //compare purchase count and available food quantity by traversing both list
            //if available, deduct food quantity
            //create purchased item obj & add to list
            //add cart id to string list
            //add booking obj to list and return 4 - Booking Successful. Your BookingID is _____
            //remove purchased cart item from cart list using cart item id in string list


            double totalPrice = GetTotalPrice();
            //deduct total price from wallet if balance is enough
            currentCustomer.DeductBalance(totalPrice);

            //Create booking object - BookingID, CustomerID, TotalPrice, DateOfBooking as now, BookingStatus as “Booked”.
            BookingDetails booking = new BookingDetails(currentCustomer.CustomerID, totalPrice, DateTime.Now, BookingStatus.Booked);
            //create string list (cart item id stored)
            List<string> cartToDelete = new List<string>();

            foreach (CartDetails cart in carts)
            {
                if (currentCustomer.CustomerID == cart.CustomerID)
                {

                    //compare purchase count and available food quantity by traversing both list 
                    foreach (FoodDetails food in foods)
                    {
                        if (cart.FoodID == food.FoodID)
                        {
                            if (cart.FoodCount <= food.QuantityAvailable)
                            {
                                //if available, deduct food quantity
                                food.QuantityAvailable -= cart.FoodCount;

                                //create purchased item obj & add to list
                                PurchasedItems purchased = new PurchasedItems(cart.CartID, booking.BookID, food.FoodID, cart.FoodCount, cart.PriceOfCart);
                                purchasedItems.Add(purchased);
                                cartToDelete.Add(cart.CartID);

                            }
                        }
                    }
                }
            }
            //add booking obj to list and return 2 - Booking Successful. Your BookingID is _____
            bookings.Add(booking);
            //remove purchased cart item from cart list using cart item id in string list
            List<CartDetails> copyCart = new List<CartDetails>();
            foreach (CartDetails cart1 in carts)
            {
                copyCart.Add(cart1);
            }

            foreach (string delete in cartToDelete)
            {
                foreach (CartDetails cart1 in copyCart)
                {
                    if (cart1.CartID == delete)
                    {
                        carts.Remove(cart1);
                    }
                }
            }
            value = booking.BookID;
            return 2;
        }
        // public string GetBookingID()
        // {
        //     return bookings.Last().BookID;
        // }
        public bool CheckBalance()
        {

            if (currentCustomer.WalletBalance >= GetTotalPrice())
            {
                return true;
            }
            return false;
        }
        public CustomList<CartDetails> GetAvailableCartDetails()
        {
            CustomList<CartDetails> availableCart = new CustomList<CartDetails>();
            foreach (CartDetails cart in GetCartDetails())
            {
                foreach (FoodDetails food in foods)
                {
                    if (cart.FoodID == food.FoodID)
                    {
                        if (cart.FoodCount <= food.QuantityAvailable)
                        {
                            availableCart.Add(cart);
                        }
                    }
                }
            }
            return availableCart;
        }
        public double GetTotalPrice()
        {
            double totalPrice = 0;
            foreach (CartDetails cart in GetAvailableCartDetails())
            {
                totalPrice += cart.PriceOfCart;
            }
            return totalPrice;
        }
    }
}