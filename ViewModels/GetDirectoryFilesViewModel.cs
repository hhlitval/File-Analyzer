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
        private const string LogFilePath = "log.txt";
        public IEnumerable<FileItem>? FileItems { get; set; }

        public GetDirectoryFilesViewModel(string folderPath)
        {
            DirectoryInfo dir = new DirectoryInfo(folderPath);
            IEnumerable<FileInfo> fileList = dir.EnumerateFiles("*.*", new EnumerationOptions { IgnoreInaccessible = true, RecurseSubdirectories = true});
            FileItems = fileList.Select(fileInfo => new FileItem
            {
                FileName = fileInfo.Name,
                FilePath = fileInfo.DirectoryName,
                FileSize = fileInfo.Length
            }).OrderByDescending(x => x.FileSize);        
        }

        private void LogExceptionToFile(Exception ex, string filePath = "")
        {
            string logMessage = $"[{DateTime.Now}] Exception: {ex.Message}\nFilePath: {filePath}\nStackTrace: {ex.StackTrace}\n";
            File.AppendAllText(LogFilePath, logMessage);
        }
    }            
}