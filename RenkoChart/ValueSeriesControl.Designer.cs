namespace RenkoChart
{
    partial class ValueSeriesControl
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_Cal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_AllOutMoney = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_BigpointValue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_DateTimeSpanEnd = new System.Windows.Forms.TextBox();
            this.textBox_FutuRenkoHeight = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_DateTimeSpanStart = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_Symbol = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_allTradeCout = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_AllCommision = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ResultHuaDian = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_MinMove2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_LossHuaDian = new System.Windows.Forms.TextBox();
            this.textBox_ResultPointCommision = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_MinMove1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_LossCommision = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_VComminso = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisY.ScaleBreakStyle.Spacing = 0.5D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 215);
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
            this.chart1.Size = new System.Drawing.Size(987, 227);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // button_Cal
            // 
            this.button_Cal.Location = new System.Drawing.Point(770, 175);
            this.button_Cal.Name = "button_Cal";
            this.button_Cal.Size = new System.Drawing.Size(155, 23);
            this.button_Cal.TabIndex = 9;
            this.button_Cal.Text = "开始生成";
            this.button_Cal.UseVisualStyleBackColor = true;
            this.button_Cal.Click += new System.EventHandler(this.button_Cal_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_AllOutMoney);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_BigpointValue);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox_AllCommision);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox_ResultHuaDian);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_MinMove2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_LossHuaDian);
            this.groupBox2.Controls.Add(this.textBox_ResultPointCommision);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_MinMove1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_LossCommision);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button_Cal);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(987, 215);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "策略设置";
            // 
            // textBox_AllOutMoney
            // 
            this.textBox_AllOutMoney.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_AllOutMoney.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_AllOutMoney.Location = new System.Drawing.Point(761, 28);
            this.textBox_AllOutMoney.Name = "textBox_AllOutMoney";
            this.textBox_AllOutMoney.ReadOnly = true;
            this.textBox_AllOutMoney.Size = new System.Drawing.Size(148, 21);
            this.textBox_AllOutMoney.TabIndex = 35;
            this.textBox_AllOutMoney.Text = "进出一次的成本(金额)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(744, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 34;
            this.label3.Text = "=";
            // 
            // textBox_BigpointValue
            // 
            this.textBox_BigpointValue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_BigpointValue.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_BigpointValue.Location = new System.Drawing.Point(633, 28);
            this.textBox_BigpointValue.Name = "textBox_BigpointValue";
            this.textBox_BigpointValue.ReadOnly = true;
            this.textBox_BigpointValue.Size = new System.Drawing.Size(105, 21);
            this.textBox_BigpointValue.TabIndex = 33;
            this.textBox_BigpointValue.Text = "BigPointValue";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(616, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 28;
            this.label11.Text = "*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.textBox_VComminso);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBox_DateTimeSpanEnd);
            this.groupBox1.Controls.Add(this.textBox_FutuRenkoHeight);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox_DateTimeSpanStart);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox_Symbol);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox_allTradeCout);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 131);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "回测参数和MC对照";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(178, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 12);
            this.label14.TabIndex = 37;
            this.label14.Text = "-";
            // 
            // textBox_DateTimeSpanEnd
            // 
            this.textBox_DateTimeSpanEnd.Location = new System.Drawing.Point(195, 62);
            this.textBox_DateTimeSpanEnd.Name = "textBox_DateTimeSpanEnd";
            this.textBox_DateTimeSpanEnd.ReadOnly = true;
            this.textBox_DateTimeSpanEnd.Size = new System.Drawing.Size(101, 21);
            this.textBox_DateTimeSpanEnd.TabIndex = 36;
            // 
            // textBox_FutuRenkoHeight
            // 
            this.textBox_FutuRenkoHeight.Location = new System.Drawing.Point(71, 98);
            this.textBox_FutuRenkoHeight.Name = "textBox_FutuRenkoHeight";
            this.textBox_FutuRenkoHeight.ReadOnly = true;
            this.textBox_FutuRenkoHeight.Size = new System.Drawing.Size(101, 21);
            this.textBox_FutuRenkoHeight.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 33;
            this.label13.Text = "副图砖高:";
            // 
            // textBox_DateTimeSpanStart
            // 
            this.textBox_DateTimeSpanStart.Location = new System.Drawing.Point(71, 62);
            this.textBox_DateTimeSpanStart.Name = "textBox_DateTimeSpanStart";
            this.textBox_DateTimeSpanStart.ReadOnly = true;
            this.textBox_DateTimeSpanStart.Size = new System.Drawing.Size(101, 21);
            this.textBox_DateTimeSpanStart.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 29;
            this.label12.Text = "时间区间:";
            // 
            // textBox_Symbol
            // 
            this.textBox_Symbol.Location = new System.Drawing.Point(47, 25);
            this.textBox_Symbol.Name = "textBox_Symbol";
            this.textBox_Symbol.ReadOnly = true;
            this.textBox_Symbol.Size = new System.Drawing.Size(101, 21);
            this.textBox_Symbol.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "品种:";
            // 
            // textBox_allTradeCout
            // 
            this.textBox_allTradeCout.Location = new System.Drawing.Point(252, 25);
            this.textBox_allTradeCout.Name = "textBox_allTradeCout";
            this.textBox_allTradeCout.ReadOnly = true;
            this.textBox_allTradeCout.Size = new System.Drawing.Size(81, 21);
            this.textBox_allTradeCout.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "总交易笔数:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(593, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 26;
            this.label10.Text = "点";
            // 
            // textBox_AllCommision
            // 
            this.textBox_AllCommision.Location = new System.Drawing.Point(507, 30);
            this.textBox_AllCommision.Name = "textBox_AllCommision";
            this.textBox_AllCommision.Size = new System.Drawing.Size(80, 21);
            this.textBox_AllCommision.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(490, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "=";
            // 
            // textBox_ResultHuaDian
            // 
            this.textBox_ResultHuaDian.Location = new System.Drawing.Point(402, 43);
            this.textBox_ResultHuaDian.Name = "textBox_ResultHuaDian";
            this.textBox_ResultHuaDian.Size = new System.Drawing.Size(80, 21);
            this.textBox_ResultHuaDian.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "=";
            // 
            // textBox_MinMove2
            // 
            this.textBox_MinMove2.Location = new System.Drawing.Point(299, 43);
            this.textBox_MinMove2.Name = "textBox_MinMove2";
            this.textBox_MinMove2.ReadOnly = true;
            this.textBox_MinMove2.Size = new System.Drawing.Size(71, 21);
            this.textBox_MinMove2.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "*";
            // 
            // textBox_LossHuaDian
            // 
            this.textBox_LossHuaDian.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_LossHuaDian.Location = new System.Drawing.Point(50, 43);
            this.textBox_LossHuaDian.Name = "textBox_LossHuaDian";
            this.textBox_LossHuaDian.Size = new System.Drawing.Size(226, 21);
            this.textBox_LossHuaDian.TabIndex = 19;
            this.textBox_LossHuaDian.Text = "进出一次滑点需要几跳才能覆盖...";
            this.textBox_LossHuaDian.TextChanged += new System.EventHandler(this.SlipileTextChanged);
            // 
            // textBox_ResultPointCommision
            // 
            this.textBox_ResultPointCommision.Location = new System.Drawing.Point(402, 16);
            this.textBox_ResultPointCommision.Name = "textBox_ResultPointCommision";
            this.textBox_ResultPointCommision.Size = new System.Drawing.Size(80, 21);
            this.textBox_ResultPointCommision.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "=";
            // 
            // textBox_MinMove1
            // 
            this.textBox_MinMove1.Location = new System.Drawing.Point(299, 16);
            this.textBox_MinMove1.Name = "textBox_MinMove1";
            this.textBox_MinMove1.ReadOnly = true;
            this.textBox_MinMove1.Size = new System.Drawing.Size(71, 21);
            this.textBox_MinMove1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "*";
            // 
            // textBox_LossCommision
            // 
            this.textBox_LossCommision.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_LossCommision.Location = new System.Drawing.Point(50, 16);
            this.textBox_LossCommision.Name = "textBox_LossCommision";
            this.textBox_LossCommision.Size = new System.Drawing.Size(226, 21);
            this.textBox_LossCommision.TabIndex = 11;
            this.textBox_LossCommision.Text = "进出一次手续费需要几跳才能覆盖...";
            this.textBox_LossCommision.TextChanged += new System.EventHandler(this.CommisionTextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "成本:";
            // 
            // textBox_VComminso
            // 
            this.textBox_VComminso.Location = new System.Drawing.Point(246, 98);
            this.textBox_VComminso.Name = "textBox_VComminso";
            this.textBox_VComminso.ReadOnly = true;
            this.textBox_VComminso.Size = new System.Drawing.Size(81, 21);
            this.textBox_VComminso.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(193, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 12);
            this.label15.TabIndex = 38;
            this.label15.Text = "总成本:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(338, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(167, 12);
            this.label16.TabIndex = 40;
            this.label16.Text = "交易笔数*单次(一进一出成本)";
            // 
            // ValueSeriesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ValueSeriesControl";
            this.Size = new System.Drawing.Size(987, 442);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button_Cal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_AllOutMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_BigpointValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_FutuRenkoHeight;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_DateTimeSpanStart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_Symbol;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_allTradeCout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_AllCommision;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_ResultHuaDian;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_MinMove2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_LossHuaDian;
        private System.Windows.Forms.TextBox textBox_ResultPointCommision;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_MinMove1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_LossCommision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_DateTimeSpanEnd;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_VComminso;
        private System.Windows.Forms.Label label15;
    }
}
