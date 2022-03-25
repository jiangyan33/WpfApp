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

namespace WpfApp11
{
    /// <summary>
    /// CustomEasingFunction.xaml 的交互逻辑
    /// </summary>
    public partial class CustomEasingFunction : Window
    {
        public CustomEasingFunction()
        {
            InitializeComponent();
        }
    }

    public class RandomJitterEase : EasingFunctionBase
    {
        protected override Freezable CreateInstanceCore()
        {
          return new RandomJitterEase();
        }

        protected override double EaseInCore(double normalizedTime)
        {
            // 缓动核心处理逻辑,normalizedTime是一个小数，立方值后更加小
            return Math.Pow(normalizedTime,3);
        }
    }
}
