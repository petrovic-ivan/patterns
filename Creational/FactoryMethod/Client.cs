using System;

namespace FactoryMethod
{
    public class Client : IClient
    {
        ICreator _creator;
        public Client(ICreator creator)
        {
            _creator = creator;
        }

        public void Execute()
        {
            var prod1 = _creator.FactoryMethod(2);
            prod1.ShipFrom();

            var prod2 = _creator.FactoryMethod(8);
            prod2.ShipFrom();
        }
    }
}