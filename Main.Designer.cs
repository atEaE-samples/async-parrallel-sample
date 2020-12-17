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
            this.SuspendLayout();
            // 
            // txtBox_RunTasks
            // 
            this.txtBox_RunTasks.Location = new System.Drawing.Point(73, 12);
            this.txtBox_RunTasks.Name = "txtBox_RunTasks";
            this.txtBox_RunTasks.Size = new System.Drawing.Size(87, 19);
            this.txtBox_RunTasks.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.txtBox_RunTasks);
            this.Name = "Main";
            this.Text = "Async Parrallel Sample App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_RunTasks;
    }
}

