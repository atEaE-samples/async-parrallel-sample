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
            this.flowLayoutPanel.Location = new System.Drawing.Point(1, 57);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(304, 218);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 301);
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
    }
}

