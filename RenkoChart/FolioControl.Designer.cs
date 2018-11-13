namespace RenkoChart
{
    partial class FolioControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_initQuality = new System.Windows.Forms.TextBox();
            this.button_CalNow = new System.Windows.Forms.Button();
            this.radioButton_moneyCal = new System.Windows.Forms.RadioButton();
            this.radioButton_pointCal = new System.Windows.Forms.RadioButton();
            this.dataGridView_List = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_StrategyList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StrategyList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1139, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "策略列表概览";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.80936F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.19064F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 376F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_List, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_StrategyList, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1133, 129);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_initQuality);
            this.groupBox3.Controls.Add(this.button_CalNow);
            this.groupBox3.Controls.Add(this.radioButton_moneyCal);
            this.groupBox3.Controls.Add(this.radioButton_pointCal);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 123);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "组合回测设置";
            // 
            // textBox_initQuality
            // 
            this.textBox_initQuality.Location = new System.Drawing.Point(200, 73);
            this.textBox_initQuality.Name = "textBox_initQuality";
            this.textBox_initQuality.Size = new System.Drawing.Size(72, 21);
            this.textBox_initQuality.TabIndex = 2;
            // 
            // button_CalNow
            // 
            this.button_CalNow.Location = new System.Drawing.Point(21, 96);
            this.button_CalNow.Name = "button_CalNow";
            this.button_CalNow.Size = new System.Drawing.Size(92, 24);
            this.button_CalNow.TabIndex = 10;
            this.button_CalNow.Text = "启动组合计算";
            this.button_CalNow.UseVisualStyleBackColor = true;
            this.button_CalNow.Click += new System.EventHandler(this.ButtonCal_Click);
            // 
            // radioButton_moneyCal
            // 
            this.radioButton_moneyCal.AutoSize = true;
            this.radioButton_moneyCal.Location = new System.Drawing.Point(21, 74);
            this.radioButton_moneyCal.Name = "radioButton_moneyCal";
            this.radioButton_moneyCal.Size = new System.Drawing.Size(173, 16);
            this.radioButton_moneyCal.TabIndex = 1;
            this.radioButton_moneyCal.TabStop = true;
            this.radioButton_moneyCal.Text = "按照*点值后的资金进行计算";
            this.radioButton_moneyCal.UseVisualStyleBackColor = true;
            // 
            // radioButton_pointCal
            // 
            this.radioButton_pointCal.AutoSize = true;
            this.radioButton_pointCal.Location = new System.Drawing.Point(21, 36);
            this.radioButton_pointCal.Name = "radioButton_pointCal";
            this.radioButton_pointCal.Size = new System.Drawing.Size(359, 16);
            this.radioButton_pointCal.TabIndex = 0;
            this.radioButton_pointCal.TabStop = true;
            this.radioButton_pointCal.Text = "所有策略按照盈亏点位总和计算(仅仅是盈亏点位加总，不合理)";
            this.radioButton_pointCal.UseVisualStyleBackColor = true;
            this.radioButton_pointCal.CheckedChanged += new System.EventHandler(this.CheckRadioPoint_Click);
            // 
            // dataGridView_List
            // 
            this.dataGridView_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_List.Location = new System.Drawing.Point(759, 3);
            this.dataGridView_List.Name = "dataGridView_List";
            this.dataGridView_List.RowTemplate.Height = 23;
            this.dataGridView_List.Size = new System.Drawing.Size(371, 123);
            this.dataGridView_List.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Symbol";
            this.dataGridViewTextBoxColumn1.HeaderText = "测试品种";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BarNum";
            this.dataGridViewTextBoxColumn2.HeaderText = "K线编号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "IsUpDownBar";
            this.Column3.HeaderText = "阴阳线";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MarketPosition";
            this.Column4.HeaderText = "持仓状态";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "LastCloseProfit";
            this.Column5.HeaderText = "前一次盈亏(点)";
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "BigPointValue";
            this.Column6.HeaderText = "点值";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "RenkoHight";
            this.Column7.HeaderText = "砖高(点)";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "CommisionValue";
            this.Column8.HeaderText = "手续费(点)";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "RenkoCommision";
            this.Column9.HeaderText = "砖成本(点)";
            this.Column9.Name = "Column9";
            // 
            // dataGridView_StrategyList
            // 
            this.dataGridView_StrategyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StrategyList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column10});
            this.dataGridView_StrategyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_StrategyList.Location = new System.Drawing.Point(395, 3);
            this.dataGridView_StrategyList.MultiSelect = false;
            this.dataGridView_StrategyList.Name = "dataGridView_StrategyList";
            this.dataGridView_StrategyList.RowTemplate.Height = 23;
            this.dataGridView_StrategyList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_StrategyList.Size = new System.Drawing.Size(358, 123);
            this.dataGridView_StrategyList.TabIndex = 0;
            this.dataGridView_StrategyList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "StrategyPathName";
            this.Column1.HeaderText = "策略名";
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "StrategyCommisionSet";
            this.Column2.HeaderText = "手续费(点)";
            this.Column2.Name = "Column2";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "StrategyOpenShares";
            this.Column10.HeaderText = "该策略开仓手数";
            this.Column10.Name = "Column10";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chart2);
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1139, 417);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "组合曲线分析器";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 17);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1133, 271);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea1.AxisY.Maximum = 0.3D;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(3, 288);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "组合回撤比率";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(1133, 126);
            this.chart2.TabIndex = 4;
            this.chart2.Text = "chart2";
            // 
            // FolioControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FolioControl";
            this.Size = new System.Drawing.Size(1139, 566);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StrategyList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView_StrategyList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_initQuality;
        private System.Windows.Forms.RadioButton radioButton_moneyCal;
        private System.Windows.Forms.RadioButton radioButton_pointCal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridView dataGridView_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button button_CalNow;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
