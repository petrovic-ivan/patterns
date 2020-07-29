using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Flyweight
{
    // Maintain intrinstic data in collection.
    internal static class CarFlyweightFactory
    {
        private static List<CarFlyweight> _cache = new List<CarFlyweight>();

        public static CarFlyweight GetCarFlyweightType(string color, string type)
        {
            var flyweight = _cache.FirstOrDefault(e => e.Color == color && e.Type == type);
            if (flyweight == null)
            {
                flyweight = new CarFlyweight(color, type);
                _cache.Add(flyweight);
            }            
            return flyweight;
        }
    }
}