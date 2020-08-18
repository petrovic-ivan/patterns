using System.Collections.Generic;
using System.Linq;

namespace FactoryMethod
{
    public class Creator : ICreator
    {
        private IEnumerable<IProduct> _products;
        public Creator(IEnumerable<IProduct> products)
        {
            _products = products;
        }

        public IProduct FactoryMethod(int month)
        {
            var product = _products.First(p => p.CanShip(month));
            return product;
        }
    }
}