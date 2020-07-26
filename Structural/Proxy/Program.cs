using System;

namespace Proxy
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
