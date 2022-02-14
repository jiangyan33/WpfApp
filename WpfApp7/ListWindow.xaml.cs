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
    /// ListWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ListWindow : Window
    {
        public ListWindow()
        {
            InitializeComponent();
        }

        private void lst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lst.SelectedItem == null) return;

            var cb = lst.SelectedItem as CheckBox;
            txtSelection.Text = "You chose item at position " + lst.SelectedIndex + "\r\nChecked state is " + cb.IsChecked;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var sb = new StringBuilder();
            foreach (CheckBox item in lst.Items)
            {
                if (item.IsChecked == true)
                {
                    sb.Append(item.Content).Append(" is checked.").Append("\r\n");
                }
            }

            txtSelection.Text = sb.ToString();
        }
    }
}
