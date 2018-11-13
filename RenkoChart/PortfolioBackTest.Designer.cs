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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("----策略组");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView_Strategy = new System.Windows.Forms.ListView();
            this.策略 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_AddStrategy = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.使用帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.singleProductBackTestControl1 = new RenkoChart.SingleProductBackTestControl();
            this.folioControl1 = new RenkoChart.FolioControl();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView_Strategy);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 623);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "加载策略";
            // 
            // listView_Strategy
            // 
            this.listView_Strategy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.策略});
            this.listView_Strategy.ContextMenuStrip = this.contextMenuStrip1;
            this.listView_Strategy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Strategy.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView_Strategy.Location = new System.Drawing.Point(3, 19);
            this.listView_Strategy.Name = "listView_Strategy";
            this.listView_Strategy.Size = new System.Drawing.Size(160, 601);
            this.listView_Strategy.TabIndex = 0;
            this.listView_Strategy.UseCompatibleStateImageBehavior = false;
            this.listView_Strategy.View = System.Windows.Forms.View.List;
            this.listView_Strategy.SelectedIndexChanged += new System.EventHandler(this.SelectIndexItemChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_AddStrategy});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // ToolStripMenuItem_AddStrategy
            // 
            this.ToolStripMenuItem_AddStrategy.Name = "ToolStripMenuItem_AddStrategy";
            this.ToolStripMenuItem_AddStrategy.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_AddStrategy.Text = "添加策略";
            this.ToolStripMenuItem_AddStrategy.Click += new System.EventHandler(this.ToolStripMenuItem_AddStrategy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "砖的高度(见MC设置点):";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使用帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1170, 25);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 使用帮助ToolStripMenuItem
            // 
            this.使用帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Help});
            this.使用帮助ToolStripMenuItem.Name = "使用帮助ToolStripMenuItem";
            this.使用帮助ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.使用帮助ToolStripMenuItem.Text = "使用帮助";
            // 
            // ToolStripMenuItem_Help
            // 
            this.ToolStripMenuItem_Help.Name = "ToolStripMenuItem_Help";
            this.ToolStripMenuItem_Help.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItem_Help.Text = "说明档";
            this.ToolStripMenuItem_Help.Click += new System.EventHandler(this.ToolStripMenuItem_Click_Help);
            // 
            // singleProductBackTestControl1
            // 
            this.singleProductBackTestControl1.Location = new System.Drawing.Point(505, 197);
            this.singleProductBackTestControl1.Name = "singleProductBackTestControl1";
            this.singleProductBackTestControl1.Size = new System.Drawing.Size(665, 451);
            this.singleProductBackTestControl1.TabIndex = 8;
            // 
            // folioControl1
            // 
            this.folioControl1.Location = new System.Drawing.Point(207, 44);
            this.folioControl1.Name = "folioControl1";
            this.folioControl1.Size = new System.Drawing.Size(884, 566);
            this.folioControl1.TabIndex = 10;
            // 
            // PortfolioBackTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 648);
            this.Controls.Add(this.folioControl1);
            this.Controls.Add(this.singleProductBackTestControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PortfolioBackTest";
            this.Text = "投资组合(调整)回测系统";
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
        private System.Windows.Forms.Label label1;
        private SingleProductBackTestControl singleProductBackTestControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 使用帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Help;
        private System.Windows.Forms.ColumnHeader 策略;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_AddStrategy;
        private SingleProductBackTestControl singleProductBackTestControl2;
        private FolioControl folioControl1;
    }
}