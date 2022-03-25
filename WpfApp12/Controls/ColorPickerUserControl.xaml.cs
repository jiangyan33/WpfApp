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

namespace WpfApp12.Controls
{
    /// <summary>
    /// ColorPickerUserControl.xaml 的交互逻辑
    /// </summary>
    public partial class ColorPickerUserControl : UserControl
    {
        public ColorPickerUserControl()
        {
            InitializeComponent();
        }

        // 依赖项属性
        public static DependencyProperty ColorProperty;
        public static DependencyProperty RedProperty;
        public static DependencyProperty GreenProperty;
        public static DependencyProperty BlueProperty;

        public Color Color
        {
            get => (Color)GetValue(ColorProperty);
            set => SetValue(ColorProperty, value);
        }

        public byte Red
        {
            get => (byte)GetValue(RedProperty);
            set => SetValue(RedProperty, value);
        }

        public byte Green
        {
            get => (byte)GetValue(GreenProperty);
            set => SetValue(GreenProperty, value);
        }

        public byte Blue
        {
            get => (byte)GetValue(BlueProperty);
            set => SetValue(BlueProperty, value);
        }

        static ColorPickerUserControl()
        {
            // 注册依赖项属性
            // 属性名称，属性类型，属性所属的类，属性的的元数据 （默认值，属性变更的回调函数）
            ColorProperty = DependencyProperty.Register(nameof(Color), typeof(Color), typeof(ColorPickerUserControl),
                new FrameworkPropertyMetadata(Colors.Black, new PropertyChangedCallback(OnColorChanged)));

            RedProperty = DependencyProperty.Register(nameof(Red), typeof(byte), typeof(ColorPickerUserControl),
               new FrameworkPropertyMetadata((byte)0, new PropertyChangedCallback(OnColorRGBChanged)));

            GreenProperty = DependencyProperty.Register(nameof(Green), typeof(byte), typeof(ColorPickerUserControl),
               new FrameworkPropertyMetadata((byte)0, new PropertyChangedCallback(OnColorRGBChanged)));

            BlueProperty = DependencyProperty.Register(nameof(Blue), typeof(byte), typeof(ColorPickerUserControl),
               new FrameworkPropertyMetadata((byte)0, new PropertyChangedCallback(OnColorRGBChanged)));
        }

        /// <summary>
        /// 颜色属性发生变更,去改变RGB属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private static void OnColorChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            if (sender is ColorPickerUserControl control)
            {
                //Color是一个结构体
                var newColor = (Color)args.NewValue;
                var oldColor = (Color)args.OldValue;
                control.Red = newColor.R;
                control.Green = newColor.G;
                control.Blue = newColor.B;
                control.OnCorlorChanged(oldColor, newColor);
            }
        }

        /// <summary>
        /// GRB依赖项属性发生变更，去改变Color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private static void OnColorRGBChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            if (sender is ColorPickerUserControl control)
            {
                //Color是一个结构体
                var color = control.Color;
                if (args.Property == RedProperty)
                {
                    color.R = (byte)args.NewValue;
                }
                else if (args.Property == GreenProperty)
                {
                    color.G = (byte)args.NewValue;
                }
                else if (args.Property == BlueProperty)
                {
                    color.B = (byte)args.NewValue;
                }
                control.Color = color;
            }
        }

        // 如果是普通事件不需要这么复杂
        // 注册路由事件, 路由事件的名称，路由策列，事件处理程序的类型，路由事件所属的类
        public static readonly RoutedEvent ColorChangedEvent = EventManager.RegisterRoutedEvent(nameof(ColorChanged), RoutingStrategy.Bubble,
           typeof(RoutedPropertyChangedEventHandler<Color>), typeof(ColorPickerUserControl));

        // 事件包装
        public event RoutedPropertyChangedEventHandler<Color> ColorChanged
        {
            add { AddHandler(ColorChangedEvent, value); }
            remove { RemoveHandler(ColorChangedEvent, value); }
        }

        private void OnCorlorChanged(Color oldValue, Color newValue)
        {
            var args = new RoutedPropertyChangedEventArgs<Color>(oldValue, newValue)
            {
                RoutedEvent = ColorChangedEvent
            };
            RaiseEvent(args);
        }

    }
}
