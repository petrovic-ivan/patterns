using System;

namespace SingletonPattern
{
    public class DbContext
    {
        public void PrintFromDb(int num)
        {
            Console.WriteLine($"This is from DB: {num}. Here is object hash code: " + this.GetHashCode());
        }
    }
}