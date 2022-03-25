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

namespace WpfApp10
{
    /// <summary>
    /// Window6.xaml 的交互逻辑
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
            // WriteableBitmap 使用位图作为image的Source属性
            // DPI 每英寸有多少个像素点
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // PixelFormats.Bgra32 带有透明度的(rgba)
            //var wb = new WriteableBitmap((int)image.Width, (int)image.Height, 96, 96, PixelFormats.Bgra32, null);

            //var rand = new Random();
            //for (var x = 0; x < wb.PixelWidth; x++)
            //{
            //    for (var y = 0; y < wb.PixelHeight; y++)
            //    {
            //        // 矩形对象
            //        var rect = new Int32Rect(x, y, 1, 1);
            //        // 跨距，偏移量
            //        var stride = wb.PixelWidth * wb.Format.BitsPerPixel / 8;
            //        // 图像格式转换为数组
            //        byte blue = (byte)rand.Next(0, 255), green = (byte)rand.Next(0, 255), red = (byte)rand.Next(0, 255), alpha = 255;
            //        byte[] colorData = { blue, green, red, alpha };
            //        wb.WritePixels(rect, colorData, stride, 0);
            //    }
            //}
            //image.Source = wb;

            var wb = new WriteableBitmap((int)image.Width, (int)image.Height, 96, 96, PixelFormats.Bgra32, null);
            var rect = new Int32Rect(0, 0, (int)image.Width, (int)image.Height);

            // 存储图片区域内所有的像素点
            var pixels = new byte[(int)image.Width * (int)image.Height * wb.Format.BitsPerPixel / 8];
            var random = new Random();
            for (var x = 0; x < wb.PixelWidth; x++)
            {
                for (var y = 0; y < wb.PixelHeight; y++)
                {
                    byte red = 0, green = 0, blue = 0, alpha = 0;
                    if ((x % 5 == 0) || (y % 7 == 0))
                    {
                        red = (byte)((double)y / wb.PixelHeight * 255);
                        green = (byte)random.Next(100, 255);
                        blue = (byte)((double)x / wb.PixelWidth * 255);
                        alpha = 255;
                    }
                    else
                    {
                        red = (byte)((double)y / wb.PixelWidth * 255);
                        green = (byte)random.Next(100, 255);
                        blue = (byte)((double)x / wb.PixelHeight * 255);
                        alpha = 50;
                    }
                    int pixelOffset = (x + y * wb.PixelWidth) * wb.Format.BitsPerPixel / 8;
                    pixels[pixelOffset] = blue;
                    pixels[pixelOffset + 1] = green;
                    pixels[pixelOffset + 2] = red;
                    pixels[pixelOffset + 3] = alpha;
                }
            }
            var stride = wb.PixelWidth * wb.Format.BitsPerPixel / 8;
            // 循环赋值，绘制只执行一次。
            wb.WritePixels(rect, pixels, stride, 0);
            image.Source = wb;
        }
    }
}
