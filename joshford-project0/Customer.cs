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
        /// Set customer name to the name input
        /// </summary>
        /// <param name="custName"></param>
        public void SetCustName(string custName)
        {
            _custName = custName;
        }

        /// <summary>
        /// Retrieve customer name for search purposes
        /// </summary>
        /// <returns> string _custName </returns>
        public string GetCustName()
        {
            return _custName;
        }

        /// <summary>
        /// Set a preferred store location for orders for a customer
        /// </summary>
        /// <param name="storeID"></param>
        public void SetStoreID(int storeID)
        {
            _storeID = storeID;
        }

        /// <summary>
        /// Retrieve a customers preferred store location
        /// </summary>
        /// <returns> int _storeID </returns>
        public int GetStoreID()
        {
            return _storeID;
        }
    }
}
