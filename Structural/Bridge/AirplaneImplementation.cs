using System;

namespace Bridge
{
    internal class AirplaneImplementation : IBridge
    {
        public string OperationType => "Airplane";

        public void Operation()
        {
            Console.WriteLine("Airplane is flying...");
        }
    }
}