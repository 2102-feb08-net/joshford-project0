using System;

namespace joshford_project0
{
    public class Employee
    {
        private int _emplID;
        private int _storeID;

        public Employee(int emplID, int storeID)
        {
            _emplID = emplID;
            _storeID = storeID;
        }

        /// <summary>
        /// Returns the ID of the employee
        /// </summary>
        /// <returns> int _emplID </returns>
        public int GetEmployeeID() => _emplID;

        /// <summary>
        /// Sets an employee's ID, used for new employees
        /// </summary>
        /// <param name="emplID"></param>
        public void SetEmployeeID(int emplID) => _emplID = emplID;

        /// <summary>
        /// Returns the store ID the employee works at
        /// </summary>
        /// <returns> int _storeID </returns>
        public int GetStoreID() => _storeID;

        /// <summary>
        /// Sets an employee's store ID, or workplace location
        /// </summary>
        /// <param name="storeID"></param>
        public void SetStoreID(int storeID) => _storeID = storeID;


    }
}
