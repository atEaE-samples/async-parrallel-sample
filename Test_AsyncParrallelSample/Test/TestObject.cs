using System.ComponentModel;

namespace Test_AsyncParrallelSample.Test
{
    /// <summary>
    /// Test-specific objects
    /// </summary>
    public class TestObject
    {
        #region INotifiyPropertyChanged
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
        /// sample text
        /// </summary>
        private string text = "Sample";

        /// <summary>
        /// sample text public
        /// </summary>
        public string Text
        {
            get => text;
            set
            {
                if (text == value)
                    return;

                text = value;
                NotifyPropertyChanged(nameof(Text));
            }
        }
    }
}
