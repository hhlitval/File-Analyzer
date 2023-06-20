using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Analyzer.Models
{
    public class FileItem
    {
        public string? FileName { get; set; }
        public string? FilePath { get; set; }
        public double FileSize { get; set; }
    }
}
