using System;

namespace joshford_project0
{
    public interface IProduct
    {
        public void AddProductToOrder(Enum productToAdd);

        public void CheckProductInventory(Enum productToCheck);

        public void GetProductPrice(Enum productToPrice);
    }
}
