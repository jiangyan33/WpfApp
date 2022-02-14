using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp3
{
    internal class Program : Application
    {
        [STAThread()]
        public static void Main()
        {
            var app = new Program();
            app.MainWindow = new MainWindow("Window1.xaml");
            app.MainWindow.ShowDialog();
        }
    }
}
