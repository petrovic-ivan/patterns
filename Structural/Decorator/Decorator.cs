using System;

namespace Decorator
{
    public class Decorator : IComponent
    {
        private readonly IComponent _component;
        public Decorator(IComponent component)
        {
            _component = component;
        }

        public void DoWork()
        {
            Console.WriteLine("------------------");
            _component.DoWork();
            Console.WriteLine("------------------");
        }
    }
}