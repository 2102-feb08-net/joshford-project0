using System;
using System.Collections.Generic;

namespace joshford_project0
{
    public class Order
    {
        private List<string> customerOrder = new List<string>();
        private int customerOrderPrice = 0;

        /// <summary>
        /// Retrieve the total order price of the given customers order
        /// </summary>
        public int GetTotalOrderPrice()
        {
            return customerOrderPrice;
        }

        /// <summary>
        /// Add to the total order price of the given customers order
        /// </summary>
        public void SetTotalOrderPrice(int itemToAdd)
        {
            customerOrderPrice += itemToAdd;
        }

        /// <summary>
        /// Add to the given customers order
        /// </summary>
        /// <param name="item"></param>
        public void AddToOrder(string item)
        {
            customerOrder.Add(item);
        }

        /// <summary>
        /// Retrieve the given customers order
        /// </summary>
        public List<string> OrderItems { get; }


    }
}
