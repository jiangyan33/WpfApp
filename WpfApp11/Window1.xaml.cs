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
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            // 暂停故事板类，保存当前位置 PauseStoryboard
            // 恢复故事板类，从当前保存的位置恢复，ResumeStoryboard
            // 停止故事板类,动画停止到这个地方，也就结束了 StopStoryboad,TODO:这个现在有问题,直接恢复到最开始的效果了
            // 查找故事板类,SeekStoryboard
            // 改变故事板的播放速度,SetStoryboardSpeedRatio
            // 将故事板移动到终点,SkipStoryboardToFill
            // 移除故事板,RemosStoryboard
        }

        private void Storyboard_CurrentTimeInvalidated(object sender, EventArgs e)
        {
            if (sender is Clock clock)
            {
                progressBar1.Value = clock.CurrentProgress == null ? 0 : (double)clock.CurrentProgress;
            }
        }
    }
}
