using System;
namespace joshford_project0
{
    public class EmployeeValidate
    {
        bool idIsValid = false;

        /// <summary>
        /// Employee Validation constructor
        /// </summary>
        public EmployeeValidate() { }


        public bool validateID(int idToValidate)
        {
            // Passes idToValidate to SQL Query to check against employee table

            return idIsValid;
        }
    }
}
