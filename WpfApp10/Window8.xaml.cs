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
    /// Window8.xaml 的交互逻辑
    /// </summary>
    public partial class Window8 : Window
    {
        public Window8()
        {
            InitializeComponent();
            // 时间线类
            // TimeLine
            // AccelerationRotio属性和DecelerationRatio属性
            // RepeatBehavior属性
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var doubleAnimation = new DoubleAnimation
            {
                From = 50,
                To = (Height - 30) / 2,
                // 动画重复次数
                RepeatBehavior = new RepeatBehavior(2),
                // 动画开始前需要准备的时间
                //BeginTime = TimeSpan.FromSeconds(5),
                // 加速不会影响整个动画的总运行时间
                Duration = TimeSpan.FromSeconds(10),

                // 加速，最前面3秒加速
                //AccelerationRatio = 0.3,
                // 后面3秒减速
                //DecelerationRatio = 0.3,
                //AutoReverse = true,
                // 倍速设置
                //SpeedRatio = 2

            };
            ellipse1.BeginAnimation(WidthProperty, doubleAnimation);
            ellipse1.BeginAnimation(HeightProperty, doubleAnimation);
        }
    }
}
