using System;
using System.Linq;
using System.Collections.Generic;
using joshford_project0.Database;
using Microsoft.EntityFrameworkCore;

namespace joshford_project0
{
    public class CustomerC
    {
        private int _custID;
        private int _storeID = 1;       // 1 is the main store location
        private string _custFirstName;
        private string _custLastName;
        private int _phoneNumber;
        static DbContextOptions<joshfordproject0Context> s_dbContextOptions = DataAccess_Library.OpenDatabaseConnection();

        // Constructor for new customer with no store id or records
        public CustomerC() { }

        // Constructor for returning customer with customer and store id
        public CustomerC(int custID)
        {
            _custID = custID;

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

        public static int CreateCustomerID()
        {
            int customerID = 1;
            using var context = new joshfordproject0Context(s_dbContextOptions);

            //customerID = context.Customers.Select(x => x.CustomerId).Count();
            if(customerID != 0)
            {
                customerID++;
            }

            return customerID;
        }

        /* 
         *  Method does not work at this time
         * 
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

            for (int i = 0; i < custName.Length; i++)
            {
                nameChars[i] = custName[i];
                if(i == 0)
                {
                    firstLetter = nameChars[i].ToString().ToUpper();
                }
                else
                {
                    formattedChars[i] = nameChars[i];
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
        */

        /// <summary>
        /// Creates a new customer and adds the customer to the SQL database
        ///     customer table, then sets the local customerID from
        ///     the SQL customer table
        /// </summary>
        public int AddNewCustomer(string custFirstName, string custLastName)
        {
            _custID = CreateCustomerID();

            using var context = new joshfordproject0Context(s_dbContextOptions);
            var customer = new Customer
            {
                CustomerId = _custID,
                CustomerFirstName = _custFirstName,
                CustomerLastName = _custLastName,
                StoreId = _storeID
            };

            context.Customers.Add(customer);

            // context.SaveChanges();

            return _custID;
        }
    }
}
