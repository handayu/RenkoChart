namespace RenkoChart
{
    partial class TimeSeriesRenkoQualityFolioControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_HandleAfter = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_MCEditTradeList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_AddStrategySeries = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_CalFolio = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_VisualSingleStrategy = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HandleAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MCEditTradeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 504);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.55196F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.44804F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(866, 504);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.chart1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(154, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.9009F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.0991F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(709, 498);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.52347F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.47653F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridView_HandleAfter, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView_MCEditTradeList, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(703, 122);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // dataGridView_HandleAfter
            // 
            this.dataGridView_HandleAfter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HandleAfter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView_HandleAfter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_HandleAfter.Location = new System.Drawing.Point(316, 3);
            this.dataGridView_HandleAfter.MultiSelect = false;
            this.dataGridView_HandleAfter.Name = "dataGridView_HandleAfter";
            this.dataGridView_HandleAfter.RowTemplate.Height = 23;
            this.dataGridView_HandleAfter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_HandleAfter.Size = new System.Drawing.Size(384, 116);
            this.dataGridView_HandleAfter.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Symbol";
            this.dataGridViewTextBoxColumn1.HeaderText = "品种";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateInfo";
            this.dataGridViewTextBoxColumn2.HeaderText = "日期";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quality";
            this.dataGridViewTextBoxColumn4.HeaderText = "资金";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridView_MCEditTradeList
            // 
            this.dataGridView_MCEditTradeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MCEditTradeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column10,
            this.Column3});
            this.dataGridView_MCEditTradeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_MCEditTradeList.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_MCEditTradeList.MultiSelect = false;
            this.dataGridView_MCEditTradeList.Name = "dataGridView_MCEditTradeList";
            this.dataGridView_MCEditTradeList.RowTemplate.Height = 23;
            this.dataGridView_MCEditTradeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_MCEditTradeList.Size = new System.Drawing.Size(307, 116);
            this.dataGridView_MCEditTradeList.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Symbol";
            this.Column1.HeaderText = "品种";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DateInfo";
            this.Column2.HeaderText = "日期";
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TimeInfo";
            this.Column4.HeaderText = "时间";
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Quality";
            this.Column10.HeaderText = "资金";
            this.Column10.Name = "Column10";
            this.Column10.Width = 80;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PositionProfit";
            this.Column3.HeaderText = "上一笔盈亏";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 131);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(703, 364);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(145, 498);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_AddStrategySeries,
            this.ToolStripMenuItem_CalFolio,
            this.ToolStripMenuItem_VisualSingleStrategy});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 70);
            // 
            // ToolStripMenuItem_AddStrategySeries
            // 
            this.ToolStripMenuItem_AddStrategySeries.Name = "ToolStripMenuItem_AddStrategySeries";
            this.ToolStripMenuItem_AddStrategySeries.Size = new System.Drawing.Size(173, 22);
            this.ToolStripMenuItem_AddStrategySeries.Text = "添加策略";
            this.ToolStripMenuItem_AddStrategySeries.Click += new System.EventHandler(this.ToolStripMenuItem_AddStrategySeries_Click);
            // 
            // ToolStripMenuItem_CalFolio
            // 
            this.ToolStripMenuItem_CalFolio.Name = "ToolStripMenuItem_CalFolio";
            this.ToolStripMenuItem_CalFolio.Size = new System.Drawing.Size(173, 22);
            this.ToolStripMenuItem_CalFolio.Text = "计算组合";
            this.ToolStripMenuItem_CalFolio.Click += new System.EventHandler(this.ToolStripMenuItem_CalFolio_Click);
            // 
            // ToolStripMenuItem_VisualSingleStrategy
            // 
            this.ToolStripMenuItem_VisualSingleStrategy.Name = "ToolStripMenuItem_VisualSingleStrategy";
            this.ToolStripMenuItem_VisualSingleStrategy.Size = new System.Drawing.Size(173, 22);
            this.ToolStripMenuItem_VisualSingleStrategy.Text = "隐藏/显示[单策略]";
            this.ToolStripMenuItem_VisualSingleStrategy.Click += new System.EventHandler(this.ToolStripMenuItem_VisualSingleStrategy_Click);
            // 
            // TimeSeriesRenkoQualityFolioControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TimeSeriesRenkoQualityFolioControl";
            this.Size = new System.Drawing.Size(866, 504);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HandleAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MCEditTradeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dataGridView_HandleAfter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dataGridView_MCEditTradeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_AddStrategySeries;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_CalFolio;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_VisualSingleStrategy;
    }
}
