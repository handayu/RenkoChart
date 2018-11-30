using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace RenkoChart
{
    public partial class TimeSeriesRenkoQualityFolioControl : UserControl
    {
        private BindingList<TradeInfo> m_MCEditTradeList = new BindingList<TradeInfo>();
        private BindingList<TradeInfo> m_HandleTimeSeriesTradeList = new BindingList<TradeInfo>();
        private Dictionary<string, List<TradeInfo>> m_StategyNameTradeDic = new Dictionary<string, List<TradeInfo>>();
        private Dictionary<string, List<TradeInfo>> m_StategyNameOrgionTradeDic = new Dictionary<string, List<TradeInfo>>();

        public TimeSeriesRenkoQualityFolioControl()
        {
            InitializeComponent();

            this.dataGridView_MCEditTradeList.Visible = true;
            this.dataGridView_MCEditTradeList.Dock = DockStyle.Fill;

            this.dataGridView_MCEditTradeList.AutoGenerateColumns = false;
            this.dataGridView_MCEditTradeList.DataSource = m_MCEditTradeList;

            this.dataGridView_HandleAfter.Visible = true;
            this.dataGridView_HandleAfter.Dock = DockStyle.Fill;

            this.dataGridView_HandleAfter.AutoGenerateColumns = false;
            this.dataGridView_HandleAfter.DataSource = m_HandleTimeSeriesTradeList;

        }

        public class TradeInfo
        {
            public string Symbol
            {
                set;
                get;
            }

            public DateTime DateInfo
            {
                set;
                get;
            }

            public string TimeInfo
            {
                set;
                get;
            }

            public double Quality
            {
                set;
                get;
            }

            public double Positionprofit
            {
                set;
                get;
            }
        }

        /// <summary>
        /// 读取txt从MC拉下来的所有交易数据时间序列列表
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private List<string> RedTxt(string path)
        {
            List<string> tradeList = new List<string>();

            //设置文件共享方式为读写，FileShare.ReadWrite，这样的话，就可以打开了
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                tradeList.Add(line.ToString());
            }
            return tradeList;
        }

        private List<TradeInfo> HandleMCTradeInfoList(List<string> strInfo)
        {
            List<TradeInfo> tradeInfoList = new List<TradeInfo>();
            foreach (string str in strInfo)
            {
                string[] strArray = str.Split('_');

                TradeInfo info = new TradeInfo();
                info.Symbol = strArray[0];

                double date = 0;
                double.TryParse(strArray[1], out date);
                date = date + 19000000;
                DateTime dtime = DateTime.ParseExact(date.ToString(), "yyyyMMdd", null);
                info.DateInfo = dtime;

                info.TimeInfo = strArray[2];
                double quality = 0.00;
                double.TryParse(strArray[3], out quality);
                info.Quality = quality;

                double profit = 0.00;
                double.TryParse(strArray[4], out profit);
                info.Positionprofit = profit;

                tradeInfoList.Add(info);
            }
            return tradeInfoList;
        }

        private List<TradeInfo> HandleTimeSeriesTradeInfoList(List<TradeInfo> tradeList)
        {
            //获取TradeInfo每天最后一条记录代表该策略当天的收益最终资金，然后把其他空缺的日期按照前一笔进行补齐
            //形成最终的以时间为TimeSeries的资金曲线，横坐标为整日日期，而不再是按笔的资金曲线，然后整合成组合
            List<TradeInfo> timeSeriesTradeList = new List<TradeInfo>();
            for (int i = 0; i < tradeList.Count; i++)
            {
                if (i > 0 && tradeList[i].DateInfo != tradeList[i - 1].DateInfo)
                {
                    timeSeriesTradeList.Add(tradeList[i - 1]);
                }
            }

            //以上找出了当天最后一笔交易完之后的资金，接下来，把空缺的交易日的资金按照前一天的进行补齐操作
            DateTime dateTimeStart = timeSeriesTradeList[0].DateInfo;
            DateTime dateTimeEnd = timeSeriesTradeList[timeSeriesTradeList.Count - 1].DateInfo;

            //按交易的最初时间-最终时间拉取标准时间序列进行遍历
            for (DateTime t = dateTimeStart; t <= dateTimeEnd; t = t.AddDays(1))
            {
                //在timeseries中找是否有这个日期下的交易
                bool findT = false;
                foreach (TradeInfo trade in timeSeriesTradeList)
                {
                    if (trade.DateInfo == t)
                    {
                        findT = true;
                        break;
                    }
                }

                if (findT)
                {
                    //如果找到了这个日期下有一笔交易，什么都不作，正常
                }
                else
                {
                    //如果没找到，插入一笔进去，并且这一笔的资金应该和上一笔一样,找到这一笔的位置，和上一笔一样
                    int ifalg = 0;
                    for (int i = 0; i < timeSeriesTradeList.Count; i++)
                    {
                        if (t > timeSeriesTradeList[i].DateInfo && t < timeSeriesTradeList[i + 1].DateInfo)
                        {
                            ifalg = i;
                            TradeInfo info = new TradeInfo()
                            {
                                Symbol = timeSeriesTradeList[i].Symbol,
                                DateInfo = timeSeriesTradeList[i].DateInfo.AddDays(1),
                                TimeInfo = timeSeriesTradeList[i].TimeInfo,
                                Quality = timeSeriesTradeList[i].Quality,
                                Positionprofit = timeSeriesTradeList[i].Positionprofit
                            };

                            timeSeriesTradeList.Insert(i + 1, info);

                            break;
                        }
                    }
                }

            }

            return timeSeriesTradeList;
        }

        private void ToolStripMenuItem_AddStrategySeries_Click(object sender, EventArgs e)
        {
            try
            {
                AddStrategyTextPathForm f = new AddStrategyTextPathForm();
                f.ShowDialog();

                //添加一条Item到treeView中
                ListViewItem lvi = new ListViewItem();
                lvi.Text = f.IResult;
                this.listView1.Items.Add(lvi);

                //搜出最原始的MC数据
                string path = f.IResult;
                List<string> mcStrList = RedTxt(path);

                //清空两个表-Series-邦定Series数据源
                m_MCEditTradeList.Clear();
                m_HandleTimeSeriesTradeList.Clear();
                this.chart1.Series["时间序列资金曲线"].Points.Clear();
                List<DateTime> xBind = new List<DateTime>();
                List<double> yBind = new List<double>();

                //添加到两个表
                List<TradeInfo> mcStandardTradeList = HandleMCTradeInfoList(mcStrList);
                foreach (TradeInfo info in mcStandardTradeList)
                {
                    m_MCEditTradeList.Add(info);
                }

                List<TradeInfo> timeSeriesTradeList = HandleTimeSeriesTradeInfoList(mcStandardTradeList);

                foreach (TradeInfo info in timeSeriesTradeList)
                {
                    m_HandleTimeSeriesTradeList.Add(info);

                    xBind.Add(info.DateInfo);
                    yBind.Add(info.Quality);
                }

                this.chart1.Series[0].Points.DataBindXY(xBind, yBind);

                //保存Strategy-PathName -- List<>的Dic用于切换和组合叠加
                m_StategyNameTradeDic.Add(path, timeSeriesTradeList);
                m_StategyNameOrgionTradeDic.Add(path, mcStandardTradeList);

            }
            catch (Exception ex)
            {
                MessageBox.Show("添加失败:" + ex.Message + "请重新添加...");
            }
        }

        private void ListView_SelectChanged(object sender, EventArgs e)
        {
            string pathName = this.listView1.FocusedItem.Text;

            foreach (KeyValuePair<string, List<TradeInfo>> kv in m_StategyNameTradeDic)
            {
                if (kv.Key.CompareTo(pathName) != 0) continue;
                List<TradeInfo> seriesTradeInfoList = kv.Value;

                //清空两个表-Series-邦定Series数据源
                m_MCEditTradeList.Clear();
                m_HandleTimeSeriesTradeList.Clear();
                this.chart1.Series["时间序列资金曲线"].Points.Clear();
                List<DateTime> xBind = new List<DateTime>();
                List<double> yBind = new List<double>();

                foreach (TradeInfo info in seriesTradeInfoList)
                {
                    m_HandleTimeSeriesTradeList.Add(info);

                    xBind.Add(info.DateInfo);
                    yBind.Add(info.Quality);
                }

                this.chart1.Series[0].Points.DataBindXY(xBind, yBind);
            }
            foreach (KeyValuePair<string, List<TradeInfo>> kv in m_StategyNameOrgionTradeDic)
            {
                if (kv.Key.CompareTo(pathName) != 0) continue;
                List<TradeInfo> mcOrgionTradeInfoList = kv.Value;
                foreach (TradeInfo info in mcOrgionTradeInfoList)
                {
                    m_MCEditTradeList.Add(info);
                }
            }
        }

        /// <summary>
        /// 叠加时间序列下的投资组合
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_CalFolio_Click(object sender, EventArgs e)
        {
            //清空两个表-Series-邦定Series数据源
            m_MCEditTradeList.Clear();
            m_HandleTimeSeriesTradeList.Clear();

            //清空曲线
            this.chart1.Series["时间序列资金曲线"].Points.Clear();

            //这里遍历每一个策略的时间序列，把它们的时间序列补齐成一样，才能进行时间组合
            DateTime seriesBeginDateTime = DateTime.Now;
            DateTime seriesEndDateTime = DateTime.Now;

            int i = 0;
            foreach (KeyValuePair<string, List<TradeInfo>> kv in m_StategyNameTradeDic)
            {
                List<TradeInfo> seriesTradeList = kv.Value;

                if (i == 0)
                {
                    seriesBeginDateTime = seriesTradeList[0].DateInfo;
                    seriesEndDateTime = seriesTradeList[seriesTradeList.Count - 1].DateInfo;
                    i = 1;
                }
                else
                {
                    if (seriesTradeList[0].DateInfo <= seriesBeginDateTime)
                    {
                        seriesBeginDateTime = seriesTradeList[0].DateInfo;
                    }
                    if (seriesTradeList[seriesTradeList.Count - 1].DateInfo >= seriesEndDateTime)
                    {
                        seriesEndDateTime = seriesTradeList[seriesTradeList.Count - 1].DateInfo;
                    }
                }
            }

            //在接下来要变更里面的值，为防止影响，在这里必须克隆一个对象
            Dictionary<string, List<TradeInfo>> folioResultDic = new Dictionary<string, List<TradeInfo>>(m_StategyNameTradeDic);

            //这个相对来说简单一些，因为TradeInfo本身现在的数据已经是标准的时间序列，只需要把边界以外的全部补齐为0就可以了
            foreach (KeyValuePair<string, List<TradeInfo>> kv in folioResultDic)
            {
                List<TradeInfo> tradeSeriesList = kv.Value;

                DateTime beginTime = tradeSeriesList[0].DateInfo;
                DateTime endTime = tradeSeriesList[tradeSeriesList.Count - 1].DateInfo;

                if (seriesBeginDateTime < beginTime)
                {
                    int iInsert = 0;
                    //从begin到tradeseries的begin补齐全部-按照位置0的参数
                    for (DateTime t = seriesBeginDateTime; t < beginTime; t = t.AddDays(1))
                    {
                        TradeInfo info = new TradeInfo()
                        {
                            Symbol = tradeSeriesList[0].Symbol,
                            DateInfo = t,
                            TimeInfo = "",
                            Quality = tradeSeriesList[0].Quality,
                            Positionprofit = 0
                        };
                        tradeSeriesList.Insert(iInsert++, info);
                    }
                }

                if (seriesEndDateTime > endTime)
                {
                    int iInset = tradeSeriesList.Count - 1;
                    //从begin到tradeseries的begin补齐全部-按照位置0的参数
                    for (DateTime t = endTime.AddDays(1); t <= seriesEndDateTime; t = t.AddDays(1))
                    {
                        TradeInfo info = new TradeInfo()
                        {
                            Symbol = tradeSeriesList[0].Symbol,
                            DateInfo = t,
                            TimeInfo = "",
                            Quality = tradeSeriesList[tradeSeriesList.Count - 1].Quality,
                            Positionprofit = 0
                        };
                        tradeSeriesList.Insert(iInset++, info);
                    }
                }
            }

            //folio-TradeList时间序列对齐完毕，画线---单独的
            foreach (KeyValuePair<string, List<TradeInfo>> kv in folioResultDic)
            {
                string strategyPath = kv.Key;
                List<TradeInfo> seriesTradeList = kv.Value;

                System.Windows.Forms.DataVisualization.Charting.Series seriesStrategy = new System.Windows.Forms.DataVisualization.Charting.Series();
                seriesStrategy.ChartArea = "ChartArea1";
                seriesStrategy.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                seriesStrategy.Legend = "Legend1";
                seriesStrategy.Name = strategyPath;
                this.chart1.Series.Add(seriesStrategy);

                foreach (TradeInfo info in seriesTradeList)
                {
                    this.chart1.Series[strategyPath].Points.AddXY(info.DateInfo, info.Quality);
                }
            }

            //folio-TradeList时间序列对齐完毕，画线---总线-投资组合
            System.Windows.Forms.DataVisualization.Charting.Series seriesStrategyFolio = new System.Windows.Forms.DataVisualization.Charting.Series();
            seriesStrategyFolio.ChartArea = "ChartArea1";
            seriesStrategyFolio.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            seriesStrategyFolio.Legend = "Legend1";
            seriesStrategyFolio.Name = "投资组合";
            this.chart1.Series.Add(seriesStrategyFolio);

            int tradeCount = 0;
            foreach (KeyValuePair<string, List<TradeInfo>> kv in folioResultDic)
            {
                tradeCount = kv.Value.Count;
                break;
            }

            for(int iC = 0;iC<tradeCount;iC++)
            {
                DateTime xTime = DateTime.Now;
                double Quality = 0.00;
                foreach (KeyValuePair<string, List<TradeInfo>> kv in folioResultDic)
                {
                    List<TradeInfo> seriesTradeList = kv.Value;
                    xTime = seriesTradeList[iC].DateInfo;
                    Quality = Quality + seriesTradeList[iC].Quality;
                }

                Quality = Quality / folioResultDic.Count;
                this.chart1.Series["投资组合"].Points.AddXY(xTime, Quality);
                Debug.WriteLine(xTime.ToString() + "----" + Quality.ToString());
            }

        }
    }
}

