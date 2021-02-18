using System;
using System.Collections.Generic;

namespace joshford_project0
{
    public class Employee
    {
        private int _emplID;
        private int _storeID;
        private double _totalSales = 0.00;
        private int _totalAmountSales = 0;
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

        public Dictionary<DateTime, double> EmplSaleStatistics()
        {
            return _emplSales;
        }
    }
}
