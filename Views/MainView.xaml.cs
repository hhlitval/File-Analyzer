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
            Application.Current.Shutdown();
        }

        private void SizeAnalyzeButton_Click(object sender, RoutedEventArgs e)
        {
            DisplayFilesView filesView = new();
            filesView.ShowDialog();
        }

        private void FindDuplicatesButton_Click(object sender, RoutedEventArgs e)
        {
            DuplicateFilesView duplicateFiles = new();
            duplicateFiles.ShowDialog();
        }
    }
}
