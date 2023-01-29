using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;
using Lab4;
using System.Xml.Serialization;
namespace Lab13
{
    public static class Serializer
    {
         public static void Serialize<T>(T obj, string type, string filename)
        {
            switch (type)
            {
                case "bin":
                    {
                        using (FileStream fs = new FileStream($"{ filename }.dat", FileMode.OpenOrCreate))
                        {
                            BinaryFormatter formatter = new BinaryFormatter();
                            formatter.Serialize(fs, obj);

                            Console.WriteLine("Объект сериализован");
                        }
                        break;
                    }
                case "xml":
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Stone));

                        using (FileStream fs = new FileStream($"{ filename }.xml", FileMode.OpenOrCreate))
                        {
                            xmlSerializer.Serialize(fs, obj);
                        }

                        break;
                    }
                case "json":
                    {
                        using (FileStream fs = new FileStream($"{filename}.json", FileMode.OpenOrCreate))
                        {

                             JsonSerializer.Serialize<T>(fs, obj);
                        }

                        break;
                    }
            }

        }
         public static T Deserialize<T>(string type, string filename)
        {
            T res = default(T);
            switch (type)
            {
                case "bin":
                    {
                        using (FileStream fs = new FileStream($"{filename }.dat", FileMode.OpenOrCreate))
                        {
                            BinaryFormatter formatter = new BinaryFormatter();
                            T result = (T)formatter.Deserialize(fs);
                            return result;

                        }

                        break;
                    }
                case "xml":
                    {
                        using (FileStream fs = new FileStream($"{ filename }.xml", FileMode.OpenOrCreate))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                            T? result = (T?)xmlSerializer.Deserialize(fs);
                            return result;
                        }

                        break;
                    }
                case "json":
                    {
                        using (FileStream fs = new FileStream($"{ filename }.json", FileMode.OpenOrCreate))
                        {
                            T? result =  JsonSerializer.Deserialize<T>(fs);
                            return result;
                        }

                        break;
                    }
                    
            }
            return res;
        }

        public static void ArrayJSONSerialize<T>(T[] arr, string filename )
        {
           
                using (FileStream fs = new FileStream($"{filename}.json", FileMode.OpenOrCreate))
                {

                    JsonSerializer.Serialize<T[]>(fs, arr);
                }
            
        }
        public static T[] ArrayJSONDeserialize<T>(string filename)
        {

            using (FileStream fs = new FileStream($"{ filename }.json", FileMode.OpenOrCreate))
            {
                T[]? result = JsonSerializer.Deserialize<T[]>(fs);
                return result;
            }

        }
    }
}
