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
    /// InkCanvasWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class InkCanvasWindow1 : Window
    {
        public InkCanvasWindow1()
        {
            InitializeComponent();
        }

        private void combox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            inkCanvas.EditingMode = (InkCanvasEditingMode)combox.SelectedItem;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var list = Enum.GetValues(typeof(InkCanvasEditingMode));

            foreach (var item in list) combox.Items.Add(item);

            combox.SelectedIndex = 0;
        }
    }
}
