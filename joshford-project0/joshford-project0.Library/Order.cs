﻿using System;
using System.Linq;
using System.Collections.Generic;
using joshford_project0.Database;
using Microsoft.EntityFrameworkCore;

namespace joshford_project0
{
    public class OrderC
    {
        private List<CoffeeTypes> customerCoffee = new List<CoffeeTypes>();
        private List<FoodTypes> customerFood = new List<FoodTypes>();
        private double productPrice = 0.00;
        private double _currentOrderTotal = 0.00;
        private int _customerID;
        private int _employeeID;
        private int _storeID;
        private DateTime currentDate;
        static DbContextOptions<joshfordproject0Context> s_dbContextOptions = DataAccess_Library.OpenDatabaseConnection();


        public OrderC(int custID, int emplID, int storeID)
        {
            _customerID = custID;
            _employeeID = emplID;
            _storeID = storeID;
            currentDate = currentDate.ToLocalTime();
        }

        /// <summary>
        /// Retrieve the total order price of the given customers order
        /// </summary>
        public double TotalOrderPrice { get; }

        /// <summary>
        /// Add to the total order price of the given customers order
        /// </summary>
        public void AddToTotalOrderPrice(double itemToAdd)
        {
            _currentOrderTotal += itemToAdd;
        }

        /// <summary>
        /// Add a coffee product to the current customers order
        /// Multiplies given coffee product by amount purchased and passes to 
        ///     AddToTotal_ method
        /// </summary>
        /// <param name="coffeeProduct"></param>
        /// <param name="quantity"></param>
        public void AddProductToOrder(CoffeeTypes coffeeProduct, int quantity)
        {
            Coffee coffee = new Coffee();
            double coffeePrice = 0.00;

            using var context = new joshfordproject0Context(s_dbContextOptions);

            IQueryable<Product> menu = context.Products
                .OrderBy(x => x.ProductName);

            foreach (Product products in menu)
            {
                if (coffeeProduct.ToString().Equals(products.ProductName))
                {
                    coffeePrice = products.ProductPrice;
                }
            }


            /*
            coffeePrice = double.Parse(context.Products
                .Select(x => x.ProductPrice)
                .Where(x => x.Equals(custCoffee))
                .ToString());
            */

            customerCoffee.Add(coffeeProduct);
            AddToTotalOrderPrice(coffeePrice * quantity);
        }

        /// <summary>
        /// Add a food product to the current customers order
        /// Multiplies given food product by amount purchased and passes to 
        ///     AddToTotal_ method
        /// </summary>
        /// <param name="foodProduct"></param>
        ///<param name="quantity"></param>
        public void AddProductToOrder(FoodTypes foodProduct, int quantity)
        {
            Food food = new Food();
            double foodPrice = 0.00;

            using var context = new joshfordproject0Context(s_dbContextOptions);

            IQueryable<Product> menu = context.Products
                .OrderBy(x => x.ProductName);

            foreach (Product products in menu)
            {
                if(foodProduct.ToString().Equals(products.ProductName))
                {
                    foodPrice = products.ProductPrice;
                }
            }

            customerFood.Add(foodProduct);
            AddToTotalOrderPrice(foodPrice * quantity);
        }

        /// <summary>
        /// Prints the current coffee products on the current order
        /// </summary>
        public void PrintCurrentOrder()
        {
            Console.WriteLine("\t--Customer's Current Order--");

            foreach (int index in customerCoffee)
            {
                Console.WriteLine($"\t{customerCoffee[index]}\t");
            }

            foreach (int index in customerFood)
            {
                Console.WriteLine($"\t{customerFood[index]}\t");
            }

            Console.WriteLine($"Current Order Total:\t{TotalOrderPrice}");

        }

        /// <summary>
        /// Given the customers menu selection, the product that corresponds
        ///     to the given menu selection is returned
        /// </summary>
        /// <param name="customerSelection"></param>
        /// <returns> CoffeeType or FoodType enum </returns>
        public static Enum GetProductSelection(string customerSelection)
        {
            switch(customerSelection)
            {
                case "1":
                    return FoodTypes.Apple_Pastry;

                case "2":
                    return FoodTypes.Bagel;

                case "3":
                    return FoodTypes.Bagel_With_Spread;

                case "4":
                    return FoodTypes.Breakfast_Bagel;

                case "5":
                    return CoffeeTypes.Cappucino;

                case "6":
                    return FoodTypes.Cheese_Pastry;

                case "7":
                    return CoffeeTypes.Decaf;

                case "8":
                    return FoodTypes.Hashbrowns;

                case "9":
                    return CoffeeTypes.Iced_Decaf;

                case "10":
                    return CoffeeTypes.Iced_Regular;

                case "11":
                    return CoffeeTypes.Mocha_Latte;
  
                case "12":
                    return FoodTypes.Muffin;
  
                case "13":
                    return FoodTypes.Muffin_With_Spread;
  
                case "14":
                    return CoffeeTypes.Regular;

                case "15":
                    return FoodTypes.Strawberry_Pastry;

                case "16":
                    return CoffeeTypes.Vanilla_Latte;

                default:
                    break;
            }

            return noProduct.Invalid;
        }

        /// <summary>
        /// Print the store Menu
        /// </summary>
        public static void PrintMenu()
        {
            using var context = new joshfordproject0Context(s_dbContextOptions);

            var totalMenuItems = context.Products.Select(x => x.ProductId).Max();
            IQueryable<Product> menu = context.Products
                .OrderBy(x => x.ProductName);
            int menuLine = 1;

            foreach (Product products in menu)
            {
                Console.WriteLine($"{menuLine}: {products.ProductName}\t${products.ProductPrice}");
                menuLine++;
            }
            Console.WriteLine("\tMenu Choice:\n");
        }

        /// <summary>
        /// Finalizes the placed order by removing given products from the stores
        ///     inventory, adding order to Orders table and Employees/Customers
        ///     history tables
        /// </summary>
        public void PlaceOrder()
        {
            using var context = new joshfordproject0Context(s_dbContextOptions);
            var order = new Order
            {
                CustomerId = _customerID,
                EmployeeId = _employeeID,
                StoreId = _storeID,
                OrderTotal = _currentOrderTotal
            };

            context.Orders.Add(order);

            context.SaveChanges();
        }
    }

    public enum noProduct
    {
        Invalid
    }
}
