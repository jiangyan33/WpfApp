using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp10
{
    /// <summary>
    /// 可视化对象绘制内容
    /// </summary>
    public class MyPanel : Panel
    {
        /// <summary>
        /// 可视化树
        /// </summary>
        private readonly List<Visual> visualList = new List<Visual>();

        protected override Visual GetVisualChild(int index)
        {
            return visualList[index];
        }

        protected override int VisualChildrenCount
        {
            get
            {
                return visualList.Count;
            }
        }

        public void AddVisual(Visual visual)
        {
            visualList.Add(visual);
            // 注册可视化对象，后续追踪的时候使用
            AddLogicalChild(visual);
            AddVisualChild(visual);
        }

        public void DeleteVisual(Visual visual)
        {
            visualList.Remove(visual);
            RemoveLogicalChild(visual);
            RemoveVisualChild(visual);
        }

        // 命中测试
        public DrawingVisual? GetVisual(Point point)
        {
            var hitTestResult = VisualTreeHelper.HitTest(this, point);
            if(hitTestResult==null)return null;
            return hitTestResult.VisualHit as DrawingVisual;
        }
    }
}
