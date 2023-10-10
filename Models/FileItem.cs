using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Analyzer.Models
{
    public class FileItem
    {
        private double _fileSize;
        public string? FileName { get; set; }
        public string? FilePath { get; set; }

        public double FileSize 
        {
            get { return Math.Round(_fileSize / 1024 / 1024, 1); }
            set { _fileSize = value; }
        }  
    }
}
