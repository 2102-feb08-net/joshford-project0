using System;
using System.Collections.Generic;

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
            FoodTypes foodInvCheck = (FoodTypes)productToCheck;
            int productAmount = 0;


            Console.WriteLine($"Current amount of {foodInvCheck} is: {productAmount}");
        }


        public double GetProductPrice(Enum productToPrice)
        {
            FoodTypes foodPrice = (FoodTypes) productToPrice;
            double priceOfFood;

            switch(foodPrice)
            {
                case FoodTypes.Bagel:
                    priceOfFood = 2.99;
                    return priceOfFood;

                case FoodTypes.Bagel_With_Spread:
                    priceOfFood = 3.49;
                    return priceOfFood;

                case FoodTypes.Muffin:
                    priceOfFood = 3.49;
                    return priceOfFood;

                case FoodTypes.Muffin_With_Spread:
                    priceOfFood = 3.99;
                    return priceOfFood;

                case FoodTypes.Cheese_Pastry:
                    priceOfFood = 1.99;
                    return priceOfFood;

                case FoodTypes.Apple_Pastry:
                    priceOfFood = 1.99;
                    return priceOfFood;

                case FoodTypes.Strawberry_Pastry:
                    priceOfFood = 1.99;
                    return priceOfFood;

                case FoodTypes.Breakfast_Bagel:
                    priceOfFood = 4.49;
                    return priceOfFood;

                case FoodTypes.Hashbrowns:
                    priceOfFood = 0.99;
                    return priceOfFood;

                default:
                    priceOfFood = 0.00;
                    return priceOfFood;
            }
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
