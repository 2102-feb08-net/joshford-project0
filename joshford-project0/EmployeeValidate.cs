using System;
using joshford_project0.Library;

namespace joshford_project0
{
    public class EmployeeValidate
    {
        bool idIsValid = false;

        /// <summary>
        /// Employee Validation constructor
        /// </summary>
        public EmployeeValidate() { }

        /// <summary>
        /// Passes the employee ID to an SQL query to check if the ID exists
        ///     in the employees database
        /// </summary>
        /// <param name="idToValidate"></param>
        /// <returns> boolean idIsValid </returns>
        public bool ValidateID(int idToValidate)
        {
            DataAccess_Library dataAccess = new DataAccess_Library();
            var context = new joshfordproject0Context();

            context = DataAccess_Library.OpenDatabaseConnection();
            // Passes idToValidate to SQL Query to check against employee table

            return idIsValid;
        }
    }
}
