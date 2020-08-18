using System;

namespace FactoryMethod
{
    public class ProductB : IProduct
    {
        public bool CanShip(int month)
        {
            var canShip = month >= 7 && month <= 12;
            return canShip;
        }

        public void ShipFrom()
        {
            Console.WriteLine("Spain");
        }
    }
}