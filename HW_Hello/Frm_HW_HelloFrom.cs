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

namespace HW_Hello
{
    public partial class Frm_HW_HelloFrom : Form
    {
        public Frm_HW_HelloFrom()
        {
            InitializeComponent();
        }

        void SayGreeting(string greeting)
        {
            string name = txt_Name.Text;
            string englishname = txt_EnglishName.Text;
            string sex = txt_Sex.Text;
            string sign = txt_Sign.Text;

            MessageBox.Show($"{greeting},我是{name}," +
                            $"\n英文名字是{englishname}," +
                            $"\n性別是{sex}," +
                            $"\n星座是{sign}," +
                            $"\n很高興認識你。");
                            
        }

        private void btn_SayHello_Click(object sender, EventArgs e)
        {
            SayGreeting("Hello");
        }

        private void btn_SayHi_Click(object sender, EventArgs e)
        {
            SayGreeting("Hi");
        }
        
    }
}
