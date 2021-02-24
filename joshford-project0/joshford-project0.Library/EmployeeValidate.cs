using System;
using System.Linq;
using System.Collections.Generic;
using joshford_project0.Database;
using Microsoft.EntityFrameworkCore;

namespace joshford_project0
{
    public class EmployeeValidate
    {
        bool idIsValid = false;
        static DbContextOptions<joshfordproject0Context> s_dbContextOptions = new DbContextOptions<joshfordproject0Context>();

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
            using var context = new joshfordproject0Context(s_dbContextOptions);

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
