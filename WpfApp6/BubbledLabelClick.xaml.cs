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
    /// BubbledLabelClick.xaml 的交互逻辑
    /// </summary>
    public partial class BubbledLabelClick : Window
    {
        protected int eventCounter = 0;

        public BubbledLabelClick()
        {
            InitializeComponent();
        }

        private void Grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            eventCounter++;
            var message = "#" + eventCounter.ToString() + ":\r\n" +
                "Sender:" + sender.ToString() + ":\r\n" +
                "Source:" + e.Source + ":\r\n" +
                "Original Source:" + e.OriginalSource;

            lstMessages.Items.Add(message);
            // handled是否继续向上传递
            e.Handled = (bool)chkHandle.IsChecked;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            eventCounter = 0;
            lstMessages.Items.Clear();
        }
    }
}
