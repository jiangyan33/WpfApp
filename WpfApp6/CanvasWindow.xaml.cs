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
    /// CanvasWindow.xaml 的交互逻辑
    /// </summary>
    public partial class CanvasWindow : Window
    {
        public CanvasWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Panel.GetZIndex(buttom1) >= Panel.GetZIndex(grid))
            {
                Panel.SetZIndex(grid, Panel.GetZIndex(buttom1) + 1);
            }
            else
            {
                Panel.SetZIndex(buttom1, Panel.GetZIndex(grid) + 1);
            }
        }
    }
}
