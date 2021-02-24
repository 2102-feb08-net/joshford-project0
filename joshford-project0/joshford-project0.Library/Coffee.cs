using System;
using System.Linq;
using System.Collections.Generic;
using joshford_project0.Database;
using Microsoft.EntityFrameworkCore;

namespace joshford_project0
{
    public class Coffee : IProduct
    {
        private List<CoffeeTypes> currentOrder = new List<CoffeeTypes>();
        static DbContextOptions<joshfordproject0Context> s_dbContextOptions;

        /// <summary>
        /// Constructor to create a coffee product object, uses product interface
        /// </summary>
        public Coffee() { }

        /// <summary>
        /// Adds a given coffee product to the current customers order
        /// </summary>
        /// <param name="productToAdd"></param>
        public void AddProductToOrder(Enum productToAdd)
        {
            currentOrder.Add((CoffeeTypes) productToAdd);
        }

        /// <summary>
        /// Checks the given coffee products current amount in the store inventory
        /// </summary>
        /// <param name="productToCheck"></param>
        public void CheckProductInventory(Enum productToCheck)
        {
            using var context = new joshfordproject0Context(s_dbContextOptions);

            CoffeeTypes coffeeInvCheck = (CoffeeTypes) productToCheck;
            int productAmount = 0;

            // SQL Query for coffee Inventory

            Console.WriteLine($"Current amount of {coffeeInvCheck} is: {productAmount}");
        }


        public double GetProductPrice(Enum productPrice)
        {
            using var context = new joshfordproject0Context(s_dbContextOptions);

            CoffeeTypes coffeePrice = (CoffeeTypes) productPrice;
            double priceOfCoffee = 0;

            // SQL Query for coffee prices

            return priceOfCoffee;
        }

    }

    public enum CoffeeTypes
    {
        Regular,
        Decaf,
        Iced_Regular,
        Iced_Decaf,
        Mocha_Latte,
        Vanilla_Latte,
        Cappucino
    }
}
