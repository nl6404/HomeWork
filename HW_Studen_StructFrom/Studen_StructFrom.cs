using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace HW_Studen_StructFrom
{
    public partial class Studen_StructFrom : Form
    {
        public Studen_StructFrom()
        {
            InitializeComponent();
        }
              
        private struct Student
        {
            public string Name { get; set; }
            public int Chi { get; set; }
            public int Eng { get; set; }
            public int Math { get; set; }

            public Student(string StudentName, int StudentChi, int StudentEng, int StudentMath)
            {
                Name = StudentName;
                Chi = StudentChi;
                Eng = StudentEng;
                Math = StudentMath;
            }


        }

        String StudentResult ;
        private Student stu; // 將 stu 定義為成員變數

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            int Chi = 0;
            int Eng = 0;
            int Math = 0;
            bool isNum = int.TryParse(txtChi.Text, out Chi)
                      && int.TryParse(txtEng.Text, out Eng)
                      && int.TryParse(txtMath.Text, out Math);


            if (!(txtName.Text == ""))
            {
                string name = txtName.Text;
            }
            else
            {
                MessageBox.Show("尚未輸入姓名!");
                return;
            }


            if (isNum)
            {
                stu = new Student(txtName.Text,
                        int.Parse(txtChi.Text), 
                        int.Parse(txtEng.Text),
                        int.Parse(txtMath.Text));
               
                StudentResult = $"姓名:{stu.Name}" +
                            $"\r\n國文:{stu.Chi}分" +
                            $"\r\n英文:{stu.Eng}分" +
                            $"\r\n數學:{stu.Math}分";

            }
            else
            {
                MessageBox.Show("成績輸入數值有誤");                
                txtName.Clear();
                txtChi.Clear();
                txtEng.Clear();
                txtMath.Clear();
                txtName.Focus();
            }
        }

        private void btnShowSave_Click(object sender, EventArgs e)
        {
            labShowScores.Text = StudentResult;
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            int maxScore = Math.Max(stu.Chi, Math.Max(stu.Eng, stu.Math));
            int minScore = Math.Min(stu.Chi, Math.Min(stu.Eng, stu.Math));

            string maxSubject = "";
            string minSubject = "";

            if (maxScore == stu.Chi)
                maxSubject = "國文";
            else if (maxScore == stu.Eng)
                maxSubject = "英文";
            else if (maxScore == stu.Math)
                maxSubject = "數學";

            if (minScore == stu.Chi)
                minSubject = "國文";
            else if (minScore == stu.Eng)
                minSubject = "英文";
            else if (minScore == stu.Math)
                minSubject = "數學";

            labMaxMin.Text = $"最高科目成績為 : {maxSubject}{maxScore}分" +
                         $"\r\n最低科目成績為 : {minSubject}{minScore}分";            
        }
    }
}
