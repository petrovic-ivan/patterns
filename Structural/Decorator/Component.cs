using System;

namespace Decorator
{
    public class Component : IComponent
    {
        public void DoWork()
        {
            Console.WriteLine("Here some work.");
        }
    }
}