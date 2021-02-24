using System;
using System.Linq;
using System.Collections.Generic;
using joshford_project0.Library;

namespace joshford_project0
{
    public class CustomerValidate
    {

        bool idIsValid = false;

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
            var context = new joshfordproject0Context();

            context = DataAccess_Library.OpenDatabaseConnection();

            if(idToValidate.Equals(context.Customers
                .Select(x => x.CustomerId)
                .Where(x => x.Equals(idToValidate))))
            {
                idIsValid = true;
            }

            return idIsValid;
        }
    }
}
