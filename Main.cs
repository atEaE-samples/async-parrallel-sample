using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsyncParrallelSample.ViewModel;
using AsyncParrallelSample.View;

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
        }

        protected void SetupComponent()
        {
            txtBox_RunTasks.BindText(viewModel, nameof(MainViewModel.RunTasks));
        }
    }
}
