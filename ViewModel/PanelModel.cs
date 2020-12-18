using System.ComponentModel;
using System.Drawing;

namespace AsyncParrallelSample.ViewModel
{
    /// <summary>
    /// 
    /// </summary>
    public class PanelModel : INotifyPropertyChanged
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
        public PanelModel()
        { }

        /// <summary>
        /// Create new instance.
        /// </summary>
        /// <param name="all">all</param>
        public PanelModel(int all)
        {
            Padding(all);
        }

        /// <summary>
        /// Create new instance.
        /// </summary>
        /// <param name="left">left</param>
        /// <param name="top">top</param>
        /// <param name="right">right</param>
        /// <param name="bottom">bottom</param>
        public PanelModel(int left, int top, int right, int bottom)
        {
            Padding(left, top, right, bottom);
        }

        /// <summary>
        /// Panel height.
        /// </summary>
        public int Height { get; set; }
        
        /// <summary>
        /// Panel width.
        /// </summary>
        public int Width { get; set; }

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
        /// Panel color.
        /// </summary>
        private Color color = Color.LightGray;

        /// <summary>
        /// Panel color.
        /// </summary>
        public Color Color
        {
            get { return color; }
            set
            {
                if (color == value)
                    return;

                color = value;
                ColorChangedDelegate?.Invoke(value);
            }
        }

        /// <summary>
        /// Panel check.
        /// </summary>
        public void Check()
        {
            Color = Color.Red;
        }

        /// <summary>
        /// Set padding.
        /// </summary>
        /// <param name="left">left</param>
        /// <param name="top">top</param>
        /// <param name="right">right</param>
        /// <param name="bottom">bottom</param>
        public void Padding(int left, int top, int right, int bottom)
        {
            PaddingLeft = left;
            PaddingTop = top;
            PaddingRight = right;
            PaddingBottom = bottom;
        }

        /// <summary>
        /// Set padding.
        /// </summary>
        /// <param name="all">all</param>
        public void Padding(int all)
        {
            Padding(all, all, all, all);
        }
    }
}
