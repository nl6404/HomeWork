using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Loan
{
    public partial class Report : Form
    {
        public Report(decimal count, int year, decimal rate, decimal pmtInteger, decimal allpay)
        {
            InitializeComponent();

            labAnsCount.Text = count.ToString();
            labAnsYear.Text = year.ToString();
            labAnsRate.Text = rate.ToString();
            labAnsMonth.Text = pmtInteger.ToString();
            labAnsAll.Text = allpay.ToString();
        }

    }
}
