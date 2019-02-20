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
    public partial class AddValueSeriesStrategyTextPathForm : Form
    {
        public AddValueSeriesStrategyTextPathForm()
        {
            InitializeComponent();

            this.textBox_Path.Text = @"C:\Users\Administrator\Desktop\1.txt";
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            IResult = this.textBox_Path.Text;
            this.Close();
        }

        public string IResult
        {
            set;
            get;
        }
    }
}
