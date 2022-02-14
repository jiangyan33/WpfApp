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

namespace WpfApp8
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("主窗体的名称是" + Application.Current.MainWindow.Title);

            var doc = new Document();
            doc.Owner = this;
            doc.Show();
            if (Application.Current is App app) app.DocumentList.Add(doc);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Application.Current is App app)
            {
                foreach (var doc in app.DocumentList)
                {
                    doc.Content = "refresh time:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                }
            }

        }
    }
}
