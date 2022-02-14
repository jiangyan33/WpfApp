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

namespace WpfApp9
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            // 创建绑定对象，设置绑定关系
            var binding = new Binding
            {
                Source = slider1,
                Path = new PropertyPath(nameof(slider1.Value)),
                Mode = BindingMode.TwoWay
            };
            textBlock1.SetBinding(TextBlock.FontSizeProperty, binding);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBlock1.FontSize = 30;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //BindingOperations.ClearAllBindings(textBlock1);
            BindingOperations.ClearBinding(textBlock1, TextBlock.FontSizeProperty);
        }
    }
}
