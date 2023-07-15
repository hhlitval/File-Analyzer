using File_Analyzer.ViewModels;
using File_Analyzer.Views;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
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
            DataContext = new MainView().ShowDialog();  
        }        
    }
} 