﻿using System.Collections.Generic;
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
        private string runTasks = "608";

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
        /// tasktime minsec.
        /// </summary>
        private string taskTime = "300";

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
        /// error rate.
        /// </summary>
        private string errorRate = "5";

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

        /// <summary>
        /// Selected worker thread index.
        /// </summary>
        private int selectedWorkerIndex = 0;

        /// <summary>
        /// Selected worker thread index public.
        /// </summary>
        public int SelectedWorkerIndex
        {
            get => selectedWorkerIndex;
            set
            {
                if (selectedWorkerIndex == value)
                    return;
                selectedWorkerIndex = value;
                CurrentSelectedWorkerDescription = TaskSelectSource[selectedWorkerIndex].Description;
                NotifyPropertyChanged(nameof(SelectedWorkerIndex));
            }
        }

        /// <summary>
        /// Current selected workerthread description
        /// </summary>
        private string currentSelectedWorkerDescription;

        /// <summary>
        /// Current selected workerthread description public.
        /// </summary>
        public string CurrentSelectedWorkerDescription
        {
            get => currentSelectedWorkerDescription;
            set
            {
                if (currentSelectedWorkerDescription == value)
                    return;
                currentSelectedWorkerDescription = value;
                NotifyPropertyChanged(nameof(CurrentSelectedWorkerDescription));
            }
        }

        /// <summary>
        /// panelview model repository.
        /// </summary>
        private List<PanelViewModel> panelModels = new List<PanelViewModel>();

        public List<PanelViewModel> PanelViewModels { get => panelModels; }

        public List<Command> TaskSelectSource;

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
            var runTasks = int.Parse(RunTasks);
            panelModels = Enumerable.Range(1, runTasks).Select(_ => new PanelViewModel(height: 7, width: 7).Padding(0, 0, 1, 1)).ToList();
            TaskSelectSource = new List<Command>()
            {
                new Command("Sample1", workerThreadType1){ Description = "このサンプルは、各タスクを並列実行せず 『 ForEach 』 を使用して順番に実行するタスクです。" },
                new Command("Sample2", workerThreadType2){ Description = "このサンプルは、各タスクを 『 AsParallel 』 を使用して、並列実行させるタスクです。" },
                new Command("Sample3", workerThreadType3){ Description = "このサンプルは、各タスクを 『 AsParallel 』 を使用して並列実行させ、さらに処理1つ１つを非同期実行させるタスクです。" },
                new Command("Sample4", workerThreadType4){ Description = "このサンプルは、各タスクを 『 AsParallel 』 を使用して並列実行させ、さらに処理全体を非同期実行させるタスクです。" },
            };

            currentSelectedWorkerDescription = TaskSelectSource[SelectedWorkerIndex].Description;

            StartCommand = new Command(onStart);
        }

        private void onStart()
        {
            var cmd = TaskSelectSource[SelectedWorkerIndex];
            cmd.Execute();
        }

        /// <summary>
        /// Foreach
        /// </summary>
        private async void workerThreadType1()
        {
            var taskTime = int.Parse(TaskTime);
            var errorRate = int.Parse(ErrorRate);
            await Task.Run(() =>
            {
                panelModels.ForEach(p =>
                {
                    p.JobPending(taskTime);
                    p.JobRunning(taskTime, errorRate);
                    p.JobFinishing();
                });
            });
        }

        /// <summary>
        /// AsParallel ForAll 
        /// </summary>
        private async void workerThreadType2()
        {
            var taskTime = int.Parse(TaskTime);
            var errorRate = int.Parse(ErrorRate);
            await Task.Run(() =>
            {
                Parallel.ForEach(panelModels, p =>
                {
                    p.JobPending(taskTime);
                    p.JobRunning(taskTime, errorRate);
                    p.JobFinishing();
                });
            });
        }

        /// <summary>
        /// AsParallel ForAll 
        /// </summary>
        private async void workerThreadType3()
        {
            var taskTime = int.Parse(TaskTime);
            var errorRate = int.Parse(ErrorRate);
            await Task.Run(() =>
            {
                Parallel.ForEach(panelModels, async p =>
                {
                    await Task.Run(() => p.JobPending(taskTime));
                    await Task.Run(() => p.JobRunning(taskTime, errorRate));
                    await Task.Run(() => p.JobFinishing());
                });
            });
        }

        /// <summary>
        /// AsParallel ForAll 
        /// </summary>
        private async void workerThreadType4()
        {
            var taskTime = int.Parse(TaskTime);
            var errorRate = int.Parse(ErrorRate);
            await Task.Run(() =>
            {
                Parallel.ForEach(panelModels, async p =>
                {
                    await Task.Run(() =>
                    {
                        p.JobPending(taskTime);
                        p.JobRunning(taskTime, errorRate);
                        p.JobFinishing();
                    });
                });
            });
        }
    }
}
