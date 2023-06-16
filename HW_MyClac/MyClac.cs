using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_MyClac
{
    public partial class MyClac : Form
    {
        public MyClac()
        {
            InitializeComponent();
        }        
       
        void Calculate(Func<double, double, double> operation)
        {
            double num1, num2;
            bool isValidNumber1 = double.TryParse(txtNum1.Text, out num1);
            bool isValidNumber2 = double.TryParse(txtNum2.Text, out num2);

            if (isValidNumber1 && isValidNumber2)
            {
                double result= operation(num1, num2);
                string resultString;
                if (Math.Truncate(result) == result)
                {
                    // 結果為整數
                    resultString = result.ToString("0");
                }
                else
                {
                    // 結果為浮點數
                    resultString = result.ToString("0.000");
                }

                labAnswer.Text = resultString;
            }
            else
                MessageBox.Show("請輸入數值。");
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Calculate((num1, num2) => num1 + num2);
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            Calculate((num1, num2) => num1 - num2);
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            Calculate((num1, num2) => num1 * num2);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Calculate((num1, num2) => Math.Round(num1 / num2, 4));            
        }
    }
}
