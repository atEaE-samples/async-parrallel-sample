using System.ComponentModel;

namespace AsyncParrallelSample.ViewModel
{
    /// <summary>
    /// Main view model.
    /// </summary>
    public class MainViewModel : INotifyPropertyChanged
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
        /// runTasks total.
        /// </summary>
        private string runTasks = "400";

        /// <summary>
        /// tasktime minsec.
        /// </summary>
        private string taskTime = "300";

        /// <summary>
        /// RunTasks total public.
        /// </summary>
        public string RunTasks
        {
            get => runTasks;
            set
            {
              if (runTasks == value)
                    return;

                runTasks = value;
                NotifyPropertyChanged(nameof(RunTasks));
            }
        }

        /// <summary>
        /// TaskTime public.
        /// </summary>
        public string TaskTime
        {
            get => taskTime;
            set
            {
                if (taskTime == value)
                    return;

                taskTime = value;
                NotifyPropertyChanged(nameof(TaskTime));
            }
        }

        /// <summary>
        /// start button command.
        /// </summary>
        public Command StartCommand { get; private set; }

        /// <summary>
        /// Create new instance.
        /// </summary>
        public MainViewModel()
        {
        }
    }
}
