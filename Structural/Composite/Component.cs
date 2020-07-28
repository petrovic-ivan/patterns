using System;
using System.Collections.Generic;

namespace Structural.Comp
{
    public class Component<T> : IComponent<T>
    {
        private readonly T _id;

        public Component(T id)
        {
            _id = id;
        }

        public void Add(IComponent<T> c)
        {
            Console.WriteLine("Cannot add anymore!");
        }

        public IComponent<T> Find(T c)
        {
            Console.WriteLine("Cannot find, it is component!");
            return null;
        }

        public void Remove(T c)
        {
            Console.WriteLine("Cannot remove, it is component!");
        }

        public T Id => _id;
    }
}