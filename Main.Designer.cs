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
            this.SuspendLayout();
            // 
            // txtBox_RunTasks
            // 
            this.txtBox_RunTasks.Location = new System.Drawing.Point(144, 12);
            this.txtBox_RunTasks.Name = "txtBox_RunTasks";
            this.txtBox_RunTasks.Size = new System.Drawing.Size(87, 19);
            this.txtBox_RunTasks.TabIndex = 0;
            // 
            // txtBox_TaskTime
            // 
            this.txtBox_TaskTime.Location = new System.Drawing.Point(270, 12);
            this.txtBox_TaskTime.Name = "txtBox_TaskTime";
            this.txtBox_TaskTime.Size = new System.Drawing.Size(100, 19);
            this.txtBox_TaskTime.TabIndex = 1;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(21, 12);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 57);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(498, 344);
            this.flowLayoutPanel.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
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
    }
}

