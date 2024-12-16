using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace pz_11_2
{
    public class JsonFileViewer : IFileViewer
    {
        private string _filePath;

        public JsonFileViewer(string filePath)
        {
            _filePath = filePath;
        }

        public void DisplayFile()
        {
            string jsonContent = File.ReadAllText(_filePath);
            var jsonData = JsonConvert.DeserializeObject(jsonContent);

            Console.WriteLine("Десериализованные данные из JSON файла:");
            Console.WriteLine(JsonConvert.SerializeObject(jsonData, (Newtonsoft.Json.Formatting)System.Xml.Formatting.Indented));
        }
    }
}
