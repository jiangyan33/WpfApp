using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Window1 : Window
    {

        private Button button;

        public Window1()
        {
            InitialzeComponent();
        }

        private void InitialzeComponent()
        {
            Width = 285;
            Height = 250;
            Top = Left = 100;
            Title = "Code-Only Window";

            var panel = new DockPanel();

            button = new Button();
            button.Content = "Please Click Me.";
            button.Margin = new Thickness(30);
            button.Click += Button_Click;

            IAddChild container = panel;
            container.AddChild(button);

            container = this;
            container.AddChild(panel);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn) btn.Content = "Thank You."; 
        }
    }
}
