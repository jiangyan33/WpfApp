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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp9
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

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            new Window5().ShowDialog();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            new Window6().ShowDialog();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            new Window7().ShowDialog();
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            new Window8().ShowDialog();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            new Window9().ShowDialog();
        }
    }
}
