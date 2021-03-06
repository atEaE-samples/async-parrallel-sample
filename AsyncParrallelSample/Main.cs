﻿using AsyncParrallelSample.View;
using AsyncParrallelSample.ViewModel;
using System.Drawing;
using System.Windows.Forms;

namespace AsyncParrallelSample
{
    public partial class Main : Form
    {
        /// <summary>
        /// Main view model instance.
        /// </summary>
        private MainViewModel viewModel;

        /// <summary>
        /// Constructor
        /// </summary>
        public Main()
        {
            viewModel = new MainViewModel();
            
            InitializeComponent();
            SetupComponent();
            BindComponent();
        }

        /// <summary>
        /// Setup Component.
        /// </summary>
        protected void SetupComponent()
        {
            var cnt = 0;
            foreach(var pm in viewModel.PanelViewModels)
            {
                var panel = new Panel()
                {
                    Size = new Size(pm.Height, pm.Width),
                    Margin = new Padding(pm.PaddingLeft, pm.PaddingTop, pm.PaddingRight, pm.PaddingBottom),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.LightGray,
                };
                flowLayoutPanel.Controls.Add(panel);
                viewModel.SetPanelViewModel(cnt, (c) => { panel.BackColor = c; });
                cnt++;
            }
        }

        /// <summary>
        /// Bind Conponent.
        /// </summary>
        protected void BindComponent()
        {
            // button
            btn_Run.Bind(viewModel.RunCommand);
            btn_Run.Bind(nameof(Button.Enabled), viewModel, nameof(MainViewModel.RunButtonEnabled));
            btn_Clear.Bind(viewModel.ClearCommand);
            btn_Clear.Bind(nameof(Button.Enabled), viewModel, nameof(MainViewModel.ClearButtonEnabled));

            // combobox
            cmb_TaskSelectBox.DataSource = viewModel.TaskSelectSource;
            cmb_TaskSelectBox.Bind(nameof(ComboBox.SelectedIndex), viewModel, nameof(MainViewModel.SelectedWorkerIndex));

            // txtbox
            txtBox_RunTasks.Bind(nameof(TextBox.Text), viewModel, nameof(MainViewModel.RunTasks));
            txtBox_TaskTime.Bind(nameof(TextBox.Text), viewModel, nameof(MainViewModel.TaskTime));
            txtBox_ErrorRate.Bind(nameof(TextBox.Text), viewModel, nameof(MainViewModel.ErrorRate));
            txtBox_CurrentTaskDescription.Bind(nameof(TextBox.Text), viewModel, nameof(MainViewModel.CurrentSelectedWorkerDescription));
        }
    }
}
