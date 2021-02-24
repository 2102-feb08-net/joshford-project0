using System;

namespace joshford_project0
{
    public interface IValidate
    {
        /// <summary>
        /// Used to validate the ID is correct length, then checks if the ID
        ///     exists in the corresponding employee/customer table
        /// </summary>
        /// <param name="idToValidate"></param>
        /// <returns></returns>
        public bool validateID(int idToValidate);

    }
}
