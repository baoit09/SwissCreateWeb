using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.IO;

namespace SwissCreateWeb.Framework.Helpers
{
    public static class SerializerHelper
    {
        /// <summary>
        /// Serialize a object of the specified type into byte array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static byte[] Serialize<T>(T item) where T : class
        {
            var dc = new DataContractSerializer(typeof(T));
            using (MemoryStream stream = new MemoryStream())
            {
                dc.WriteObject(stream, item);
                return stream.ToArray();
            }
        }

        /// <summary>
        /// Serialize a object array of the specified type into byte array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static byte[] SerializeArray<T>(T[] items) where T : class
        {
            var dc = new DataContractSerializer(typeof(T[]));
            using (MemoryStream stream = new MemoryStream())
            {
                dc.WriteObject(stream, items);
                return stream.ToArray();
            }
        }

        /// <summary>
        /// Deserialize byte array into the object of the specified type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static T Deserialize<T>(byte[] data) where T : class
        {
            if (data == null || data.Length == 0)
                return null;
            using (Stream stream = new MemoryStream())
            {
                try
                {
                    stream.Write(data, 0, data.Length);
                    stream.Position = 0;
                    DataContractSerializer deserializer = new DataContractSerializer(typeof(T));
                    return (T)deserializer.ReadObject(stream);
                }
                catch
                {
                    return null;
                }
                }

            //var dc = new DataContractSerializer(typeof(T));
            //using (MemoryStream stream = new MemoryStream(data))
            //{
            //    try
            //    {
            //        return (T)dc.ReadObject(stream);
            //    }
            //    catch
            //    {
            //        // Exception throwed when the type to deseriable is not matching to the type to serialize
            //        return null;
            //    }
            //}
        }

        /// <summary>
        /// Deserialize byte array into the object array of the specified type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static T[] DeserializeArray<T>(byte[] data) where T : class
        {
            var dc = new DataContractSerializer(typeof(T[]));
            using (MemoryStream stream = new MemoryStream(data))
            {
                try
                {
                    return (T[])dc.ReadObject(stream);
                }
                catch
                {
                    // Exception throwed when the type to deseriable is not matching to the type to serialize
                    return null;
                }
            }
        }
    }
}
