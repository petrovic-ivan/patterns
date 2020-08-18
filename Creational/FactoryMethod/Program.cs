using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = Startup.ConfigureEntryPoint<IClient>();
            client.Execute();
        }
    }
}
