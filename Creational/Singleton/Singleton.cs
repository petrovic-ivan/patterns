using System;

namespace SingletonPattern
{
    public class Singleton <T> where T : class, new()
    {
        private Singleton() {}

        private class SingletonCreator
        {
            static SingletonCreator() {}
            internal static readonly DbContext Instance = new DbContext();
        }

        public static DbContext Instance 
        {
            get { return SingletonCreator.Instance; }
        }
    }
}