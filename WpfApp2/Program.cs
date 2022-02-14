using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp2
{
    internal class Program : Application
    {
        [STAThread()]
        public static void Main()
        {
            var app=new Program();
            app.MainWindow = new Window1();

            app.MainWindow.ShowDialog();
        }
    }
}
