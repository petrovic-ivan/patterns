using System;
using System.Collections.Generic;

namespace Flyweight
{
    // Intrinstic data about car.
    internal class CarFlyweight
    {
        public CarFlyweight(string color, string type)
        {
            this.Color = color;
            this.Type = type;
        }

        public string Color { get; }
        public string Type { get; }
    }
}