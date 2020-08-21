using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PrototypePattern
{
    [Serializable()]
    public abstract class Prototype<T>
    {
        public T DeepClone()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Seek(0, SeekOrigin.Begin);
            T copy = (T) formatter.Deserialize(stream);
            stream.Close( );
            return copy;
        }
    }
}