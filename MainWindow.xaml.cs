using File_Analyzer.ViewModels;
using File_Analyzer.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Forms;

namespace File_Analyzer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var win = new MainView();
            win.ShowDialog();
            
        }

        private void selectFolderButton_Click(object sender, RoutedEventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select the target folder";
            // Optionally, set other properties like RootFolder, ShowNewFolderButton, etc.

            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string selectedFolder = folderBrowserDialog.SelectedPath;

                GetDirectoryFilesViewModel getDirectoryFiles = new(selectedFolder);
                DataContext = getDirectoryFiles;
            }
        }       
        
    }
} 