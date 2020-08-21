using System;
using System.Collections.Generic;

namespace PrototypePattern
{
    public static class CountryManager
    {
        private static Dictionary<string, Country> _countries;

        static CountryManager()
        {
            _countries = new Dictionary<string, Country>();
        }

        public static Dictionary<string, Country> Countries 
        { 
            get { return _countries; } 
        }
    }
}