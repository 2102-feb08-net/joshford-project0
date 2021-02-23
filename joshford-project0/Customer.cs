using System;
using System.Collections.Generic;
using System.Linq;
using joshford_project0.Library;

namespace joshford_project0
{
    public class Customer
    {
        private int _custID = 0;
        private int _storeID = 0;
        private string _custFirstName;
        private string _custLastName;
        private int _phoneNumber;

        // Constructor for new customer with no store id or records
        public Customer(string custFirstName, string custLastName)
        {
            _custFirstName = FormatCustomerName(custFirstName);
            _custLastName = FormatCustomerName(custLastName);
            _custID = CreateNewCustomer();
        }

        // Constructor for returning customer with customer and store id
        public Customer(int custID, int storeID)
        {
            _custID = custID;
            _storeID = storeID;
        }

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

        /// <summary>
        /// Get and set customer phone number(not required)
        /// </summary>
        public int PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }

        /// <summary>
        /// Correctly formats the given customer's first and last name
        /// </summary>
        /// <param name="custFirstName"></param>
        /// <param name="custLastName"></param>
        public static string FormatCustomerName(string custName)
        {
            string custNameFormat;
            string firstLetter = null;
            string otherLetters = null;
            List<char> nameChars = new List<char>();
            List<char> formattedChars = new List<char>();

            foreach(int index in custName)
            {
                nameChars[index] = custName[index];
                if(index == 0)
                {
                    firstLetter = nameChars[index].ToString().ToUpper();
                }
                else
                {
                    formattedChars[index] = nameChars[index];
                }
            }

            foreach(int index in formattedChars)
            {
                otherLetters += formattedChars[index].ToString();
            }

            firstLetter += otherLetters;
            custNameFormat = firstLetter;

            return custNameFormat;
        }

        /// <summary>
        /// Creates a new customer and adds the customer to the SQL database
        ///     customer table, then sets the local customerID from
        ///     the SQL customer table
        /// </summary>
        public static int CreateNewCustomer()
        {
            DataAccess_Library dataAccess = new DataAccess_Library();
            var context = new joshfordproject0Context();

            context = DataAccess_Library.OpenDatabaseConnection();

            int newCustomerID = 0;

            return newCustomerID;
        }
    }
}
