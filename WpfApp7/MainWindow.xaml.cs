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

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            new ContentWindow().ShowDialog();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            new ScrollWindow().ShowDialog();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            new TitleContentWindow1().ShowDialog();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            new TextWindow().ShowDialog();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            new ListWindow().ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //this.button1.Background = new SolidColorBrush(Colors.AliceBlue);
            //this.button1.Foreground = new SolidColorBrush(Colors.Red);
            foreach (var item in Fonts.SystemFontFamilies)
            {
                combo1.Items.Add(item);
            }
            //this.FontFamily = new FontFamily();
            //this.button2.FontFamily = new FontFamily("Fang Song");
        }

        private void combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // 字体继承,父级控件设置的子级控件也会生效
            this.FontFamily = combo1.SelectedItem as FontFamily;
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            new BarWindow().ShowDialog();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            new DateWindow().ShowDialog();
        }
    }
}
