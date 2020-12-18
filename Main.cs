using AsyncParrallelSample.View;
using AsyncParrallelSample.ViewModel;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        /// Panel view model instance.
        /// </summary>
        private List<PanelModel> panelViewModel = new List<PanelModel>();

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
            panelViewModel = Enumerable.Range(1, 100).Select(_ =>
            {
                var pm = new PanelModel(0, 0, 1, 1) { Height = 7, Width = 7 };

                var panel = new Panel()
                {
                    Size = new Size(pm.Height, pm.Width),
                    Margin = new Padding(pm.PaddingLeft, pm.PaddingTop, pm.PaddingRight, pm.PaddingBottom),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.LightGray,
                };
                flowLayoutPanel.Controls.Add(panel);
                pm.ColorChangedDelegate = (c) => { panel.BackColor = c; };
                return pm;
            }).ToList();
        }

        /// <summary>
        /// Bind Conponent.
        /// </summary>
        protected void BindComponent()
        {
            // txtbox
            txtBox_RunTasks.Bind(nameof(TextBox.Text), viewModel, nameof(MainViewModel.RunTasks));
            txtBox_TaskTime.Bind(nameof(TextBox.Text), viewModel, nameof(MainViewModel.TaskTime));

            // button
            //btn_Start.Bind(viewModel.StartCommand);

            btn_Start.Click += (sender, args) => { panelViewModel.ForEach(p => p.Color = Color.Red);  };


        }
    }
}
