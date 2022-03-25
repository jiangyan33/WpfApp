using System.Windows;

namespace WpfApp10
{
    /// <summary>
    /// Window5.xaml 的交互逻辑
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
            // 效果类
            // BlurEffect 模糊程度 模糊元素的内容Radius，越大模糊程度越大
            // DropShadowEffect 给元素添加偏移的阴影
            // ShaderEffect 像素着色器，需要继承实现（HLSL语言）,案例用来去除图片的颜色
        }
    }
}
