using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncCafe
{
    public class Operation
    {
        List<CustomerDetails> customers = new List<CustomerDetails>();
        List<FoodDetails> foods = new List<FoodDetails>();
        List<CartDetails> carts = new List<CartDetails>();
        List<BookingDetails> bookings = new List<BookingDetails>();
        List<PurchasedItems> purchasedItems = new List<PurchasedItems>();
        CustomerDetails currentCustomer;
        public void DefaultData()
        {
            CustomerDetails customer1 = new CustomerDetails("Ravi", "Ettapparajan", GenderDetails.Male, "974774646", new DateTime(1999, 11, 11), "ravi@gmail.com", 1000);
            CustomerDetails customer2 = new CustomerDetails("Baskaran", "Sethurajan", GenderDetails.Male, "847575775", new DateTime(1999, 11, 11), "baskaran@gmail.com", 15000);

            customers.AddRange(new List<CustomerDetails>() { customer1, customer2 });

            FoodDetails food1 = new FoodDetails("Coffee", 20, 40);
            FoodDetails food2 = new FoodDetails("Tea", 100, 50);
            FoodDetails food3 = new FoodDetails("Milk", 10, 40);
            FoodDetails food4 = new FoodDetails("Juice", 10, 10);
            FoodDetails food5 = new FoodDetails("Puff", 10, 10);
            FoodDetails food6 = new FoodDetails("Popcorn", 10, 20);
            FoodDetails food7 = new FoodDetails("Samosa", 10, 10);
            FoodDetails food8 = new FoodDetails("Sandwich", 10, 25);
            FoodDetails food9 = new FoodDetails("Pizza", 10, 20);
            FoodDetails food10 = new FoodDetails("Burger", 10, 140);

            foods.AddRange(new List<FoodDetails>() { food1, food2, food3, food4, food5, food6, food7, food8, food9, food10 });

            BookingDetails booking1 = new BookingDetails("CID1001", 220, new DateTime(2024, 09, 26), BookingStatus.Booked);
            BookingDetails booking2 = new BookingDetails("CID1002", 400, new DateTime(2024, 09, 24), BookingStatus.Booked);
            BookingDetails booking3 = new BookingDetails("CID1001", 280, new DateTime(2024, 09, 20), BookingStatus.Cancelled);

            bookings.AddRange(new List<BookingDetails>() { booking1, booking2, booking3 });

            CartDetails cart1 = new CartDetails("CID1002", "FID2002", 4, 200);
            CartDetails cart2 = new CartDetails("CID1001", "FID2001", 2, 80);
            CartDetails cart3 = new CartDetails("CID1002", "FID2003", 1, 40);

            carts.AddRange(new List<CartDetails>() { cart1, cart2, cart3 });

            PurchasedItems purchased1 = new PurchasedItems("CRID4001", "BID3001", "FID2001", 2, 80);
            PurchasedItems purchased2 = new PurchasedItems("CRID4002", "BID3001", "FID2002", 2, 100);
            PurchasedItems purchased3 = new PurchasedItems("CRID4003", "BID3001", "FID2003", 1, 40);
            PurchasedItems purchased4 = new PurchasedItems("CRID4004", "BID3002", "FID2001", 1, 40);
            PurchasedItems purchased5 = new PurchasedItems("CRID4005", "BID3002", "FID2002", 4, 200);
            PurchasedItems purchased6 = new PurchasedItems("CRID4006", "BID3002", "FID2010", 1, 140);
            PurchasedItems purchased7 = new PurchasedItems("CRID4007", "BID3002", "FID2009", 1, 20);
            PurchasedItems purchased8 = new PurchasedItems("CRID4008", "BID3003", "FID2002", 2, 100);
            PurchasedItems purchased9 = new PurchasedItems("CRID4009", "BID3003", "FID2008", 4, 100);
            PurchasedItems purchased10 = new PurchasedItems("CRID4010", "BID3003", "FID2001", 2, 80);

            purchasedItems.AddRange(new List<PurchasedItems>() { purchased1, purchased2, purchased3, purchased4, purchased5, purchased6, purchased7, purchased8, purchased9, purchased10 });
        }

        public string AddUser(CustomerDetails customer)
        {
            customers.Add(customer);
            return customer.CustomerID;
        }
        public bool CheckCustomer(string customerID)
        {
            // foreach (CustomerDetails customer in customers)
            // {
            CustomerDetails customer = (from customer1 in customers where customer1.CustomerID == customerID select customer1).FirstOrDefault();
            if (customer != null)
            {
                currentCustomer = customer;
                return true;
            }
            // }
            return false;
        }
        public List<CustomerDetails> ShowCustomerDetails()
        {
            // List<CustomerDetails> customerDetails = new List<CustomerDetails>();
            List<CustomerDetails> customer = (from customer1 in customers
            where customer1.CustomerID==currentCustomer.CustomerID
            select customer1).ToList();

            // foreach (CustomerDetails customer in customers)
            // {
            //     if (customer.CustomerID == currentCustomer.CustomerID)
            //     {
            //         customerDetails.Add(customer);
            //     }
            // }
            return customer;
        }
        public List<FoodDetails> ShowFoodDetails()
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
        public List<BookingDetails> BookingHistory()
        {
            // List<BookingDetails> details = new List<BookingDetails>();
            List<BookingDetails> details = (from book in bookings
            where book.CustomerID==currentCustomer.CustomerID
            select book).ToList();

            // foreach (BookingDetails booking in bookings)
            // {
            //     if (booking.CustomerID == currentCustomer.CustomerID)
            //     {
            //         details.Add(booking);
            //     }
            // }
            return details;
        }

        public List<PurchasedItems> GetPurchasedItems()
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
            //validate food id by traversing the foods list - return 0 - FoodID is Invalid. Please enter the FoodID again
            foreach (FoodDetails food in GetAvailableFoodDetails())
            {
                if (food.FoodID == foodID)
                {
                    //create cart object and add to cart list - UserID, FoodID, PurchaseCount, PriceOfCart
                    CartDetails cart = new CartDetails(currentCustomer.CustomerID, foodID, count, count * food.PricePerQuantity);
                    carts.Add(cart);
                    //return 1 - Food Successfully added to Cart
                    return 1;
                }
            }
            return 0;

        }
        public List<FoodDetails> GetAvailableFoodDetails()
        {
            // List<FoodDetails> availableFoods = new List<FoodDetails>();
            List<FoodDetails> availableFoods = (from food in foods
            where food.QuantityAvailable>0
            select food).ToList();

            // foreach (FoodDetails food in foods)
            // {
            //     if (food.QuantityAvailable > 0)
            //     {
            //         availableFoods.Add(food);
            //     }
            // }
            return availableFoods;
        }
        public int DeleteCart(string cartID)
        {
            //validate cart id - return 0 - Invalid CartID
            foreach (CartDetails cart in GetCartDetails())
            {
                if (cart.CartID == cartID)
                {
                    //remove cart from cart list
                    //return 1 - Cart deleted successfully
                    carts.Remove(cart);
                    return 1;
                }
            }
            return 0;
        }
        public List<CartDetails> GetCartDetails()
        {
            // List<CartDetails> currentCart = new List<CartDetails>();
            List<CartDetails> currentCart = (from cart in carts
            where cart.CustomerID==currentCustomer.CustomerID
            select cart).ToList();
            // foreach (CartDetails cart in carts)
            // {
            //     if (cart.CustomerID == currentCustomer.CustomerID)
            //     {
            //         currentCart.Add(cart);
            //     }
            // }
            return currentCart;
        }
        public int ModifyCart(string cartID, int purchaseCount)
        {
            //validate cart id - return 0 - Invalid CartID
            foreach (CartDetails cart in GetCartDetails())
            {
                if (cart.CartID == cartID)
                {
                    //update cart from cart list
                    //return 1 - Cart modified successfully
                    cart.PurchaseCount = purchaseCount;
                    foreach (FoodDetails food in foods)
                    {
                        if (food.FoodID == cart.FoodID)
                        {
                            cart.PriceOfCart = purchaseCount * food.PricePerQuantity;
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
                            if (cart.PurchaseCount <= food.QuantityAvailable)
                            {
                                //if available, deduct food quantity
                                food.QuantityAvailable -= cart.PurchaseCount;

                                //create purchased item obj & add to list
                                PurchasedItems purchased = new PurchasedItems(cart.CartID, booking.BookID, food.FoodID, cart.PurchaseCount, cart.PriceOfCart);
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
        public bool CheckBalance()
        {
            if (currentCustomer.WalletBalance >= GetTotalPrice())
            {
                return true;
            }
            return false;
        }
        public List<CartDetails> GetAvailableCartDetails()
        {
            // List<CartDetails> availableCart = new List<CartDetails>();
            List<CartDetails> availableCart = (from cart in carts
            join food in foods
            on cart.FoodID equals food.FoodID
            where cart.PurchaseCount<=food.QuantityAvailable
            select cart).ToList();
            // foreach (CartDetails cart in GetCartDetails())
            // {
            //     foreach (FoodDetails food in foods)
            //     {
            //         if (cart.FoodID == food.FoodID)
            //         {
            //             if (cart.PurchaseCount <= food.QuantityAvailable)
            //             {
            //                 availableCart.Add(cart);
            //             }
            //         }
            //     }
            // }
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