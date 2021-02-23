using System;
using System.Collections.Generic;
using System.Linq;
using joshford_project0.Library;

namespace joshford_project0
{
    public class Food : IProduct
    {
        private List<FoodTypes> currentOrder = new List<FoodTypes>();

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
            DataAccess_Library dataAccess = new DataAccess_Library();
            var context = new joshfordproject0Context();

            context = DataAccess_Library.OpenDatabaseConnection();

            FoodTypes foodInvCheck = (FoodTypes)productToCheck;
            int productAmount = 0;

            // SQL Query for food inventory

            Console.WriteLine($"Current amount of {foodInvCheck} is: {productAmount}");
        }


        public double GetProductPrice(Enum productToPrice)
        {
            DataAccess_Library dataAccess = new DataAccess_Library();
            var context = new joshfordproject0Context();

            context = DataAccess_Library.OpenDatabaseConnection();

            FoodTypes foodPrice = (FoodTypes) productToPrice;
            double priceOfFood = 0;

            // SQL Query for food Prices

            return priceOfFood;
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
