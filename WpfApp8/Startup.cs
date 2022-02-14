using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp8
{
    public class Startup
    {
        
        /// <summary>
        /// STAThread单实例应用程序,比如Office是单实例应用程序，记事本软件是多实例应用程序，在任务管理器中可以看到多个
        /// </summary>
        [STAThread()]
        public static void Main()
        {
            var app = new WpfApp();
            app.Run();
        }
    }

    public class WpfApp : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ShowWindow();
        }

        public void ShowWindow()
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
