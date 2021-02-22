using System;

namespace joshford_project0
{
    public class Customer
    {
        private int _custID = 0;
        private int _storeID = 0;
        private string _custFirstName;
        private string _custLastName;

        // Constructor for customer with no store id
        public Customer(string custFirstName, string custLastName)
        {
            _custFirstName = custFirstName;
            _custLastName = custLastName;
            _custID = this.CreateNewCustomer();
        }

        // Constructor for customer with store id
        /*
        public Customer(int custID, int storeID)
        {
            _custID = custID;
            _storeID = storeID;
        }
        */

        /// <summary>
        /// Get and set customer first name
        /// </summary>
        public string CustFirstName { get => _custFirstName; set => _custFirstName = value; }

        /// <summary>
        /// Get and set customer last name
        /// </summary>
        public string CustLastName { get => _custLastName; set => _custLastName = value; }

        /// <summary>
        /// Get and set the customer ID
        /// </summary>
        public int CustID { get => _custID; set => _custID = value; }

        /// <summary>
        /// Get and set customer store ID
        /// </summary>
        public int StoreID { get => _storeID; set => _storeID = value; }

        public void FormatCustomerName(string custFirstName, string custLastName)
        {
            
        }

        /// <summary>
        /// Creates a new customer and adds the customer to the SQL database
        ///     customer table, then sets the local customerID from
        ///     the SQL customer table
        /// </summary>
        public int CreateNewCustomer()
        {
            int newCustomerID = 0;


            return newCustomerID;
        }
    }
}
