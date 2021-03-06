﻿using System.IO;
using System.Runtime.Serialization.Json;

namespace Mach.Banking
{
    public class JsonSerializer
    {
        public string Serialize<T>(T instance) where T : class
        {
            var serializer = new DataContractJsonSerializer(typeof(T));
            using (var memoryStream = new MemoryStream())
            {
                serializer.WriteObject(memoryStream, instance);

                memoryStream.Flush();
                memoryStream.Position = 0;

                using (var reader = new StreamReader(memoryStream))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        public T Deserialize<T>(string serialized) where T : class
        {
            var serializer = new DataContractJsonSerializer(typeof(T));
            using (var memoryStream = new MemoryStream())
            {
                using (var writer = new StreamWriter(memoryStream))
                {
                    writer.Write(serialized);
                    writer.Flush();

                    memoryStream.Position = 0;

                    return serializer.ReadObject(memoryStream) as T;
                }
            }
        }

        public T Deserialize<T>(Stream stream) where T : class
        {
            var serializer = new DataContractJsonSerializer(typeof(T));
            return serializer.ReadObject(stream) as T;
        }
    }
}
