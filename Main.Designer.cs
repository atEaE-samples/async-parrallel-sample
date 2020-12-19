namespace AsyncParrallelSample
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBox_RunTasks = new System.Windows.Forms.TextBox();
            this.txtBox_TaskTime = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cmb_TaskSelectBox = new System.Windows.Forms.ComboBox();
            this.lbl_RunTask = new System.Windows.Forms.Label();
            this.lbl_TaskTime = new System.Windows.Forms.Label();
            this.lbl_ErrorPercent = new System.Windows.Forms.Label();
            this.txtBox_ErrorRate = new System.Windows.Forms.TextBox();
            this.pnl_SampleInitialize = new System.Windows.Forms.Panel();
            this.pnl_SamplePending = new System.Windows.Forms.Panel();
            this.pnl_SampleRunning = new System.Windows.Forms.Panel();
            this.pnl_SampleFinishingSuccess = new System.Windows.Forms.Panel();
            this.pnl_SampleFinishingFailed = new System.Windows.Forms.Panel();
            this.lbl_SampleInit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_CurrentTaskDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_RunTasks
            // 
            this.txtBox_RunTasks.Enabled = false;
            this.txtBox_RunTasks.Location = new System.Drawing.Point(110, 6);
            this.txtBox_RunTasks.Name = "txtBox_RunTasks";
            this.txtBox_RunTasks.Size = new System.Drawing.Size(35, 19);
            this.txtBox_RunTasks.TabIndex = 0;
            // 
            // txtBox_TaskTime
            // 
            this.txtBox_TaskTime.Location = new System.Drawing.Point(200, 6);
            this.txtBox_TaskTime.Name = "txtBox_TaskTime";
            this.txtBox_TaskTime.Size = new System.Drawing.Size(35, 19);
            this.txtBox_TaskTime.TabIndex = 1;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(1, 4);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(2, 71);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(304, 139);
            this.flowLayoutPanel.TabIndex = 3;
            // 
            // cmb_TaskSelectBox
            // 
            this.cmb_TaskSelectBox.FormattingEnabled = true;
            this.cmb_TaskSelectBox.Location = new System.Drawing.Point(2, 31);
            this.cmb_TaskSelectBox.Name = "cmb_TaskSelectBox";
            this.cmb_TaskSelectBox.Size = new System.Drawing.Size(303, 20);
            this.cmb_TaskSelectBox.TabIndex = 4;
            // 
            // lbl_RunTask
            // 
            this.lbl_RunTask.AutoSize = true;
            this.lbl_RunTask.Location = new System.Drawing.Point(83, 9);
            this.lbl_RunTask.Name = "lbl_RunTask";
            this.lbl_RunTask.Size = new System.Drawing.Size(27, 12);
            this.lbl_RunTask.TabIndex = 5;
            this.lbl_RunTask.Text = "task";
            // 
            // lbl_TaskTime
            // 
            this.lbl_TaskTime.AutoSize = true;
            this.lbl_TaskTime.Location = new System.Drawing.Point(148, 9);
            this.lbl_TaskTime.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_TaskTime.Name = "lbl_TaskTime";
            this.lbl_TaskTime.Size = new System.Drawing.Size(52, 12);
            this.lbl_TaskTime.TabIndex = 6;
            this.lbl_TaskTime.Text = "taskTime";
            // 
            // lbl_ErrorPercent
            // 
            this.lbl_ErrorPercent.AutoSize = true;
            this.lbl_ErrorPercent.Location = new System.Drawing.Point(239, 9);
            this.lbl_ErrorPercent.Name = "lbl_ErrorPercent";
            this.lbl_ErrorPercent.Size = new System.Drawing.Size(29, 12);
            this.lbl_ErrorPercent.TabIndex = 7;
            this.lbl_ErrorPercent.Text = "error";
            // 
            // txtBox_ErrorRate
            // 
            this.txtBox_ErrorRate.Location = new System.Drawing.Point(269, 6);
            this.txtBox_ErrorRate.Name = "txtBox_ErrorRate";
            this.txtBox_ErrorRate.Size = new System.Drawing.Size(36, 19);
            this.txtBox_ErrorRate.TabIndex = 8;
            // 
            // pnl_SampleInitialize
            // 
            this.pnl_SampleInitialize.BackColor = System.Drawing.Color.LightGray;
            this.pnl_SampleInitialize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_SampleInitialize.Location = new System.Drawing.Point(12, 56);
            this.pnl_SampleInitialize.Name = "pnl_SampleInitialize";
            this.pnl_SampleInitialize.Size = new System.Drawing.Size(9, 9);
            this.pnl_SampleInitialize.TabIndex = 9;
            // 
            // pnl_SamplePending
            // 
            this.pnl_SamplePending.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnl_SamplePending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_SamplePending.Location = new System.Drawing.Point(54, 56);
            this.pnl_SamplePending.Name = "pnl_SamplePending";
            this.pnl_SamplePending.Size = new System.Drawing.Size(9, 9);
            this.pnl_SamplePending.TabIndex = 10;
            // 
            // pnl_SampleRunning
            // 
            this.pnl_SampleRunning.BackColor = System.Drawing.Color.Yellow;
            this.pnl_SampleRunning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_SampleRunning.Location = new System.Drawing.Point(119, 56);
            this.pnl_SampleRunning.Name = "pnl_SampleRunning";
            this.pnl_SampleRunning.Size = new System.Drawing.Size(9, 9);
            this.pnl_SampleRunning.TabIndex = 11;
            // 
            // pnl_SampleFinishingSuccess
            // 
            this.pnl_SampleFinishingSuccess.BackColor = System.Drawing.Color.Lime;
            this.pnl_SampleFinishingSuccess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_SampleFinishingSuccess.Location = new System.Drawing.Point(182, 56);
            this.pnl_SampleFinishingSuccess.Name = "pnl_SampleFinishingSuccess";
            this.pnl_SampleFinishingSuccess.Size = new System.Drawing.Size(9, 9);
            this.pnl_SampleFinishingSuccess.TabIndex = 12;
            // 
            // pnl_SampleFinishingFailed
            // 
            this.pnl_SampleFinishingFailed.BackColor = System.Drawing.Color.Red;
            this.pnl_SampleFinishingFailed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_SampleFinishingFailed.Location = new System.Drawing.Point(250, 56);
            this.pnl_SampleFinishingFailed.Name = "pnl_SampleFinishingFailed";
            this.pnl_SampleFinishingFailed.Size = new System.Drawing.Size(9, 9);
            this.pnl_SampleFinishingFailed.TabIndex = 13;
            // 
            // lbl_SampleInit
            // 
            this.lbl_SampleInit.AutoSize = true;
            this.lbl_SampleInit.Location = new System.Drawing.Point(27, 54);
            this.lbl_SampleInit.Name = "lbl_SampleInit";
            this.lbl_SampleInit.Size = new System.Drawing.Size(21, 12);
            this.lbl_SampleInit.TabIndex = 14;
            this.lbl_SampleInit.Text = "init";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "pending";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "running";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "success";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "failed";
            // 
            // txtBox_CurrentTaskDescription
            // 
            this.txtBox_CurrentTaskDescription.BackColor = System.Drawing.Color.White;
            this.txtBox_CurrentTaskDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_CurrentTaskDescription.Enabled = false;
            this.txtBox_CurrentTaskDescription.ForeColor = System.Drawing.Color.Black;
            this.txtBox_CurrentTaskDescription.Location = new System.Drawing.Point(1, 228);
            this.txtBox_CurrentTaskDescription.Multiline = true;
            this.txtBox_CurrentTaskDescription.Name = "txtBox_CurrentTaskDescription";
            this.txtBox_CurrentTaskDescription.Size = new System.Drawing.Size(303, 62);
            this.txtBox_CurrentTaskDescription.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "Task description";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 292);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBox_CurrentTaskDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_SampleInit);
            this.Controls.Add(this.pnl_SampleFinishingFailed);
            this.Controls.Add(this.pnl_SampleFinishingSuccess);
            this.Controls.Add(this.pnl_SampleRunning);
            this.Controls.Add(this.pnl_SamplePending);
            this.Controls.Add(this.pnl_SampleInitialize);
            this.Controls.Add(this.txtBox_ErrorRate);
            this.Controls.Add(this.lbl_ErrorPercent);
            this.Controls.Add(this.lbl_TaskTime);
            this.Controls.Add(this.lbl_RunTask);
            this.Controls.Add(this.cmb_TaskSelectBox);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.txtBox_TaskTime);
            this.Controls.Add(this.txtBox_RunTasks);
            this.Name = "Main";
            this.Text = "Async Parrallel Sample App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_RunTasks;
        private System.Windows.Forms.TextBox txtBox_TaskTime;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.ComboBox cmb_TaskSelectBox;
        private System.Windows.Forms.Label lbl_RunTask;
        private System.Windows.Forms.Label lbl_TaskTime;
        private System.Windows.Forms.Label lbl_ErrorPercent;
        private System.Windows.Forms.TextBox txtBox_ErrorRate;
        private System.Windows.Forms.Panel pnl_SampleInitialize;
        private System.Windows.Forms.Panel pnl_SamplePending;
        private System.Windows.Forms.Panel pnl_SampleRunning;
        private System.Windows.Forms.Panel pnl_SampleFinishingSuccess;
        private System.Windows.Forms.Panel pnl_SampleFinishingFailed;
        private System.Windows.Forms.Label lbl_SampleInit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_CurrentTaskDescription;
        private System.Windows.Forms.Label label5;
    }
}

