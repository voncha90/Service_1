using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Service_1
{
    public class Service1NewtonTest
    {
        public  void Serialize(object obj)
        {
            const string filePath = @"C:\Users\vonch\Desktop\json.txt";
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter(filePath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, obj);
            }
        }
    }
}
