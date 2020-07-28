using System;
using System.Collections.Generic;

namespace Structural.Comp
{
    public class Composite<T> : IComponent<T>, IIterator<T>
    {
        private readonly List<IComponent<T>> _list;

        private readonly T _id;

        private IComponent<T> _holder;

        public Composite(T id)
        {
            _id = id;
            _list = new List<IComponent<T>>();
        }

        public T Id => _id;

        public void Add(IComponent<T> c)
        {
            _list.Add(c);
        }

        public IComponent<T> Find(T c)
        {
            _holder = this;
            IComponent<T> result = null;
            if (_id.Equals(c)) return this;
            foreach (var i in _list)
            {
                if (i.Id.Equals(c))
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        public void Remove(T c)
        {
            _holder = this;
            var comp = _holder.Find(c);
            if (comp != null)
            {
                ((Composite<T>)_holder)._list.Remove(comp);
            }
        }

        public void DisplayAll()
        {
            DisplayAll(this, string.Empty);
        }  

        private void DisplayAll(IComponent<T> c, string tab)
        {
            Console.WriteLine(tab + $"--------- Group: {c.Id} ---------");
            foreach (var item in ((Composite<T>)c)._list)
            {
                Console.WriteLine(tab + item.Id);
                if (item is IIterator<T>)
                {
                    tab += "\t";
                    DisplayAll(item, tab);
                }
            }
        }   

    }
}