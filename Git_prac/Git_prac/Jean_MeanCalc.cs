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
        public Jean_MeanCalc()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            inVal = Convert.ToInt32(txtnr.Text);
           
            mean.Rand(inVal);
            lblRands.Text = mean.nrhold;

        }

        private void btnMean_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(mean.mean((inVal))));
        }
    }
}
