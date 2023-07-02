using System;
using System.Collections.Generic;
using Serilog;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File_Analyzer.Models;

namespace File_Analyzer.ViewModels
{
    public class GetDirectoryFilesViewModel : BaseViewModel
    {        
        public IEnumerable<FileItem>? FileItems { get; set; }

        public GetDirectoryFilesViewModel(string folderPath)
        {
            DirectoryInfo dir = new DirectoryInfo(folderPath);
            IEnumerable<FileInfo> fileList = dir.GetFiles("*.*", SearchOption.AllDirectories);
            FileItems = fileList.Select(fileInfo => new FileItem
            {
                FileName = fileInfo.Name,
                FilePath = fileInfo.DirectoryName,
                FileSize = fileInfo.Length
            }).OrderByDescending(x => x.FileSize);        
        }        
    }            
}