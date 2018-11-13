using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenkoChart
{
    public partial class SingleProductBackTestControl : UserControl
    {
        /// <summary>
        /// 每笔交易
        /// </summary>
        private BindingList<StandardTradingInfo> m_tradeList = new BindingList<StandardTradingInfo>();

        public SingleProductBackTestControl()
        {
            InitializeComponent();

            this.dataGridView_List.Visible = true;
            this.dataGridView_List.Dock = DockStyle.Fill;

            this.dataGridView_List.AutoGenerateColumns = false;
            this.dataGridView_List.DataSource = m_tradeList;

            SetDefultData();
        }

        private string m_pathName = string.Empty;

        public void SetData(List<StandardTradingInfo> infoResut,string pathName)
        {
            //先清空所有的之前的数据
            ClearAndDefult();

            m_pathName = pathName;

            //添加交易的表数据
            foreach (StandardTradingInfo info in infoResut)
            {
                m_tradeList.Add(info);
            }

            //添加回测的数据汇总和MC对照
            if(m_tradeList.Count > 0)
            {
                this.textBox_RenkoHigh.Text = m_tradeList[0].RenkoHight.ToString();
                this.textBox_allTradeCout.Text = m_tradeList.Count.ToString();

                double yingLiCout = 0.00;
                double kuiSunCout = 0.00;
                double needRenkoNum = 0.00;
                foreach(StandardTradingInfo info in m_tradeList)
                {
                    if(info.LastCloseProfit <= 0)
                    {
                        kuiSunCout = kuiSunCout + 1;
                    }
                    else
                    {
                        yingLiCout = yingLiCout + 1;
                    }

                    if(info.RenkoCommision < 0)
                    {
                        needRenkoNum = needRenkoNum + 1;
                    }
                }

                this.textBox_KuiSunCout.Text = kuiSunCout.ToString();
                this.textBox_YingliCout.Text = yingLiCout.ToString();
                this.textBox_LastBarNum.Text = m_tradeList[m_tradeList.Count - 1].BarNum;
                this.textBox_Symbol.Text = m_tradeList[0].Symbol;
                this.textBox_needRenkoNum.Text = needRenkoNum.ToString();

            }
        }

        private void ClearAndDefult()
        {
            this.textBox_EvetyLoss.Text = "0";
            this.textBox_InitQuality.Text = "100000";
            this.textBox_RenkoHigh.Text = "0";

            this.radioButton_PointVisual.Checked = true;
            this.radioButton_MoneyVisual.Checked = false;

            this.textBox_KuiSunCout.Text = "0";
            this.textBox_allTradeCout.Text = "0";
            this.textBox_YingliCout.Text = "0";
            this.textBox_Symbol.Text = "0";
            this.textBox_needRenkoNum.Text = "0";
            this.textBox_LastBarNum.Text = "0";

            this.textBox_OpenShares.Text = "1";

            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();

            m_tradeList.Clear();
        }

        internal void SetExitsData(TradeStrategyInfo info, string pathName)
        {
            //先清空所有的之前的数据
            ClearAndDefult();

            m_pathName = pathName;

            //添加交易的表数据
            foreach (StandardTradingInfo i in info.StrategyTradeInfoList)
            {
                m_tradeList.Add(i);
            }

            //添加回测的数据汇总和MC对照
            if (m_tradeList.Count > 0)
            {
                this.textBox_RenkoHigh.Text = m_tradeList[0].RenkoHight.ToString();
                this.textBox_allTradeCout.Text = m_tradeList.Count.ToString();

                double yingLiCout = 0.00;
                double kuiSunCout = 0.00;
                double needRenkoNum = 0.00;
                foreach (StandardTradingInfo i in m_tradeList)
                {
                    if (i.LastCloseProfit <= 0)
                    {
                        kuiSunCout = kuiSunCout + 1;
                    }
                    else
                    {
                        yingLiCout = yingLiCout + 1;
                    }

                    if (i.RenkoCommision < 0)
                    {
                        needRenkoNum = needRenkoNum + 1;
                    }
                }

                this.textBox_KuiSunCout.Text = kuiSunCout.ToString();
                this.textBox_YingliCout.Text = yingLiCout.ToString();
                this.textBox_LastBarNum.Text = m_tradeList[m_tradeList.Count - 1].BarNum;
                this.textBox_Symbol.Text = m_tradeList[0].Symbol;

                this.textBox_needRenkoNum.Text = needRenkoNum.ToString();

                this.textBox_InitQuality.Text = info.StrategyMonetSet;
                this.textBox_EvetyLoss.Text = info.StrategyCommisionSet;
                this.textBox_OpenShares.Text = info.StrategyOpenShares;
            }
        }

        private void SetDefultData()
        {
            this.textBox_EvetyLoss.Text = "0";
            this.textBox_InitQuality.Text = "100000";
            this.textBox_RenkoHigh.Text = "0";
            this.textBox_OpenShares.Text = "1";

            this.radioButton_PointVisual.Checked = true;
            this.radioButton_MoneyVisual.Checked = false;

            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();

        }

        public void Cal()
        {
            button_Cal_Click(null, null);
        }

        /// <summary>
        /// 生成不加砖的资金曲线(但是加手续费)/生成加砖的资金曲线(也要加上手续费)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Cal_Click(object sender, EventArgs e)
        {
            if(radioButton_PointVisual.Checked)
            {
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();

                double noAddRenkoButAddCommisonQualitySeries = 0.00;

                double commisionValue = 0.00;
                double.TryParse(this.textBox_EvetyLoss.Text, out commisionValue);
                    
                double openshares = 0.00;
                double.TryParse(this.textBox_OpenShares.Text, out openshares);
                  
                for (int i = 0; i < m_tradeList.Count; i++)
                {
                    noAddRenkoButAddCommisonQualitySeries = noAddRenkoButAddCommisonQualitySeries + m_tradeList[i].LastCloseProfit - commisionValue;
                    this.chart1.Series["不加砖成本的资金曲线"].Points.AddXY(i, noAddRenkoButAddCommisonQualitySeries* openshares);
                }

                double addRenkoAddCommisonQualitySeries = 0.00;
                for (int i = 0; i < m_tradeList.Count; i++)
                {
                    addRenkoAddCommisonQualitySeries = addRenkoAddCommisonQualitySeries + m_tradeList[i].LastCloseProfit - commisionValue + m_tradeList[i].RenkoCommision*2;
                    this.chart1.Series["加入砖成本的资金曲线"].Points.AddXY(i, addRenkoAddCommisonQualitySeries* openshares);
                }
            }

            if (radioButton_MoneyVisual.Checked)
            {
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();

                double noAddRenkoButAddCommisonQualitySeries = 0.00;
                double.TryParse(this.textBox_InitQuality.Text, out noAddRenkoButAddCommisonQualitySeries);


                double commisionValue = 0.00;
                double.TryParse(this.textBox_EvetyLoss.Text, out commisionValue);

                double openshares = 0.00;
                double.TryParse(this.textBox_OpenShares.Text, out openshares);


                for (int i = 0; i < m_tradeList.Count; i++)
                {
                    noAddRenkoButAddCommisonQualitySeries = noAddRenkoButAddCommisonQualitySeries +( m_tradeList[i].LastCloseProfit - commisionValue) * m_tradeList[i].BigPointValue;
                    this.chart1.Series[0].Points.AddXY(i, noAddRenkoButAddCommisonQualitySeries* openshares);
                }

                double addRenkoAddCommisonQualitySeries = 0.00;
                double.TryParse(this.textBox_InitQuality.Text, out addRenkoAddCommisonQualitySeries);

                for (int i = 0; i < m_tradeList.Count; i++)
                {
                    addRenkoAddCommisonQualitySeries = addRenkoAddCommisonQualitySeries + (m_tradeList[i].LastCloseProfit - commisionValue + m_tradeList[i].RenkoCommision*2)*m_tradeList[i].BigPointValue;
                    this.chart1.Series[1].Points.AddXY(i, addRenkoAddCommisonQualitySeries* openshares);
                }
            }

            //保存目前设置的所有数据(每点击一次，清空之前保存的，保留现在最新的)
            TradeStrategyInfo info = new TradeStrategyInfo();
            info.StrategyCommisionSet = this.textBox_EvetyLoss.Text;
            info.StrategyMonetSet = this.textBox_InitQuality.Text;
            info.StrategyPathName = m_pathName;
            info.StrategyTradeInfoList = m_tradeList.ToList();
            info.StrategyOpenShares = this.textBox_OpenShares.Text;
            StrategyInfo.AddStratgyInfo(m_pathName, info);

            this.Focus();
        }

        private void RadioCheckChanged(object sender, EventArgs e)
        {

        }

        private void CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //对datagrid-有砖成本的数据进行高亮处理，便于查找出来进行对照
            for (int i = 0; i < m_tradeList.Count; i++)
            {
                if (m_tradeList[i].RenkoCommision < 0)
                {
                    this.dataGridView_List.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
    }
}
