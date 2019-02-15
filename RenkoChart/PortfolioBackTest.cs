using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public PortfolioBackTest()
        {
            InitializeComponent();

            this.folioControl1.Visible = false;
            this.singleProductBackTestControl1.Visible = true;
            this.singleProductBackTestControl1.Dock = DockStyle.Fill;
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
            try
            {
                ListView view = (ListView)sender;

                //路径名直接当策略名
                string pathName = view.FocusedItem.Text;

                //单个策略
                if (pathName != "----策略组")
                {
                    this.singleProductBackTestControl1.Visible = true;
                    this.singleProductBackTestControl1.Dock = DockStyle.Fill;

                    this.folioControl1.Visible = false;

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
                    this.singleProductBackTestControl1.Visible = false;
                    this.folioControl1.Dock = DockStyle.Fill;
                    this.folioControl1.Visible = true;

                    this.folioControl1.Cal();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生异常信息,请检查后重试:" + ex.Message);
            }
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
                    this.backgroundWorker1.ReportProgress(1,file);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("添加策略内部循环数据错误,请检查后重试:" + ex.Message);
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
    }
}
