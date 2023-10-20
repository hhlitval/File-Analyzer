using File_Analyzer.ViewModels;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace File_Analyzer.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void SelectFolderButton_Click(object sender, RoutedEventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select the target folder";
            // Optionally, set other properties like RootFolder, ShowNewFolderButton, etc.

            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //string selectedFolder = pathTextBox.Text = folderBrowserDialog.SelectedPath;
                string selectedFolder = folderBrowserDialog.SelectedPath;
                SelectedFolderViewModel getDirectoryFiles = new(selectedFolder);
                DataContext = getDirectoryFiles;
            }            
        }        
    }
}
