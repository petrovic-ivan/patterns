using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var entryPoint = Startup.ConfigureEntryPoint<IClient>();
            entryPoint.Execute();
        }
    }
}
