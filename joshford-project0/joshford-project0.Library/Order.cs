using System;
using System.Linq;
using System.Collections.Generic;
using joshford_project0.Database;
using Microsoft.EntityFrameworkCore;

namespace joshford_project0
{
    public class Order
    {
        private List<CoffeeTypes> customerCoffee = new List<CoffeeTypes>();
        private List<FoodTypes> customerFood = new List<FoodTypes>();
        private double _currentOrderTotal = 0.00;
        private int _customerID;
        private int _employeeID;
        private int _storeID;
        private DateTime currentDate;
        static DbContextOptions<joshfordproject0Context> s_dbContextOptions;


        public Order(int custID, int emplID, int storeID)
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
        public void AddCoffeeToOrder(CoffeeTypes coffeeProduct, int quantity)
        {
            Coffee coffee = new Coffee();

            customerCoffee.Add(coffeeProduct);
            this.AddToTotalOrderPrice(coffee.GetProductPrice(coffeeProduct) * quantity);
        }

        /// <summary>
        /// Add a food product to the current customers order
        /// Multiplies given food product by amount purchased and passes to 
        ///     AddToTotal_ method
        /// </summary>
        /// <param name="foodProduct"></param>
        ///<param name="quantity"></param>
        public void AddFoodToOrder(FoodTypes foodProduct, int quantity)
        {
            Food food = new Food();

            customerFood.Add(foodProduct);
            this.AddToTotalOrderPrice(food.GetProductPrice(foodProduct));
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

            Console.WriteLine($"Current Order Total:\t{this.TotalOrderPrice}");

        }

        /// <summary>
        /// Finalizes the placed order by removing given products from the stores
        ///     inventory, adding order to Orders table and Employees/Customers
        ///     history tables
        /// </summary>
        public void PlaceOrder()
        {
            using var context = new joshfordproject0Context(s_dbContextOptions);

            

            //context.Orders;
        }
    }
}
