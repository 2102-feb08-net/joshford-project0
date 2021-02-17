using System;

namespace joshford_project0
{
    public class Customer
    {
        private int _custID = 0;
        private int _storeID = 0;
        private string _custName;

        // Constructor for customer with no store id
        public Customer(int custID)
        {
            _custID = custID;
        }

        // Constructor for customer with store id
        public Customer(int custID, int storeID)
        {
            _custID = custID;
            _storeID = storeID;
        }

        /// <summary>
        /// Get and set customer name
        /// </summary>
        public string CustName { get => _custName; set => _custName = value; }

        /// <summary>
        /// Get and set the customer ID
        /// </summary>
        public int CustID { get => _custID; set => _custID = value; }

        /// <summary>
        /// Get and set customer store ID
        /// </summary>
        public int StoreID { get => _storeID; set => _storeID = value; }
    }
}
