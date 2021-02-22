using System;
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
            // Pass idToValidate to SQL query to check against customer table

            return idIsValid;
        }
    }
}
