﻿using System;
using System.Linq;
using System.Collections.Generic;
using joshford_project0.Database;
using Microsoft.EntityFrameworkCore;

namespace joshford_project0
{
    public class Food : IProduct
    {
        private List<FoodTypes> currentOrder = new List<FoodTypes>();
        static DbContextOptions<joshfordproject0Context> s_dbContextOptions = DataAccess_Library.OpenDatabaseConnection();

        /// <summary>
        /// Constructor to create a food product object, uses product interface
        /// </summary>
        public Food() { }

        /// <summary>
        /// Adds a given food product to the current customers order
        /// </summary>
        /// <param name="productToAdd"></param>
        public void AddProductToOrder(Enum productToAdd)
        {
            currentOrder.Add((FoodTypes) productToAdd);
        }

        /// <summary>
        /// Checks the given food products current amount in the store inventory
        /// </summary>
        /// <param name="productToCheck"></param>
        public void CheckProductInventory(Enum productToCheck)
        {
            using var context = new joshfordproject0Context(s_dbContextOptions);

            FoodTypes foodInvCheck = (FoodTypes)productToCheck;
            int productAmount = 0;

            // SQL Query for food inventory

            Console.WriteLine($"Current amount of {foodInvCheck} is: {productAmount}");
        }


        public void GetProductPrice(Enum productToPrice)
        {
            using var context = new joshfordproject0Context(s_dbContextOptions);

            FoodTypes foodToPrice = (FoodTypes) productToPrice;

            var priceOfFood = context.Products
                            .Select(x => x.ProductPrice)
                            .Where(x => x.Equals(foodToPrice.ToString()));
            Console.WriteLine($"{foodToPrice}: $ {priceOfFood}");
        }

    }

    public enum FoodTypes
    {
        Bagel,
        Bagel_With_Spread,
        Muffin,
        Muffin_With_Spread,
        Cheese_Pastry,
        Apple_Pastry,
        Strawberry_Pastry,
        Breakfast_Bagel,
        Hashbrowns
    }
}
