using HW_Alarm;
using HW_ForDoWhile;
using HW_Guess;
using HW_Hello;
using HW_Loan;
using HW_MyClac;
using HW_Notepad;
using HW_PictureViwer;
using HW_POS;
using HW_ScreenSaver;
using HW_Studen_StructFrom;
using HW_小畫家;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XOGame;

namespace HW_HomePage
{
    public partial class HomePage : Form
    {
        private Form currentForm; // 儲存目前打開的表單
        private Panel panelShow;

        public HomePage()
        {
            InitializeComponent();
            panelShow = splitContainer2.Panel2;
            // 設定表單初始狀態為最大化
            this.WindowState = FormWindowState.Maximized;
        }

        private void OpenForm(Form form)
        {
            if (currentForm != null)
            {
                // 關閉先前的表單
                currentForm.Close();
                currentForm.Dispose();
            }

            // 設定新的表單
            currentForm = form;
            currentForm.TopLevel = false;// 設定為非頂層表單
            currentForm.FormBorderStyle = FormBorderStyle.Sizable;// 設定有邊框
            currentForm.AutoSize = false; // 可調整視窗大小
            panelShow.Controls.Add(currentForm); //將Form 加入 panelHello 的控制項集合
            currentForm.Show();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            Frm_HW_HelloFrom Form = new Frm_HW_HelloFrom();
            OpenForm(Form);
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            Loan Form = new Loan();
            OpenForm(Form);
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            POS Form = new POS();
            OpenForm(Form);
        }

        private void btnStudent_StructForm_Click(object sender, EventArgs e)
        {
            Studen_StructFrom Form = new Studen_StructFrom();
            OpenForm(Form);
        }

        private void btnMyClac_Click(object sender, EventArgs e)
        {
            MyClac Form = new MyClac();
            OpenForm(Form);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Guess Form = new Guess();
            OpenForm(Form);
        }

        private void btnStudentGrade_Click(object sender, EventArgs e)
        {
            StudentsGrade.StudentsGrade Form = new StudentsGrade.StudentsGrade();
            OpenForm(Form);
        }

        private void btnXOGame_Click(object sender, EventArgs e)
        {
            XOGame.XOGame Form = new XOGame.XOGame();
            OpenForm(Form);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            小畫家 Form = new 小畫家();
            OpenForm(Form);
        }

        private void btnForDoWhile_Click(object sender, EventArgs e)
        {
            ForDoWhile Form = new ForDoWhile();
            OpenForm(Form);
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            Alarm Form = new Alarm();
            OpenForm(Form);
        }

        private void btnPictureViewer_Click(object sender, EventArgs e)
        {
            PictureViwer Form = new PictureViwer();
            OpenForm(Form);
        }

        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            ScreenSaver Form = new ScreenSaver();
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }
            Form.Show();
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            Notepad Form = new Notepad();
            OpenForm(Form);
        }
    }
}