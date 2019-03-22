namespace RenkoChart
{
    partial class FormSpilise
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
            this.dataGridView_StrategyList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label_S = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StrategyList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_StrategyList
            // 
            this.dataGridView_StrategyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StrategyList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column10,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView_StrategyList.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_StrategyList.MultiSelect = false;
            this.dataGridView_StrategyList.Name = "dataGridView_StrategyList";
            this.dataGridView_StrategyList.RowTemplate.Height = 23;
            this.dataGridView_StrategyList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_StrategyList.Size = new System.Drawing.Size(975, 330);
            this.dataGridView_StrategyList.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Date";
            this.Column1.HeaderText = "日期";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Time";
            this.Column2.HeaderText = "时间";
            this.Column2.Name = "Column2";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "MP";
            this.Column10.HeaderText = "多空";
            this.Column10.Name = "Column10";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TradeNum";
            this.Column3.HeaderText = "交易编号";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ChartEntryPrice";
            this.Column4.HeaderText = "图表入场点";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "RealEntryPrice";
            this.Column5.HeaderText = "实际入场点";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "S";
            this.Column6.HeaderText = "滑点";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DoubleS";
            this.Column7.HeaderText = "滑点(反手*2)";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "IsAvg";
            this.Column8.HeaderText = "是否加入统计计算";
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column8.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Avg-S(Only-Cal-Check):";
            // 
            // label_S
            // 
            this.label_S.AutoSize = true;
            this.label_S.Location = new System.Drawing.Point(211, 404);
            this.label_S.Name = "label_S";
            this.label_S.Size = new System.Drawing.Size(35, 12);
            this.label_S.TabIndex = 3;
            this.label_S.Text = "-----";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button_Cal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_CalClick);
            // 
            // FormSpilise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_S);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_StrategyList);
            this.Name = "FormSpilise";
            this.Text = "市场冲击成本分析";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StrategyList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_StrategyList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_S;
        private System.Windows.Forms.Button button1;
    }
}