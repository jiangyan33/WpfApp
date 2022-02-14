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

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            var list = new List<ITest>();

            list.Add(new Test { FirstName = "aaa1", Name = "bbb" });
            list.Add(new Test { FirstName = "aaa2", Name = "bbb" });
            list.Add(new Test { FirstName = "aaa3", Name = "bbb" });
            list.Add(new Test { FirstName = "aaa4", Name = "bbb" });
            list.Add(new Test { FirstName = "aaa5", Name = "bbb" });

            foreach (Test item in list)
            {
                Console.WriteLine(item.FirstName);
            }

           var result= from Test item in list where item.FirstName == "bbb" select item;
        }
    }

    public interface ITest
    {
        string Name { get; set; }
    }

    public class Test : ITest
    {
        public string Name { get; set; }

        public string FirstName { get; set; }
    }
}
