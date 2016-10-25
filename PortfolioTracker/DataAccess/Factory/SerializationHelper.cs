using System.IO;
using System.Runtime.Serialization;


namespace DataAccess.Factory
{
    //helper class to deserialize file data to type T
    public static class SerializationHelper<T>
    {
        private static DataContractSerializer _serializer = new DataContractSerializer(typeof(T));

        public static T Deserialize(Stream source)
        {
            return (T)_serializer.ReadObject(source);
        }

   }
}
