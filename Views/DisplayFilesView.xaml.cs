﻿using File_Analyzer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace File_Analyzer.Views
{
    /// <summary>
    /// Interaction logic for DisplayFilesView.xaml
    /// </summary>
    public partial class DisplayFilesView : Window
    {
        public DisplayFilesView(string selectedFolder)
        {
            InitializeComponent();

            GetDirectoryFilesViewModel getDirectoryFiles = new(selectedFolder);
            DataContext = getDirectoryFiles;
        }

    }
}