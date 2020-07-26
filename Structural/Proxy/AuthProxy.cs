using System;

namespace Proxy
{
    internal class AuthProxy : IProxy
    {
        private readonly Subject _subject;
        public AuthProxy()
        {
            _subject = new Subject();
        }

        public void Request()
        {
            var counter = 0;
            while(true)
            {
                Console.WriteLine("Enter your password:");
                var name =  Console.ReadLine();
                if (string.Equals(name, "ivan", StringComparison.CurrentCultureIgnoreCase))
                {
                    _subject.Request();
                    break;
                }
                else 
                {
                    Console.WriteLine("No Subject for you :(");
                }
                counter++;
                if (counter == 3)
                {
                    break;
                }
            }
        }
    }
}