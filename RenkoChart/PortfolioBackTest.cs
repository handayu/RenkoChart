using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenkoChart
{
    public partial class PortfolioBackTest : Form
    {
        private string m_Folder = string.Empty;

        private bool m_isValuePointStyleOpen = false;

        public PortfolioBackTest()
        {
            InitializeComponent();

            this.singleProductBackTestControl1.Visible = true;
            this.singleProductBackTestControl1.Dock = DockStyle.Fill;

            //this.valueSeriesControl1.Visible = false;

        }
        /// <summary>
        /// 失去焦点事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvSeries_Validated(object sender, EventArgs e)
        {
            try
            {
                if (this.listView_Strategy.FocusedItem != null)
                {
                    this.listView_Strategy.FocusedItem.BackColor = SystemColors.Highlight;
                    this.listView_Strategy.FocusedItem.ForeColor = Color.White;
                }

            }
            catch (Exception eEx)
            {
                MessageBox.Show(eEx.Message);
            }
        }

        public void HoldSingleStrategyDataAndSet(string path)
        {
            List<StandardTradingInfo> infoResut = HandelTxtToStadardTradingInfo.HandelStandardTradingInfoList(path);
            this.singleProductBackTestControl1.SetData(infoResut, path);
        }

        /// <summary>
        /// 弹出说明文档
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_Click_Help(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
        }

        /// <summary>
        /// 添加策略
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_AddStrategy_Click(object sender, EventArgs e)
        {
            try
            {
                AddStrategyTextPathForm f = new AddStrategyTextPathForm();
                f.ShowDialog();

                //上面现在给的是一个文件夹的路径@"X:\xxx\xxx"，搜索文件夹下路径的所有.txt文件导入-策略文件
                string filePath = f.IResult;

                m_Folder = filePath;

                string[] files = Directory.GetFiles(filePath, "*.txt");

                this.backgroundWorker1.RunWorkerAsync(files);

            }
            catch (Exception ex)
            {
                MessageBox.Show("添加策略外部数据错误,请检查后重试:" + ex.Message);
            }
        }

        /// <summary>
        /// 策略树点击切换策略
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectIndexItemChanged(object sender, EventArgs e)
        {
            ListView view = (ListView)sender;

            //路径名直接当策略名
            string pathName = view.FocusedItem.Text;

            if (!m_isValuePointStyleOpen)
            {
                try
                {
                    //单个策略
                    if (pathName != "----策略组")
                    {
                        this.singleProductBackTestControl1.Visible = true;
                        this.singleProductBackTestControl1.Dock = DockStyle.Fill;

                        if (!StrategyInfo.StrategyInfoDic.ContainsKey(pathName))
                        {
                            HoldSingleStrategyDataAndSet(pathName);
                        }
                        else
                        {
                            TradeStrategyInfo info;
                            StrategyInfo.StrategyInfoDic.TryGetValue(pathName, out info);
                            HoldSingleStrategyDataAndSet(pathName, info);
                            this.singleProductBackTestControl1.Cal();
                        }
                    }

                    //总的投资组合
                    if (pathName == "----策略组")
                    {
                        //this.singleProductBackTestControl1.Visible = false;
                        //this.folioControl1.Dock = DockStyle.Fill;
                        //this.folioControl1.Visible = true;

                        //this.folioControl1.Cal();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("发生异常信息,请检查后重试:" + ex.Message);
                }
            }
            else
            {
                //如果value模式打开的情况下
                HoldSingleVlaueStrategyDataAndSet(pathName);
            }

        }

        public void HoldSingleVlaueStrategyDataAndSet(string path)
        {
            List<ValueStandardTradingInfo> infoResut = HandelTxtToStadardTradingInfo.HandelValueStandardTradingInfoList(path);
            //this.valueSeriesControl1.SetData(infoResut, path);
        }

        private void HoldSingleStrategyDataAndSet(string pathName, TradeStrategyInfo info)
        {
            this.singleProductBackTestControl1.SetExitsData(info, pathName);
        }

        private void ToolStripMenuItem_RenkoSeries_Click(object sender, EventArgs e)
        {
            TimeSeriesRenkoPortfolioForm holder = new TimeSeriesRenkoPortfolioForm();
            holder.Show();
        }

        private bool m_isView = true;

        /// <summary>
        /// 显示详细或者隐藏详细布局
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_SeeOrVisual_Click(object sender, EventArgs e)
        {
            if (m_isView)
            {
                this.singleProductBackTestControl1.NoVisualLayOut();
                this.singleProductBackTestControl1.NoVisualNoNeedRenkoSeries();
                m_isView = false;
            }
            else
            {
                this.singleProductBackTestControl1.VisualLayOut();
                this.singleProductBackTestControl1.VisualNoNeedRenkoSeries();
                m_isView = true;
            }
        }

        private void AddListViewItems(string fileName)
        {
            this.listView_Strategy.Items.Add(fileName);
        }

        private void BackGroundWork_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] files = (string[])e.Argument;

            //FormProgressBar bar = new FormProgressBar();
            //bar.Show();
            //bar.TopMost = true;

            foreach (string file in files)
            {
                try
                {
                    HoldSingleStrategyDataAndSet(file);
                    this.backgroundWorker1.ReportProgress(1, file);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(file + ":添加策略内部循环数据错误,请检查:" + ex.Message);
                }
            }
        }

        private void BackGroundWork_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string file = (string)e.UserState;
            //添加一条Item到treeView中
            this.listView_Strategy.BeginInvoke(new Action<string>(AddListViewItems), file);
        }

        private void BackGroundWork_ProgressCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void ToolStripMenuItem_RefrashStrategyContains(object sender, EventArgs e)
        {
            try
            {
                //遍历文件夹所有fullname，如果items没有，加入
                List<string> files = Directory.GetFiles(m_Folder, "*.txt").ToList();
                foreach (string filePath in files)
                {
                    try
                    {
                        bool iFind = false;

                        ListView.ListViewItemCollection c = this.listView_Strategy.Items;

                        foreach (ListViewItem item in c)
                        {
                            if (item.Text == filePath)
                            {
                                iFind = true;
                                break;
                            }
                        }

                        if (!iFind)
                        {
                            HoldSingleStrategyDataAndSet(filePath);
                            this.listView_Strategy.Items.Add(filePath);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("刷新策略发生异常,请检查:" + ex.Message);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("刷新发生异常:{0},请检查重试...",ex.Message));
            }
        }

        private void ToolStripMenuItem_ValueSeriesClick(object sender, EventArgs e)
        {
            try
            {
                m_isValuePointStyleOpen = true;

                //隐藏SingleControl,打开点值设置界面
                this.singleProductBackTestControl1.Visible = false;
                //this.valueSeriesControl1.Visible = true;
                //this.valueSeriesControl1.Dock = DockStyle.Fill;

                AddValueSeriesStrategyTextPathForm f = new AddValueSeriesStrategyTextPathForm();
                f.ShowDialog();

                //上面现在给的是一个文件夹的路径@"X:\xxx\xxx"，搜索文件夹下路径的所有.txt文件导入-策略文件
                string filePath = f.IResult;

                m_Folder = filePath;

                string[] files = Directory.GetFiles(filePath, "*.txt");

                foreach (string file in files)
                {
                    try
                    {
                        this.listView_Strategy.Items.Add(file);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(file + ":添加策略内部循环数据错误,请检查:" + ex.Message);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("添加策略外部数据错误,请检查后重试:" + ex.Message);
            }
        }

        private void ToolStripMenuItem_SpileseClick(object sender, EventArgs e)
        {
            FormSpilise f = new FormSpilise();
            f.Show();
        }
    }

}
