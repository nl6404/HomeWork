using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace HW_Loan
{
    public partial class Loan : Form
    {
        private decimal count;
        private int year;
        private decimal rate;
        private decimal payment;

        private decimal pmtInteger;   //月付款
        private decimal allpay;       //總付款

        public Loan()
        {
            InitializeComponent();
        }            

        private void CalculateLoan()
        {
            count = decimal.Parse(txtCount.Text);
            year = int.Parse(txtYear.Text);
            rate = decimal.Parse(txtInterestRate.Text);
            payment = decimal.Parse(txtDownPayment.Text);

            //公比
            decimal r = 1 + rate / 12 / 100;
            //期數
            decimal n = year * 12;
            //r的n次方
            decimal rpn = (decimal)Math.Pow((double)r, (double)n);
            //月付款金額
            decimal pmt = ((count - payment) * rpn * (r - 1)) / (rpn - 1);
            pmtInteger = (int)pmt;
            //總付款          
            allpay = pmtInteger * (year * 12);
        }               

        private void btnPMT_Click(object sender, EventArgs e)
        {
            CalculateLoan();
            MessageBox.Show("月付額 : " + pmtInteger + "元");
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            CalculateLoan();
            MessageBox.Show("總付款 : " + allpay + "元");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            CalculateLoan();
            Report frm = new Report(count, year, rate, pmtInteger, allpay);
            frm.Show();
        }
    }
}
