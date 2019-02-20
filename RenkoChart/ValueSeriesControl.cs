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
    public partial class ValueSeriesControl : UserControl
    {
        private string m_pathName = string.Empty;
        private List<ValueStandardTradingInfo> m_result = new List<ValueStandardTradingInfo>();

        public ValueSeriesControl()
        {
            InitializeComponent();
        }

        private void ClearAndDefult()
        {
            this.textBox_LossCommision.Text = "进出一次手续费需要几跳才能覆盖...";
            this.textBox_LossHuaDian.Text = "进出一次滑点需要几跳才能覆盖...";
            this.textBox_MinMove1.Text = "0";
            this.textBox_MinMove2.Text = "0";

            this.textBox_ResultPointCommision.Text = "0";
            this.textBox_ResultHuaDian.Text = "0";
            this.textBox_AllCommision.Text = "0";
            this.textBox_BigpointValue.Text = "0";
            this.textBox_AllOutMoney.Text = "0";

            this.textBox_Symbol.Text = "";
            this.textBox_allTradeCout.Text = "";
            this.textBox_DateTimeSpanStart.Text = "";
            this.textBox_FutuRenkoHeight.Text = "";

            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
        }

        public void SetData(List<ValueStandardTradingInfo> infoResut, string pathName)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<List<ValueStandardTradingInfo>, string>(SetData), infoResut, pathName);
                return;
            }

            m_result = infoResut;

            //先清空所有的之前的数据
            ClearAndDefult();

            m_pathName = pathName;

            //添加回测的数据汇总和MC对照
            if (m_result.Count > 0)
            {
                this.textBox_MinMove1.Text = m_result[0].MinMovePriceScole.ToString();
                this.textBox_MinMove2.Text = m_result[0].MinMovePriceScole.ToString();
                this.textBox_BigpointValue.Text = m_result[0].BigPointValue.ToString();
                this.textBox_Symbol.Text = m_result[0].Symbol.ToString();
                this.textBox_allTradeCout.Text = m_result[m_result.Count - 1].TradeNum.ToString();
                this.textBox_DateTimeSpanStart.Text = m_result[0].Date + m_result[0].Time;
                this.textBox_DateTimeSpanEnd.Text = m_result[m_result.Count - 1].Date + m_result[m_result.Count - 1].Time;
                this.textBox_FutuRenkoHeight.Text = m_result[0].Data2RenkoHigh.ToString();
            }
        }

        private void button_Cal_Click(object sender, EventArgs e)
        {
            if(textBox_AllCommision.Text == "" || textBox_AllCommision.Text == "0")
            {
                MessageBox.Show("请输入一进出的手续费和滑点跳数...");
                return;
            }

            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();

            //无手续费无滑点的资金曲线
            for(int i = 0;i<m_result.Count;i++)
            {
                this.chart1.Series[0].Points.AddXY(i, m_result[i].NoCommisionSlipiseAccountSeries);
            }

            //加上了手续费和滑点的资金曲线
            for (int i = 0; i < m_result.Count; i++)
            {
                this.chart1.Series[1].Points.AddXY(i, m_result[i].NoCommisionSlipiseAccountSeries - TransStringtoDouble(textBox_AllOutMoney.Text)*i);
            }
        }

        private void CommisionTextChanged(object sender, EventArgs e)
        {
            textBox_ResultPointCommision.Text = (TransStringtoDouble(textBox_LossCommision.Text) * TransStringtoDouble(textBox_MinMove1.Text)).ToString();
            textBox_ResultHuaDian.Text = (TransStringtoDouble(textBox_LossHuaDian.Text) * TransStringtoDouble(textBox_MinMove2.Text)).ToString();
            textBox_AllCommision.Text = (TransStringtoDouble(textBox_ResultPointCommision.Text) + TransStringtoDouble(textBox_ResultHuaDian.Text)).ToString();
            textBox_AllOutMoney.Text = (TransStringtoDouble(textBox_AllCommision.Text) * TransStringtoDouble(textBox_BigpointValue.Text)).ToString();
            textBox_VComminso.Text = (TransStringtoDouble(textBox_allTradeCout.Text) * TransStringtoDouble(textBox_AllOutMoney.Text)).ToString();
        }

        private void SlipileTextChanged(object sender, EventArgs e)
        {
            textBox_ResultPointCommision.Text = (TransStringtoDouble(textBox_LossCommision.Text) * TransStringtoDouble(textBox_MinMove1.Text)).ToString();
            textBox_ResultHuaDian.Text = (TransStringtoDouble(textBox_LossHuaDian.Text) * TransStringtoDouble(textBox_MinMove2.Text)).ToString();
            textBox_AllCommision.Text = (TransStringtoDouble(textBox_ResultPointCommision.Text) + TransStringtoDouble(textBox_ResultHuaDian.Text)).ToString();
            textBox_AllOutMoney.Text = (TransStringtoDouble(textBox_AllCommision.Text) * TransStringtoDouble(textBox_BigpointValue.Text)).ToString();
            textBox_VComminso.Text = (TransStringtoDouble(textBox_allTradeCout.Text) * TransStringtoDouble(textBox_AllOutMoney.Text)).ToString();

        }

        private double TransStringtoDouble(string textInfo)
        {
            double d = 0.00;
            double.TryParse(textInfo, out d);
            return d;
        }
    }
}
