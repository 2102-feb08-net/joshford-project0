using System;
namespace joshford_project0
{
    public interface IValidate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="custID"></param>
        /// <returns></returns>
        public void CustomerValidate(int custID) { };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="storeID"></param>
        /// <returns></returns>
        public void StoreValidate(int storeID) { };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="emplID"></param>
        /// <returns></returns>
        public void EmployeeValidate(int emplID)  { };
    }
}
