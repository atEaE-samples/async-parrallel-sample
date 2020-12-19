using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Extensions;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

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
        /// error rate.
        /// </summary>
        private string errorRate = "5";

        /// <summary>
        /// panelview model repository.
        /// </summary>
        private List<PanelViewModel> panelModels = new List<PanelViewModel>();

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
        /// Error Rate public.
        /// </summary>
        public string ErrorRate
        {
            get => errorRate;
            set
            {
                if (errorRate == value)
                    return;
                errorRate = value;
                NotifyPropertyChanged(nameof(ErrorRate));
            }
        }

        public List<PanelViewModel> PanelViewModels { get => panelModels; }

        public void SetPanelViewModel(int index, NotifyPropertyChangedDelegate<Color> colorChangeDeleate)
        {
            panelModels[index].ColorChangedDelegate = colorChangeDeleate;    
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
            panelModels = Enumerable.Range(1, 600).Select(_ => new PanelViewModel(0, 0, 1, 1) { Height = 7, Width = 7 }).ToList();
            var taskTime = int.Parse(TaskTime);

            StartCommand = new Command(workerThreadType1);
        }

        private async void workerThreadType1()
        {
            var taskTime = int.Parse(TaskTime);
            var errorRate = int.Parse(ErrorRate);
            await Task.Run(() =>
            {
                panelModels.AsParallel().ForAll((p) =>
                {
                    p.JobPending(taskTime);
                    p.JobRunning(taskTime, errorRate);
                    p.JobFinishing();
                });
            });
        }
    }
}
