using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

                //添加一条Item到treeView中
                this.listView_Strategy.Items.Add(f.IResult);

                string path = f.IResult;
                HoldSingleStrategyDataAndSet(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生异常信息,请检查后重试:" + ex.Message);
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
    }
}
