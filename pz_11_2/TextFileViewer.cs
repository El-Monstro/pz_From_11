using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_11_2
{
    public class TextFileViewer : IFileViewer
    {
        private string _filePath;

        public TextFileViewer(string filePath)
        {
            _filePath = filePath;
        }

        public void DisplayFile()
        {
            string content = File.ReadAllText(_filePath);
            Console.WriteLine("Содержимое текстового файла:");
            Console.WriteLine(content);
        }
    }
}
