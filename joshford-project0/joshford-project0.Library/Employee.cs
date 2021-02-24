using System;
using System.Linq;
using System.Collections.Generic;
using joshford_project0.Database;

namespace joshford_project0
{
    public class Employee
    {
        private int _emplID;
        private int _storeID;
        private double _totalSalesAmount = 0.00;
        private int _totalSales = 0;
        private Dictionary<DateTime, double> _emplSales = new Dictionary<DateTime, double>();

        public Employee(int emplID, int storeID)
        {
            _emplID = emplID;
            _storeID = storeID;
        }

        /// <summary>
        /// Get and Set the employee ID
        /// </summary>
        public int EmployeeID { get => _emplID; set => _emplID = value; }

        /// <summary>
        /// Get and Set the store ID of an employee
        /// </summary>
        public int StoreID { get => _storeID; set => _storeID = value; }

        /// <summary>
        /// Adds a sale to an employees sale history using purchase date as
        ///     as the key, and order total for an employees overall sale amount
        /// </summary>
        /// <param name="purchaseDate"></param>
        /// <param name="orderTotal"></param>
        public void AddSaleToEmpl(DateTime purchaseDate, double orderTotal)
        {
            _emplSales.Add(purchaseDate, orderTotal);
        }

        /// <summary>
        /// Returns the employee sales dictionary and prints the dictionary
        ///     to the screen in the form of statistics
        /// </summary>
        /// <returns> Dictionary<DateTime, double> _emplSales </returns>
        public Dictionary<DateTime, double> EmplSaleStatistics()
        {
            Console.WriteLine("\tEmployee Sales Records:\n");
            foreach(KeyValuePair<DateTime, double> sale in _emplSales)
            {
                Console.WriteLine($"Date: {sale.Key}\tSale Amount: {sale.Value}");
            }
            Console.WriteLine($"      \tTotal Sales: {_totalSales}");
            Console.WriteLine($"      \tTotal Sales Amount: {_totalSalesAmount}");
            return _emplSales;
        }
    }
}
