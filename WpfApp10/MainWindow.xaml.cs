﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            new Window1().ShowDialog();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            new Window2().ShowDialog();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            new Window3().ShowDialog();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            new Window4().ShowDialog();
        }
    }
}
