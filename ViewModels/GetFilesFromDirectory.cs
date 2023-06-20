﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File_Analyzer.Models;

namespace File_Analyzer.ViewModels
{
    public class GetDirectoryFilesViewModel : BaseViewModel
    {
        public List<FileItem>? FileItems { get; set; }

        public GetDirectoryFilesViewModel(string folderPath)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(folderPath);
            IEnumerable<System.IO.FileInfo> fileList = dir.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
            FileItems = new List<FileItem>();

            foreach (FileInfo fileInfo in fileList)
            {
                FileItem fileItem = new FileItem
                {
                    FileName = fileInfo.Name,
                    FilePath = fileInfo.DirectoryName,
                    FileSize = fileInfo.Length
                };

                FileItems.Add(fileItem);
            }
        }        
    }
}
