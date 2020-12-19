using System;
using System.ComponentModel;
using System.ComponentModel.Extensions;
using System.Drawing;
using System.Threading;

namespace AsyncParrallelSample.ViewModel
{
    /// <summary>
    /// Panel view models.
    /// </summary>
    public class PanelViewModel : INotifyPropertyChanged
    {
        #region INotifiyPropertyChanged

        /// <summary>
        /// Color changed delegate;
        /// </summary>
        public NotifyPropertyChangedDelegate<Color> ColorChangedDelegate;

        /// <summary>
        /// Property changed handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Execute property change function.
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        /// <summary>
        /// Create new instance.
        /// </summary>
        /// <param name="height">panel height</param>
        /// <param name="width">panel width</param>
        public PanelViewModel(int height, int width)
        {
            Height = height;
            Width = width;
        }

        /// <summary>
        /// Panel height.
        /// </summary>
        public int Height { get; private set; }
        
        /// <summary>
        /// Panel width.
        /// </summary>
        public int Width { get; private set; }

        /// <summary>
        /// Padding top.
        /// </summary>
        public int PaddingTop { get; private set; } = 0;

        /// <summary>
        /// Padding bottom.
        /// </summary>
        public int PaddingBottom { get; private set; } = 0;

        /// <summary>
        /// Padding left.
        /// </summary>
        public int PaddingLeft { get; private set; } = 0;

        /// <summary>
        /// Padding right.
        /// </summary>
        public int PaddingRight { get; private set; } = 0;

        /// <summary>
        /// check panel finish status error.
        /// </summary>
        public bool IsError { get; private set; } = false;

        /// <summary>
        /// Panel color.
        /// </summary>
        private Color color = Color.LightGray;

        /// <summary>
        /// Panel color.
        /// </summary>
        public Color Color
        {
            get { return color; }
            private set
            {
                if (color == value)
                    return;

                color = value;
                ColorChangedDelegate?.Invoke(value);
            }
        }

        /// <summary>
        /// Set padding.
        /// </summary>
        /// <param name="left">left</param>
        /// <param name="top">top</param>
        /// <param name="right">right</param>
        /// <param name="bottom">bottom</param>
        /// <returns>PanelViewModel</returns>
        public PanelViewModel Padding(int left, int top, int right, int bottom)
        {
            PaddingLeft = left;
            PaddingTop = top;
            PaddingRight = right;
            PaddingBottom = bottom;
            return this;
        }

        /// <summary>
        /// Set padding.
        /// </summary>
        /// <param name="all">all</param>
        /// <returns>PanelViewModel</returns>
        public PanelViewModel Padding(int all)
        {
            return Padding(all, all, all, all);
        }

        /// <summary>
        /// Pending panel.
        /// </summary>
        public void JobPending(int taskTimeSeed)
        {
            var random = new Random();
            Color = Color.DodgerBlue;
            Thread.Sleep(random.Next(taskTimeSeed));           
        }

        /// <summary>
        /// Running panel.
        /// </summary>
        public void JobRunning(int taskTimeSeed, int errorRate)
        {
            var random = new Random();
            Color = Color.Yellow;
            Thread.Sleep(random.Next(taskTimeSeed));

            // Simple probability determination
            if (random.Next(100) < errorRate)
                IsError = true;
        }

        /// <summary>
        /// Finishing panel.
        /// </summary>
        public void JobFinishing()
        {
            if (IsError)
            {
                Color = Color.Red;
            }
            else
            {
                Color = Color.Lime;
            }
        }
    }
}
