using System;

namespace FactoryMethod
{
    public class ProductA : IProduct
    {
        public bool CanShip(int month)
        {
            var canShip = month >= 1 && month <= 6;
            return canShip;
        }

        public void ShipFrom()
        {
            Console.WriteLine("Africa");
        }
    }
}