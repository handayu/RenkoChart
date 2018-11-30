namespace RenkoChart
{
    partial class TimeSeriesRenkoPortfolioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timeSeriesRenkoQualityFolioControl1 = new RenkoChart.TimeSeriesRenkoQualityFolioControl();
            this.SuspendLayout();
            // 
            // timeSeriesRenkoQualityFolioControl1
            // 
            this.timeSeriesRenkoQualityFolioControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeSeriesRenkoQualityFolioControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeSeriesRenkoQualityFolioControl1.ForeColor = System.Drawing.Color.Red;
            this.timeSeriesRenkoQualityFolioControl1.Location = new System.Drawing.Point(0, 0);
            this.timeSeriesRenkoQualityFolioControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timeSeriesRenkoQualityFolioControl1.Name = "timeSeriesRenkoQualityFolioControl1";
            this.timeSeriesRenkoQualityFolioControl1.Size = new System.Drawing.Size(1304, 482);
            this.timeSeriesRenkoQualityFolioControl1.TabIndex = 0;
            // 
            // TimeSeriesRenkoPortfolioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 482);
            this.Controls.Add(this.timeSeriesRenkoQualityFolioControl1);
            this.Name = "TimeSeriesRenkoPortfolioForm";
            this.Text = "砖图的时间序列-资金曲线-投资组合";
            this.ResumeLayout(false);

        }

        #endregion

        private TimeSeriesRenkoQualityFolioControl timeSeriesRenkoQualityFolioControl1;
    }
}