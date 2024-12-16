using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_11_2
{
    public class TextFileViewerFactory : IFileViewerFactory
    {
        public IFileViewer CreateFileViewer(string filePath)
        {
            return new TextFileViewer(filePath);
        }
    }
}
