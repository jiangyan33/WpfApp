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
    /// Window5.xaml 的交互逻辑
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        public void element_MouseEnter(object sender,MouseEventArgs e)
        {
            if(sender is TextBlock textBlock)
            {
                textBlock.Background=new SolidColorBrush(Colors.LightGoldenrodYellow);
            }
        }

        public void element_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sender is TextBlock textBlock)
            {
                textBlock.Background =null;
            }
        }
    }
}
