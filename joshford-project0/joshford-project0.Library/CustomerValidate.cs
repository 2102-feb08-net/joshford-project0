using System;
using System.Linq;
using System.Collections.Generic;
using joshford_project0.Database;
using Microsoft.EntityFrameworkCore;

namespace joshford_project0
{
    public class CustomerValidate
    {

        bool idIsValid = false;
        static DbContextOptions<joshfordproject0Context> s_dbContextOptions = DataAccess_Library.OpenDatabaseConnection();

        /// <summary>
        /// Customer Validation constructor
        /// </summary>
        public CustomerValidate() { }

        /// <summary>
        /// Passes the customer ID to an SQL query to check if the ID exists
        ///     in the customer database
        /// </summary>
        /// <param name="idToValidate"></param>
        /// <returns> boolean idIsValid </returns>
        public bool ValidateID(int idToValidate)
        {
            using var context = new joshfordproject0Context(s_dbContextOptions);

            if(idToValidate.Equals(context.Customers
                .Select(x => x.CustomerId)
                .Where(x => x.Equals(idToValidate))))
            {
                idIsValid = true;
            }

            return idIsValid;
        }

        public bool ValidateName(string custName)
        {
            using var context = new joshfordproject0Context(s_dbContextOptions);

            if (custName.Contains(" "))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
