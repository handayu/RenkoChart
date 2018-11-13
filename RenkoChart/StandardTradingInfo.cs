using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenkoChart
{
    /// <summary>
    /// 给定txt输出MCTXT后的标准类成交信息
    /// </summary>
    public class StandardTradingInfo
    {
        public string Symbol
        {
            set;
            get;
        }
        public string BarNum
        {
            set;
            get;
        }
        public double IsUpDownBar
        {
            set;
            get;
        }
        public double MarketPosition
        {
            set;
            get;
        }
        public double LastCloseProfit
        {
            set;
            get;
        }
        public double BigPointValue
        {
            set;
            get;
        }
        public double RenkoHight
        {
            set;
            get;
        }
        public double CommisionValue
        {
            set;
            get;
        }
        public double RenkoCommision
        {
            set;
            get;
        }
    }

    public static class HandelTxtToStadardTradingInfo
    {
        public static List<StandardTradingInfo> HandelStandardTradingInfoList(string txtInfo)
        {
            List<StandardTradingInfo> standardTradingList = new List<StandardTradingInfo>();

            List<string> orgInfo = ReadTxt(txtInfo);
            standardTradingList = TransToStandardInfoList(orgInfo);

            CalNeedRenkoChartQualitySeries(standardTradingList);

            return standardTradingList;
        }

        //读取所有交易信息
        public static List<string> ReadTxt(string path)
        {
            List<string> tSingleInfo = new List<string>();

            //设置文件共享方式为读写，FileShare.ReadWrite，这样的话，就可以打开了
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                tSingleInfo.Add(line.ToString());
            }

            return tSingleInfo;
        }

        /// <summary>
        /// 把读取的所有信息先转化成标准平台类格式
        /// </summary>
        /// <param name="tradingList"></param>
        /// <returns></returns>
        public static List<StandardTradingInfo> TransToStandardInfoList(List<string> allTradingList)
        {
            List<string> tradeList = new List<string>();

            List<string> allTradingCloneList = new List<string>();
            foreach (string s in allTradingList)
            {
                allTradingCloneList.Add(s);
            }

            List<StandardTradingInfo> standardTradingList = new List<StandardTradingInfo>();

            for (int i = 0; i < allTradingCloneList.Count; i++)
            {
                List<string> strArray = allTradingCloneList[i].Split('_').ToList();
                List<string> newStrArray = new List<string>();
                foreach (string s in strArray)
                {
                    if (s.CompareTo("") != 0)
                    {
                        newStrArray.Add(s);
                    }
                }

                StandardTradingInfo standardTradeInfo = new StandardTradingInfo();
                standardTradeInfo.Symbol = newStrArray[0];

                standardTradeInfo.BarNum = newStrArray[1];

                double iSUpDownBar = double.MinValue;
                double.TryParse(newStrArray[2].Trim(' '), out iSUpDownBar);
                standardTradeInfo.IsUpDownBar = iSUpDownBar;

                double marketPosition = double.MinValue;
                double.TryParse(newStrArray[3].Trim(' '), out marketPosition);
                standardTradeInfo.MarketPosition = marketPosition;

                double profit = double.MinValue;
                double.TryParse(newStrArray[4].Trim(' '), out profit);
                standardTradeInfo.LastCloseProfit = profit;

                double bigpointValue = double.MinValue;
                double.TryParse(newStrArray[5].Trim(' '), out bigpointValue);
                standardTradeInfo.BigPointValue = bigpointValue;

                double renkoHight = double.MinValue;
                double.TryParse(newStrArray[6].Trim(' '), out renkoHight);
                standardTradeInfo.RenkoHight = renkoHight;

                standardTradeInfo.CommisionValue = 0.00;
                standardTradeInfo.RenkoCommision = 0.00;

                standardTradingList.Add(standardTradeInfo);
            }

            return standardTradingList;
        }

        /// <summary>
        /// 找出每一笔未加入砖块成本的交易盈亏笔
        /// </summary>
        /// <param name="tradingList"></param>
        /// <returns></returns>
        public static List<StandardTradingInfo> CalNonNeedRenkoChartQualitySeries(List<StandardTradingInfo> allMultichartsList)
        {
            List<StandardTradingInfo> tradeList = new List<StandardTradingInfo>();

            for (int i = 0; i < allMultichartsList.Count; i++)
            {
                if (i >= 1)
                {
                    string nowBarNum = allMultichartsList[i].BarNum;
                    double nowBarOpenClose = allMultichartsList[i].IsUpDownBar;
                    double nowBarMp = allMultichartsList[i].MarketPosition;

                    string preBarNum = allMultichartsList[i - 1].BarNum;
                    double preBarOpenClose = allMultichartsList[i - 1].IsUpDownBar;
                    double preBarMp = allMultichartsList[i - 1].MarketPosition;

                    if (nowBarMp != preBarMp)
                    {
                        tradeList.Add(allMultichartsList[i]);
                    }
                }
            }
            return tradeList;
        }

        /// <summary>
        /// 找到需要砖成本的，重新修改原来所有笔的交易属性(砖属性)
        /// </summary>
        /// <param name="allTradingList"></param>
        /// <returns></returns>
        public static List<StandardTradingInfo> CalNeedRenkoChartQualitySeries(List<StandardTradingInfo> noNeedRenkoChartList)
        {
            for (int i = 0; i < noNeedRenkoChartList.Count; i++)
            {
                string nowBarNum = noNeedRenkoChartList[i].BarNum;
                double nowBarOpenClose = noNeedRenkoChartList[i].IsUpDownBar;
                double nowBarMp = noNeedRenkoChartList[i].MarketPosition;

                if (nowBarMp != nowBarOpenClose)
                {
                    noNeedRenkoChartList[i].RenkoCommision = 0 - noNeedRenkoChartList[i].RenkoHight;
                }
            }
            return noNeedRenkoChartList;
        }
    }

    /// <summary>
    /// 整个策略设置信息
    /// </summary>
    public class TradeStrategyInfo
    {
        public List<StandardTradingInfo> StrategyTradeInfoList
        {
            set;
            get;
        }

        public string StrategyPathName
        {
            set;
            get;
        }

        public string StrategyCommisionSet
        {
            set;
            get;
        }

        public string StrategyMonetSet
        {
            set;
            get;
        }

        public string StrategyOpenShares
        {
            set;
            get;
        }
    }

    public static class StrategyInfo
    {
        private static Dictionary<string, TradeStrategyInfo> m_StratgyInfoDic = new Dictionary<string, TradeStrategyInfo>();

        public static void AddStratgyInfo(string pathName,TradeStrategyInfo strategyInfo)
        {
            if(m_StratgyInfoDic.ContainsKey(pathName))
            {
                m_StratgyInfoDic.Remove(pathName);
            }

            m_StratgyInfoDic.Add(pathName, strategyInfo);
        }

        public static Dictionary<string, TradeStrategyInfo> StrategyInfoDic
        {
            get
            {
                return m_StratgyInfoDic;
            }
        }

    }
}
