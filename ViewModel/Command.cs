using System;
using System.ComponentModel;

namespace AsyncParrallelSample.ViewModel
{
    /// <summary>
    /// Command view model.
    /// </summary>
    public class Command : INotifyPropertyChanged
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
        /// Commad name public.
        /// </summary>
        public string Name { get; private set; } = nameof(Command);

        /// <summary>
        /// Command description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Execute function.
        /// </summary>
        private Action execute;

        /// <summary>
        /// Create new instance.
        /// </summary>
        /// <param name="name">commmand name.</param>
        /// <param name="execute">execute function.</param>
        public Command(string name, Action execute)
        {
            Name = name;
            this.execute = execute;
        }

        /// <summary>
        /// Create new instance.
        /// </summary>
        /// <param name="execute">execute function.</param>
        public Command(Action execute)
        {
            this.execute = execute;
        }

        /// <summary>
        /// Execute function.
        /// </summary>
        public void Execute()
        {
            execute?.Invoke();
        }

        /// <summary>
        /// Execute function.
        /// </summary>
        /// <param name="sender">event origin object</param>
        /// <param name="args">event args</param>
        public void Execute(object sender, EventArgs args)
        {
            execute?.Invoke();
        }

        /// <summary>
        /// to string.
        /// </summary>
        /// <returns>name.</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
