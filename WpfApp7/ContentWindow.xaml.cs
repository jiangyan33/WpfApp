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

namespace WpfApp7
{
    /// <summary>
    /// ContentWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ContentWindow : Window
    {
        public ContentWindow()
        {
            // 内容控件里面可以嵌套一个元素
            // 布局容器可以放置很多内容
            InitializeComponent();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("button2");
        }

        private void Run_MouseEnter(object sender, MouseEventArgs e)
        {
            popLink.IsOpen = true;
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Hyperlink hyperlink)
            {
                System.Diagnostics.Process.Start("explorer.exe", hyperlink.NavigateUri.ToString());
            }
        }
    }
}
