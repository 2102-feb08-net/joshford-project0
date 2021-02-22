using System;

namespace joshford_project0
{
    public interface IProduct
    {
        public void AddProductToOrder(Enum productToAdd);

        public void CheckProductInventory(Enum productToCheck);

        public double GetProductPrice(Enum productToPrice);
    }
}
