using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PrototypePattern
{
    [Serializable()]
    public class Language
    {
        public string Name {get; set;}
        public string Code {get; set;}
        
        public Language(string name, string code)
        {
            Name = name;
            Code = code;
        }
    }
}