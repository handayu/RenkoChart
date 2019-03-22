namespace RenkoChart
{
    partial class PortfolioBackTest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortfolioBackTest));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView_Strategy = new System.Windows.Forms.ListView();
            this.策略列表 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_AddStrategy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_RefrashStrategy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ValueSeries = new System.Windows.Forms.ToolStripMenuItem();
            this.singleProductBackTestControl1 = new RenkoChart.SingleProductBackTestControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.使用帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_RenkoSeries = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_SeeOrVisual = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ToolStripMenuItem_Spilese = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.singleProductBackTestControl1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView_Strategy);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // listView_Strategy
            // 
            this.listView_Strategy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.策略列表});
            this.listView_Strategy.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.listView_Strategy, "listView_Strategy");
            this.listView_Strategy.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Strategy.Name = "listView_Strategy";
            this.listView_Strategy.UseCompatibleStateImageBehavior = false;
            this.listView_Strategy.View = System.Windows.Forms.View.Details;
            this.listView_Strategy.SelectedIndexChanged += new System.EventHandler(this.SelectIndexItemChanged);
            // 
            // 策略列表
            // 
            resources.ApplyResources(this.策略列表, "策略列表");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_AddStrategy,
            this.ToolStripMenuItem_RefrashStrategy,
            this.ToolStripMenuItem_ValueSeries});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // ToolStripMenuItem_AddStrategy
            // 
            this.ToolStripMenuItem_AddStrategy.Name = "ToolStripMenuItem_AddStrategy";
            resources.ApplyResources(this.ToolStripMenuItem_AddStrategy, "ToolStripMenuItem_AddStrategy");
            this.ToolStripMenuItem_AddStrategy.Click += new System.EventHandler(this.ToolStripMenuItem_AddStrategy_Click);
            // 
            // ToolStripMenuItem_RefrashStrategy
            // 
            this.ToolStripMenuItem_RefrashStrategy.Name = "ToolStripMenuItem_RefrashStrategy";
            resources.ApplyResources(this.ToolStripMenuItem_RefrashStrategy, "ToolStripMenuItem_RefrashStrategy");
            this.ToolStripMenuItem_RefrashStrategy.Click += new System.EventHandler(this.ToolStripMenuItem_RefrashStrategyContains);
            // 
            // ToolStripMenuItem_ValueSeries
            // 
            this.ToolStripMenuItem_ValueSeries.Name = "ToolStripMenuItem_ValueSeries";
            resources.ApplyResources(this.ToolStripMenuItem_ValueSeries, "ToolStripMenuItem_ValueSeries");
            this.ToolStripMenuItem_ValueSeries.Click += new System.EventHandler(this.ToolStripMenuItem_ValueSeriesClick);
            // 
            // singleProductBackTestControl1
            // 
            resources.ApplyResources(this.singleProductBackTestControl1, "singleProductBackTestControl1");
            this.singleProductBackTestControl1.Name = "singleProductBackTestControl1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使用帮助ToolStripMenuItem,
            this.ToolStripMenuItem_RenkoSeries,
            this.设置ToolStripMenuItem,
            this.ToolStripMenuItem_Spilese});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // 使用帮助ToolStripMenuItem
            // 
            this.使用帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Help});
            this.使用帮助ToolStripMenuItem.Name = "使用帮助ToolStripMenuItem";
            resources.ApplyResources(this.使用帮助ToolStripMenuItem, "使用帮助ToolStripMenuItem");
            // 
            // ToolStripMenuItem_Help
            // 
            this.ToolStripMenuItem_Help.Name = "ToolStripMenuItem_Help";
            resources.ApplyResources(this.ToolStripMenuItem_Help, "ToolStripMenuItem_Help");
            this.ToolStripMenuItem_Help.Click += new System.EventHandler(this.ToolStripMenuItem_Click_Help);
            // 
            // ToolStripMenuItem_RenkoSeries
            // 
            this.ToolStripMenuItem_RenkoSeries.Name = "ToolStripMenuItem_RenkoSeries";
            resources.ApplyResources(this.ToolStripMenuItem_RenkoSeries, "ToolStripMenuItem_RenkoSeries");
            this.ToolStripMenuItem_RenkoSeries.Click += new System.EventHandler(this.ToolStripMenuItem_RenkoSeries_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_SeeOrVisual});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            resources.ApplyResources(this.设置ToolStripMenuItem, "设置ToolStripMenuItem");
            // 
            // ToolStripMenuItem_SeeOrVisual
            // 
            this.ToolStripMenuItem_SeeOrVisual.Name = "ToolStripMenuItem_SeeOrVisual";
            resources.ApplyResources(this.ToolStripMenuItem_SeeOrVisual, "ToolStripMenuItem_SeeOrVisual");
            this.ToolStripMenuItem_SeeOrVisual.Click += new System.EventHandler(this.ToolStripMenuItem_SeeOrVisual_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackGroundWork_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackGroundWork_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackGroundWork_ProgressCompleted);
            // 
            // ToolStripMenuItem_Spilese
            // 
            this.ToolStripMenuItem_Spilese.Name = "ToolStripMenuItem_Spilese";
            resources.ApplyResources(this.ToolStripMenuItem_Spilese, "ToolStripMenuItem_Spilese");
            this.ToolStripMenuItem_Spilese.Click += new System.EventHandler(this.ToolStripMenuItem_SpileseClick);
            // 
            // PortfolioBackTest
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "PortfolioBackTest";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView_Strategy;
        private SingleProductBackTestControl singleProductBackTestControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 使用帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Help;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_AddStrategy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_RenkoSeries;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SeeOrVisual;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ColumnHeader 策略列表;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_RefrashStrategy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ValueSeries;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Spilese;
        //private ValueSeriesControl valueSeriesControl1;
    }
}