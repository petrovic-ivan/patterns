using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PrototypePattern
{
    [Serializable()]
    public class Country : Prototype<Country>
    {
        public string Name {get; set;}
        public string Capital {get; set;}
        public Language Language {get; set;}

        public Country(string name, string capital, Language language)
        {
            Name = name;
            Capital = capital;
            Language = language;
        }
    }
}