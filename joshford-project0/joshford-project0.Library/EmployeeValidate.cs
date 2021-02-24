using System;
using System.Linq;
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
            var context = new joshfordproject0Context();

            context = DataAccess_Library.OpenDatabaseConnection();

            if (idToValidate.Equals(context.Employees
                .Select(x => x.EmployeeId)
                .Where(x => x.Equals(idToValidate))))
            {
                idIsValid = true;
            }

            return idIsValid;
        }
    }
}
