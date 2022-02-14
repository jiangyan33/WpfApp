using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Button myButton;

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(string xamlFile)
        {
            Width = Height = 285;
            Top = Left = 100;
            Title = "Dynamically Loaded XAML";

            DependencyObject dependencyObject;
            using var fs = new FileStream(xamlFile, FileMode.Open);
            dependencyObject = (DependencyObject)XamlReader.Load(fs);

            Content = dependencyObject;

            // 从控件树中查找指定名称的控件
            myButton = (Button)LogicalTreeHelper.FindLogicalNode(dependencyObject, "button");

            myButton.Click += MyButton_Click;
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn) btn.Content = "Thank You.";
        }
    }
}
