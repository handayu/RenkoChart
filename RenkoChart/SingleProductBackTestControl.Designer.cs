namespace RenkoChart
{
    partial class SingleProductBackTestControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_InitQuality = new System.Windows.Forms.TextBox();
            this.radioButton_PointVisual = new System.Windows.Forms.RadioButton();
            this.radioButton_MoneyVisual = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_EvetyLoss = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_RenkoHigh = new System.Windows.Forms.TextBox();
            this.button_Cal = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView_List = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_OpenShares = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Symbol = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_needRenkoNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_LastBarNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_KuiSunCout = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_YingliCout = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_allTradeCout = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chart1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 292);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1005, 308);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "资金曲线分析器";
            // 
            // chart1
            // 
            chartArea1.AxisY.ScaleBreakStyle.Spacing = 0.5D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 17);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "原始资金曲线";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "真实资金曲线";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(999, 288);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Chart1_MouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox_InitQuality);
            this.groupBox3.Controls.Add(this.radioButton_PointVisual);
            this.groupBox3.Controls.Add(this.radioButton_MoneyVisual);
            this.groupBox3.Location = new System.Drawing.Point(11, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 81);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "净值显示模式";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "起始资金:";
            // 
            // textBox_InitQuality
            // 
            this.textBox_InitQuality.Location = new System.Drawing.Point(301, 15);
            this.textBox_InitQuality.Name = "textBox_InitQuality";
            this.textBox_InitQuality.Size = new System.Drawing.Size(104, 21);
            this.textBox_InitQuality.TabIndex = 13;
            // 
            // radioButton_PointVisual
            // 
            this.radioButton_PointVisual.AutoSize = true;
            this.radioButton_PointVisual.Location = new System.Drawing.Point(15, 53);
            this.radioButton_PointVisual.Name = "radioButton_PointVisual";
            this.radioButton_PointVisual.Size = new System.Drawing.Size(143, 16);
            this.radioButton_PointVisual.TabIndex = 1;
            this.radioButton_PointVisual.TabStop = true;
            this.radioButton_PointVisual.Text = "按点值(盈亏点值曲线)";
            this.radioButton_PointVisual.UseVisualStyleBackColor = true;
            // 
            // radioButton_MoneyVisual
            // 
            this.radioButton_MoneyVisual.AutoSize = true;
            this.radioButton_MoneyVisual.Location = new System.Drawing.Point(15, 20);
            this.radioButton_MoneyVisual.Name = "radioButton_MoneyVisual";
            this.radioButton_MoneyVisual.Size = new System.Drawing.Size(179, 16);
            this.radioButton_MoneyVisual.TabIndex = 0;
            this.radioButton_MoneyVisual.TabStop = true;
            this.radioButton_MoneyVisual.Text = "给定初始资金的折算资金显示";
            this.radioButton_MoneyVisual.UseVisualStyleBackColor = true;
            this.radioButton_MoneyVisual.CheckedChanged += new System.EventHandler(this.RadioCheckChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "砖的高度(见MC设置点):";
            // 
            // textBox_EvetyLoss
            // 
            this.textBox_EvetyLoss.Location = new System.Drawing.Point(447, 17);
            this.textBox_EvetyLoss.Name = "textBox_EvetyLoss";
            this.textBox_EvetyLoss.Size = new System.Drawing.Size(132, 21);
            this.textBox_EvetyLoss.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "单笔交易成本(折算成点):";
            // 
            // textBox_RenkoHigh
            // 
            this.textBox_RenkoHigh.Location = new System.Drawing.Point(146, 17);
            this.textBox_RenkoHigh.Name = "textBox_RenkoHigh";
            this.textBox_RenkoHigh.Size = new System.Drawing.Size(134, 21);
            this.textBox_RenkoHigh.TabIndex = 8;
            // 
            // button_Cal
            // 
            this.button_Cal.Location = new System.Drawing.Point(445, 94);
            this.button_Cal.Name = "button_Cal";
            this.button_Cal.Size = new System.Drawing.Size(134, 23);
            this.button_Cal.TabIndex = 9;
            this.button_Cal.Text = "开始生成";
            this.button_Cal.UseVisualStyleBackColor = true;
            this.button_Cal.Click += new System.EventHandler(this.button_Cal_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView_List);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 131);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1005, 161);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Multicharts-Fx成交列表";
            // 
            // dataGridView_List
            // 
            this.dataGridView_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_List.Location = new System.Drawing.Point(3, 17);
            this.dataGridView_List.Name = "dataGridView_List";
            this.dataGridView_List.RowTemplate.Height = 23;
            this.dataGridView_List.Size = new System.Drawing.Size(999, 141);
            this.dataGridView_List.TabIndex = 0;
            this.dataGridView_List.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.CellPainting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Symbol";
            this.Column1.HeaderText = "测试品种";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BarNum";
            this.Column2.HeaderText = "K线编号";
            this.Column2.Name = "Column2";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_OpenShares);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_EvetyLoss);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_RenkoHigh);
            this.groupBox2.Controls.Add(this.button_Cal);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1005, 131);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "策略设置";
            // 
            // textBox_OpenShares
            // 
            this.textBox_OpenShares.Location = new System.Drawing.Point(510, 50);
            this.textBox_OpenShares.Name = "textBox_OpenShares";
            this.textBox_OpenShares.Size = new System.Drawing.Size(69, 21);
            this.textBox_OpenShares.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(445, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "开仓手数:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Symbol);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox_needRenkoNum);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox_LastBarNum);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_KuiSunCout);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_YingliCout);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_allTradeCout);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(608, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 114);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "回测参数和MC对照";
            // 
            // textBox_Symbol
            // 
            this.textBox_Symbol.Location = new System.Drawing.Point(50, 45);
            this.textBox_Symbol.Name = "textBox_Symbol";
            this.textBox_Symbol.ReadOnly = true;
            this.textBox_Symbol.Size = new System.Drawing.Size(101, 21);
            this.textBox_Symbol.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "品种:";
            // 
            // textBox_needRenkoNum
            // 
            this.textBox_needRenkoNum.Location = new System.Drawing.Point(268, 17);
            this.textBox_needRenkoNum.Name = "textBox_needRenkoNum";
            this.textBox_needRenkoNum.ReadOnly = true;
            this.textBox_needRenkoNum.Size = new System.Drawing.Size(63, 21);
            this.textBox_needRenkoNum.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "需要加砖笔数:";
            // 
            // textBox_LastBarNum
            // 
            this.textBox_LastBarNum.Location = new System.Drawing.Point(155, 81);
            this.textBox_LastBarNum.Name = "textBox_LastBarNum";
            this.textBox_LastBarNum.ReadOnly = true;
            this.textBox_LastBarNum.Size = new System.Drawing.Size(50, 21);
            this.textBox_LastBarNum.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "图表最后一笔的Bar编号:";
            // 
            // textBox_KuiSunCout
            // 
            this.textBox_KuiSunCout.Location = new System.Drawing.Point(268, 42);
            this.textBox_KuiSunCout.Name = "textBox_KuiSunCout";
            this.textBox_KuiSunCout.ReadOnly = true;
            this.textBox_KuiSunCout.Size = new System.Drawing.Size(63, 21);
            this.textBox_KuiSunCout.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "亏损笔数:";
            // 
            // textBox_YingliCout
            // 
            this.textBox_YingliCout.Location = new System.Drawing.Point(289, 77);
            this.textBox_YingliCout.Name = "textBox_YingliCout";
            this.textBox_YingliCout.ReadOnly = true;
            this.textBox_YingliCout.Size = new System.Drawing.Size(65, 21);
            this.textBox_YingliCout.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "盈利笔数:";
            // 
            // textBox_allTradeCout
            // 
            this.textBox_allTradeCout.Location = new System.Drawing.Point(86, 20);
            this.textBox_allTradeCout.Name = "textBox_allTradeCout";
            this.textBox_allTradeCout.ReadOnly = true;
            this.textBox_allTradeCout.Size = new System.Drawing.Size(65, 21);
            this.textBox_allTradeCout.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "总交易笔数:";
            // 
            // SingleProductBackTestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Name = "SingleProductBackTestControl";
            this.Size = new System.Drawing.Size(1005, 600);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_List)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_InitQuality;
        private System.Windows.Forms.RadioButton radioButton_PointVisual;
        private System.Windows.Forms.RadioButton radioButton_MoneyVisual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_EvetyLoss;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_RenkoHigh;
        private System.Windows.Forms.Button button_Cal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView_List;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_LastBarNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_KuiSunCout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_YingliCout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_allTradeCout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_needRenkoNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Symbol;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_OpenShares;
        private System.Windows.Forms.Label label10;
    }
}
