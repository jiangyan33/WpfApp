using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            // 应用程序所有未处理的异常
            MessageBox.Show("未知错误" + e.ToString());
        }

        protected override void OnSessionEnding(SessionEndingCancelEventArgs e)
        {
            base.OnSessionEnding(e);
            //e.Cancel = true;
            //当关闭或者注销系统时触发
            //MessageBox.Show("无法关闭或者注销系统");
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            Console.WriteLine("程序即将退出。。。");
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            return;
            // 这个是主窗体
            var mainWindow = new MainWindow();
            // 命令行参数
            if (e.Args.Length > 0)
            {
                if (File.Exists(e.Args[0])) mainWindow.LoadFile(e.Args[0]);
            }
            mainWindow.Show();
        }

        public List<Document> DocumentList = new List<Document>();
    }
}
