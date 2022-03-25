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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp10
{
    /// <summary>
    /// Window7.xaml 的交互逻辑
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
            // Animation 动画，渐变或者瞬变
            // 动画的生命周期，在动画存在时，只是改变属性值
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var animation = new DoubleAnimation
            {
                To = Width - 30,
                From = 100,
                // 回到设定的初始宽度
                //AutoReverse = true,
                // 运行结束后立刻回复到初始值
                //FillBehavior = FillBehavior.Stop,
                Duration = TimeSpan.FromSeconds(2)
            };
            animation.Completed += Animation_Completed;
            button1.BeginAnimation(WidthProperty, animation);

            var heightAnimation = new DoubleAnimation
            {
                To = Height - 50,
                From = 40,
                Duration = TimeSpan.FromSeconds(2)
            };
            button1.BeginAnimation(HeightProperty,heightAnimation);
        }

        private void Animation_Completed(object? sender, EventArgs e)
        {
            button1.BeginAnimation(WidthProperty, null);

            button1.Width = 50;
        }
    }
}
