using System;
using System.Collections.Generic;
using Serilog;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File_Analyzer.Models;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;

namespace File_Analyzer.ViewModels
{
    public class SelectedFolderViewModel : BaseViewModel
    {
        private const string LogFilePath = "log.txt";
        public IEnumerable<FileItem>? FileItems { get; set; }

        public ISeries[] Series { get; set; } = new ISeries[]
            {
            new PieSeries<double> { Values = new List<double> { 2 }, InnerRadius = 50, Name = "Video files", Pushout = 2, HoverPushout = 5},
            new PieSeries<double> { Values = new List<double> { 4 }, InnerRadius = 50, Name = "Images", Pushout = 2, HoverPushout = 5},
            new PieSeries<double> { Values = new List<double> { 1 }, InnerRadius = 50, Name = "Office files", Pushout = 2, HoverPushout = 5},
            new PieSeries<double> { Values = new List<double> { 4 }, InnerRadius = 50, Name = "PDF files", Pushout = 2, HoverPushout = 5},
            new PieSeries<double> { Values = new List<double> { 3 }, InnerRadius = 50, Name = "Audio files", Pushout = 2, HoverPushout = 5}
                };

        public SelectedFolderViewModel(string folderPath)
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

        //private void LogExceptionToFile(Exception ex, string filePath = "")
        //{
        //    string logMessage = $"[{DateTime.Now}] Exception: {ex.Message}\nFilePath: {filePath}\nStackTrace: {ex.StackTrace}\n";
        //    File.AppendAllText(LogFilePath, logMessage);
        //}        
    }            
}