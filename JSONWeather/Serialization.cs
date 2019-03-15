using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;

namespace JSONWeather
{
    public class Serialization 
    {
        public static void CreateJSONFile(RootObject obj)
        {
            string JSONstring = string.Empty;

            MemoryStream stream = new MemoryStream();

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(RootObject));

            ser.WriteObject(stream, obj);

            stream.Position = 0;

            var JSONFile = File.Create("JSON.txt");

            stream.Seek(0, SeekOrigin.Begin);

            stream.CopyTo(JSONFile);

            Console.WriteLine("Файл с JSON создан.");
           

           
        }
        
    }
}
