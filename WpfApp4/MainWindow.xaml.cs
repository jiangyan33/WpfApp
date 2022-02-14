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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // 1.让容器去是适应父级容器，不显示设置宽度和高度
            // 2.不使用屏幕的坐标来显示元素的位置，如果需要元素之间增加空白，使用margin属性
            // 3.布局容器和子元素共享可以使用的空间，布局容器要为子容器设置足够的空间
            // 4.可以嵌套布局容器

            // 控件如果没有高度，会根据元素内容自适应高度，宽度和容器的宽度一样
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
