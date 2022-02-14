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

namespace WpfApp6
{
    /// <summary>
    /// MouseWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class MouseWindow1 : Window
    {
        public MouseWindow1()
        {
            InitializeComponent();
        }

        private void Label_Drop(object sender, DragEventArgs e)
        {

        }

        private void Label_Drop_1(object sender, DragEventArgs e)
        {
            if (sender is Label label)
            {
                label.Content = e.Data.GetData(DataFormats.Text);
            }
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Label label)
            {
                DragDrop.DoDragDrop(label, label.Content, DragDropEffects.Copy);
            }
        }
    }
}
