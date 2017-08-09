using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git_prac
{
    public partial class Jean_MeanCalc : Form
    {
        Mean mean = new Mean();
        int inVal = 0;
        Testnr test = new Testnr();
        public Jean_MeanCalc()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            
            inVal = Convert.ToInt32(txtnr.Text);
            if (test.test(inVal)) {
                mean.Rand(inVal);
                lblRands.Text = mean.nrhold;
            }
            else {
                MessageBox.Show("please insert valid nr");
                txtnr.Clear();
                txtnr.Focus();
            }

        }

        private void btnMean_Click(object sender, EventArgs e)
        {
            if (test.test(inVal))
                MessageBox.Show(Convert.ToString(mean.mean((inVal))));
            else {
                MessageBox.Show("please insert valid nr");
                txtnr.Clear();
                txtnr.Focus();
            }

        }
    }
}
