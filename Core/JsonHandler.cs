using Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Core
{
    public class JsonHandler
    {
        public static void SaveToFile(Furniture f, string fileName)
        {
            if (!File.Exists(fileName))
            {
                using (var tw = new StreamWriter(fileName, true))
                {
                    tw.WriteLine("[");
                    var json = JsonConvert.SerializeObject(f);
                    tw.WriteLine(json);
                    tw.WriteLine("]");
                }
            }
            else
            {
                var listFurniture = ReadFromFile(fileName);
                listFurniture.Add(f);
                var json = JsonConvert.SerializeObject(listFurniture);
                File.WriteAllText(fileName, json);
            }
        }

        public static List<Furniture> ReadFromFile(string fileName)
        {
            string jsonString = System.IO.File.ReadAllText(fileName);

            var result = JsonConvert.DeserializeObject<List<Furniture>>(jsonString);
            return (List<Furniture>)result;
        }
    }
}
