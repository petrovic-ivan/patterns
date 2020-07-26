using System;

namespace Bridge
{
    internal class BoatImplementation : IBridge
    {
        public string OperationType => "Boat";

        public void Operation()
        {
            Console.WriteLine("Boat is navigating...");
        }
    }
}