using System;
using System.Collections.Generic;

namespace joshford_project0
{
    public class Order
    {
        private List<CoffeeTypes> customerCoffee = new List<CoffeeTypes>();
        private List<FoodTypes> customerFood = new List<FoodTypes>();
        private double currentOrderTotal = 0.00;

        /// <summary>
        /// Retrieve the total order price of the given customers order
        /// </summary>
        public double GetTotalOrderPrice()
        {
            return currentOrderTotal;
        }

        /// <summary>
        /// Add to the total order price of the given customers order
        /// </summary>
        public void SetTotalOrderPrice(double itemToAdd)
        {
            currentOrderTotal += itemToAdd;
        }

        /// <summary>
        /// Add a coffee product to the current customers order
        /// </summary>
        /// <param name="item"></param>
        public void AddCoffeeToOrder(CoffeeTypes coffeeProduct)
        {
            Coffee coffee = new Coffee();

            customerCoffee.Add(coffeeProduct);
            this.SetTotalOrderPrice(coffee.GetProductPrice(coffeeProduct));
        }

        /// <summary>
        /// Add a food product to the current customers order
        /// </summary>
        public void AddFoodToOrder(FoodTypes foodProduct)
        {
            Food food = new Food();

            customerFood.Add(foodProduct);
            this.SetTotalOrderPrice(food.GetProductPrice(foodProduct));
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

            Console.WriteLine($"Current Order Total:\t{currentOrderTotal}");

        }


    }
}
