using System.Windows;
using System.Windows.Media;

namespace WpfApp10
{
    /// <summary>
    /// Window4.xaml 的交互逻辑
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();

            // 可视化对象
            //var visual = new DrawingVisual();
            //var dc = visual.RenderOpen();
            //dc.DrawLine();
            //dc.DrawRectangle();
            //dc.DrawRoundedRectangle();
            //dc.DrawEllipse();
            //dc.DrawGeometry();
            //dc.DrawText();
            //dc.DrawImage();
            //dc.Close();
            //AddVisualChild();
            //AddLogicalChild();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //var visual = new DrawingVisual();

            //using var dc = visual.RenderOpen();
            //// 填充颜色
            //var brush = Brushes.LightGreen;
            //// 画笔颜色
            //var pen = new Pen(Brushes.SteelBlue, 3);
            //dc.DrawRectangle(brush, pen, new Rect(new Point(100, 100), new Size(50, 100)));
            //dc.DrawEllipse(brush, pen, new Point(300, 400), 200, 120);
            //dc.DrawLine(pen, new Point(0, 50), new Point(50, 0));
            //dc.DrawLine(pen, new Point(50, 0), new Point(100, 50));
            //dc.DrawLine(pen, new Point(0, 50), new Point(100, 50));
            //myPanel.AddVisual(visual);
        }

        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var point = e.GetPosition(this);
            var visual = new DrawingVisual();
            DrawSquare(visual, point);
            myPanel.AddVisual(visual);
        }

        private void Window_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var point = e.GetPosition(this);
            var visual = myPanel.GetVisual(point);
            if (visual != null) myPanel.DeleteVisual(visual);
        }

        private void DrawSquare(DrawingVisual visual, Point topLeftCornet)
        {
            using var dc = visual.RenderOpen();
            // 填充颜色
            var brush = Brushes.LightGreen;
            // 画笔颜色
            var pen = new Pen(Brushes.SteelBlue, 3);
            dc.DrawRectangle(brush, pen, new Rect(topLeftCornet, new Size(40, 40)));
        }
    }
}
