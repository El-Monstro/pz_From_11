using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_11_2
{
    public class ImageFileViewer : IFileViewer
    {
        private string _filePath;

        public ImageFileViewer(string filePath)
        {
            _filePath = filePath;
        }

        public void DisplayFile()
        {
            // Здесь можно использовать библиотеку, например, для работы с изображениями (например, System.Drawing)
            Console.WriteLine($"Отображаем изображение: {_filePath}");
        }
    }
}
