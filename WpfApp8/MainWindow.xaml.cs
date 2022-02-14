using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp8
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

        public void LoadFile(string path)
        {
            textBlock.Text = File.ReadAllText(path);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("主窗体的名称是" + Application.Current.MainWindow.Title);
            foreach (Window window in Application.Current.Windows)
            {
                if (string.IsNullOrEmpty(window.Title)) continue;
                MessageBox.Show(window.Title + " is opened");
            }
        }
    }
}
