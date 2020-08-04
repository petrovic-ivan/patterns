using System;

namespace Facade
{
    public class Client : IClient
    {
        private readonly IFacade _facade;
        
        public Client(IFacade facade)
        {
            _facade = facade;
        }

        public void Execute()
        {
            var text = _facade.ExecuteOperations();
            Console.WriteLine(text);
        }
    }
}