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

namespace WpfApp12
{
    /// <summary>
    /// Window2.xaml 的交互逻辑
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void cmdOne_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((sender as Button).Name);
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            var resourceDictionary = new ResourceDictionary();
            resourceDictionary.Source = new Uri("Resources/GradientButton2.xaml", UriKind.Relative);
            Resources.MergedDictionaries[0] = resourceDictionary;
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            var resourceDictionary = new ResourceDictionary();
            resourceDictionary.Source = new Uri("Resources/GradientButton.xaml", UriKind.Relative);
            Resources.MergedDictionaries[0] = resourceDictionary;
        }
    }
}
