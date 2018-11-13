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
    public partial class FolioControl : UserControl
    {
        /// <summary>
        /// 每笔交易
        /// </summary>
        private BindingList<TradeStrategyInfo> m_StrategyList = new BindingList<TradeStrategyInfo>();
        private BindingList<StandardTradingInfo> m_StrategyTradeList = new BindingList<StandardTradingInfo>();


        public FolioControl()
        {
            InitializeComponent();

            this.chart1.Titles.Add("组合集合曲线(各策略去砖去手续费按手数资金叠加)");

            this.dataGridView_StrategyList.Visible = true;
            this.dataGridView_StrategyList.Dock = DockStyle.Fill;

            this.dataGridView_StrategyList.AutoGenerateColumns = false;
            this.dataGridView_StrategyList.DataSource = m_StrategyList;

            this.dataGridView_List.Visible = true;
            this.dataGridView_List.Dock = DockStyle.Fill;

            this.dataGridView_List.AutoGenerateColumns = false;
            this.dataGridView_List.DataSource = m_StrategyTradeList;

            this.radioButton_moneyCal.Checked = true;
            this.radioButton_pointCal.Checked = false;
            this.textBox_initQuality.Text = "0.00";
        }

        public void Cal()
        {
            if (m_StrategyList.Count > 0) m_StrategyList.Clear();

            Dictionary<string, TradeStrategyInfo> strategyList = StrategyInfo.StrategyInfoDic;
            foreach (KeyValuePair<string, TradeStrategyInfo> kv in strategyList)
            {
                TradeStrategyInfo info = new TradeStrategyInfo()
                {
                    StrategyPathName = kv.Key,
                    StrategyCommisionSet = kv.Value.StrategyCommisionSet,
                    StrategyTradeInfoList = kv.Value.StrategyTradeInfoList,
                    StrategyOpenShares = kv.Value.StrategyOpenShares
                };

                m_StrategyList.Add(info);
            }
        }

        /// <summary>
        /// 点击然后在RichBox中显示所有该Strategy的交易TradeList概览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView_List.Rows.Clear();

            List<StandardTradingInfo> infoList = (this.dataGridView_StrategyList.SelectedRows[0].DataBoundItem as TradeStrategyInfo).StrategyTradeInfoList;
            if (infoList != null && infoList.Count > 0)
            {
                foreach (StandardTradingInfo s in infoList)
                {
                    m_StrategyTradeList.Add(s);
                }
            }
        }

        /// <summary>
        /// 组合计算-画线条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCal_Click(object sender, EventArgs e)
        {
            //获取所有策略名-列表的Dic
            Dictionary<string, TradeStrategyInfo> strategyList = StrategyInfo.StrategyInfoDic;

            this.chart1.Series.Clear();

            Dictionary<string, List<double>> calSrategyAddRenkoAndCommisoinQualitySeriesResultDic = new Dictionary<string, List<double>>();

            //加砖加手续费的资金计算-多少个策略产生多少条线
            foreach (KeyValuePair<string, TradeStrategyInfo> kv in strategyList)
            {
                string pathName = kv.Key;
                List<StandardTradingInfo> tradeList = kv.Value.StrategyTradeInfoList;

                List<double> calResult = new List<double>();

                System.Windows.Forms.DataVisualization.Charting.Series seriesStrategy = new System.Windows.Forms.DataVisualization.Charting.Series();
                seriesStrategy.ChartArea = "ChartArea1";
                seriesStrategy.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                seriesStrategy.Legend = "Legend1";
                seriesStrategy.Name = pathName;
                this.chart1.Series.Add(seriesStrategy);

                double addRenkoAddCommisonQualitySeries = 0.00;
                double.TryParse(this.textBox_initQuality.Text, out addRenkoAddCommisonQualitySeries);

                for (int i = 0; i < tradeList.Count; i++)
                {
                    double openshares = 0.00;
                    double.TryParse(kv.Value.StrategyOpenShares, out openshares);
                    double commision = 0.00;
                    double.TryParse(kv.Value.StrategyCommisionSet, out commision);
                    addRenkoAddCommisonQualitySeries = addRenkoAddCommisonQualitySeries + (tradeList[i].LastCloseProfit - commision - tradeList[i].RenkoCommision*2) * tradeList[i].BigPointValue;
                    double quality = addRenkoAddCommisonQualitySeries * openshares;
                    this.chart1.Series[pathName].Points.AddXY(i, quality);

                    calResult.Add(quality);
                }

                calSrategyAddRenkoAndCommisoinQualitySeriesResultDic.Add(pathName, calResult);
            }

            //生成最后一条总的策略汇总交易资金曲线-calSrategyAddRenkoAndCommisoinQualitySeriesResultDic包含了每条资金曲线的算上砖和手续费的最终资金情况，现在合成
            System.Windows.Forms.DataVisualization.Charting.Series seriesStrategyAll = new System.Windows.Forms.DataVisualization.Charting.Series();
            seriesStrategyAll.ChartArea = "ChartArea1";
            seriesStrategyAll.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            seriesStrategyAll.Legend = "Legend1";
            seriesStrategyAll.Name = "投资组合资金曲线";
            this.chart1.Series.Add(seriesStrategyAll);

            int maxListCout = 0;
            //选出多个策略资金List里面最大的开始遍历
            foreach (KeyValuePair<string, List<double>> strResultKv in calSrategyAddRenkoAndCommisoinQualitySeriesResultDic)
            {
                if (strResultKv.Value.Count >= maxListCout)
                {
                    maxListCout = strResultKv.Value.Count;
                }
            }

            //三个list全部按照最大的List-Count进行补齐，后面却的全部补为最后一个值(因为后面没有交易，资金一直维持)
            foreach (KeyValuePair<string, List<double>> strResultKv in calSrategyAddRenkoAndCommisoinQualitySeriesResultDic)
            {
                string pathName = strResultKv.Key;
                List<double> qualityResultList = strResultKv.Value;
                //每一个补齐maxlistcout
                while(qualityResultList.Count< maxListCout)
                {
                    qualityResultList.Add(qualityResultList[qualityResultList.Count -1]);
                }
            }

            //所有补位全部完成，所有的策略的交易笔数合成的资金一致，总的每次加上每个的
            List<double> folioQualityList = new List<double>();
            for (int i = 0;i<maxListCout;i++)
            {
                double initAllQualitySeries = 0.00;
                double.TryParse(this.textBox_initQuality.Text, out initAllQualitySeries);

                foreach (KeyValuePair<string,List<double>> kv in calSrategyAddRenkoAndCommisoinQualitySeriesResultDic)
                {
                    string pathName = kv.Key;
                    List<double> qualityList = kv.Value;

                    initAllQualitySeries = initAllQualitySeries + qualityList[i];
                }

                this.chart1.Series["投资组合资金曲线"].Points.AddXY(i, initAllQualitySeries);
                folioQualityList.Add(initAllQualitySeries);

            }

            //计算最大回撤组合
            double HighestQuality = 0.00;
            for(int i = 0;i<folioQualityList.Count;i++)
            {
                double qualityValue = folioQualityList[i];
                if (qualityValue >= HighestQuality)
                {
                    HighestQuality = qualityValue;
                    this.chart2.Series[0].Points.AddXY(i, 0);
                }
                else
                {
                    if (HighestQuality != 0.00)
                    {
                        double perDrowBack = (HighestQuality - qualityValue) / HighestQuality;
                        this.chart2.Series[0].Points.AddXY(i, perDrowBack);
                    }
                }
            }
        }

        private void CheckRadioPoint_Click(object sender, EventArgs e)
        {
            if (radioButton_pointCal.Checked)
                MessageBox.Show("所有策略按照盈利亏损多少点位简单相加得到资金曲线，并没有加入合约规模的概念，谨慎使用!");
        }

    }
}
