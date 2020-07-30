using System;

namespace Adapter
{
    public class Client : IClient
    {
        private readonly ITarget _target;
        
        public Client(ITarget target)
        {
            _target = target;
        }

        public void Execute()
        {
            var person = _target.GetPerson();
            Console.WriteLine($"ID: {person.Id}, FirstName: {person.FirstName}, LastName: {person.LastName}, DoB: {person.DoB.ToString()}.");
        }
    }
}