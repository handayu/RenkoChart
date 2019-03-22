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
    public partial class FormSpilise : Form
    {
        private BindingList<SlipileInfo> m_SList = new BindingList<SlipileInfo>();

        public FormSpilise()
        {
            InitializeComponent();
            this.dataGridView_StrategyList.Visible = true;
            this.dataGridView_StrategyList.AutoGenerateColumns = false;
            this.dataGridView_StrategyList.DataSource = m_SList;

            this.Load += FormSpilise_Load;
        }

        private void FormSpilise_Load(object sender, EventArgs e)
        {
            List<string> sList = ReadTxt(@"C:\Users\Administrator\Desktop\RenkoChart\ni实盘滑点计数器\RealTrading-Slipise.txt");
            List<SlipileInfo> slipList = TransToStandardInfoList(sList);
            
            foreach(SlipileInfo s in slipList)
            {
                m_SList.Add(s);
            }
        }

        public  List<string> ReadTxt(string path)
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
        public  List<SlipileInfo> TransToStandardInfoList(List<string> allTradingList)
        {
            List<string> tradeList = new List<string>();

            List<string> allTradingCloneList = new List<string>();
            foreach (string s in allTradingList)
            {
                allTradingCloneList.Add(s);
            }

            List<SlipileInfo> standardTradingList = new List<SlipileInfo>();

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

                SlipileInfo standardTradeInfo = new SlipileInfo();
                standardTradeInfo.Date = newStrArray[0];
                standardTradeInfo.Time = newStrArray[1];
                standardTradeInfo.MP = StrCovertDouble(newStrArray[2].Trim(' '));
                standardTradeInfo.TradeNum = StrCovertInt(newStrArray[4]);
                standardTradeInfo.ChartEntryPrice = StrCovertDouble(newStrArray[3]);
                standardTradeInfo.RealEntryPrice = StrCovertDouble(newStrArray[5]);
                
                if(standardTradeInfo.MP == 1)
                {
                    standardTradeInfo.S = standardTradeInfo.RealEntryPrice - standardTradeInfo.ChartEntryPrice;
                    standardTradeInfo.DoubleS = 2*(standardTradeInfo.S);
                    standardTradeInfo.IsAvg = true;
                }
                if (standardTradeInfo.MP == -1)
                {
                    standardTradeInfo.S = standardTradeInfo.ChartEntryPrice - standardTradeInfo.RealEntryPrice;
                    standardTradeInfo.DoubleS = 2 * (standardTradeInfo.S);
                    standardTradeInfo.IsAvg = true;
                }

                standardTradingList.Add(standardTradeInfo);
            }

            return standardTradingList;
        }

        private double StrCovertDouble(string s)
        {
            double d = 0.00;
            double.TryParse(s, out d);
            return d;
        }

        private int StrCovertInt(string s)
        {
            int d = int.MinValue;
            int.TryParse(s, out d);
            return d;
        }

        private void Button_CalClick(object sender, EventArgs e)
        {
            List<double> dList = new List<double>();

            foreach (SlipileInfo s in m_SList)
            {
                if (s.IsAvg)
                {
                    dList.Add(s.S);
                }
            }

            this.label_S.Text = Enumerable.Average(dList).ToString();
        }
    }


    public class SlipileInfo : BaseViewModel
    {
        private string m_date = "";
        private string m_time = "";
        private double m_mp = 0;
        private int m_tradeNum = 0;
        private double m_chartEntryPrice = 0;
        private double m_realEntryPrice = 0;
        private double m_S = 0;
        private double m_doubleS = 0;
        private bool m_isAvg = true;

        public string Date
        {
            get { return m_date; }
            set
            {
                m_date = value;
                SetProperty(() => this.Date);
            }
        }

        public string Time
        {
            get { return m_time; }
             set
            {
                m_time = value;
                SetProperty(() => this.Time);
            }
        }
        public double MP
        {
            get { return m_mp; }
             set
            {
                m_mp = value;
                SetProperty(() => this.MP);
            }
        }

        public int TradeNum
        {
            get { return m_tradeNum; }
             set
            {
                m_tradeNum = value;
                SetProperty(() => this.TradeNum);
            }
        }

        public double ChartEntryPrice
        {
            get { return m_chartEntryPrice; }
             set
            {
                m_chartEntryPrice = value;
                SetProperty(() => this.ChartEntryPrice);
            }
        }

        public double RealEntryPrice
        {
            get { return m_realEntryPrice; }
             set
            {
                m_realEntryPrice = value;
                SetProperty(() => this.RealEntryPrice);
            }
        }

        public double S
        {
            get { return m_S; }
             set
            {
                m_S = value;
                SetProperty(() => this.S);
            }
        }

        public double DoubleS
        {
            get { return m_doubleS; }
             set
            {
                m_doubleS = value;
                SetProperty(() => this.DoubleS);
            }
        }

        public bool IsAvg
        {
            get { return m_isAvg; }
             set
            {
                m_isAvg = value;
                SetProperty(() => this.IsAvg);
            }
        }
    }

}
