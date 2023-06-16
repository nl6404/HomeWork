using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_ScreenSaver
{
    public partial class ScreenSaver : Form
    {
        int stepX = 5, stepY = 5;
        int MouseSiteX, MouseSiteY;
        const int MouseMovementDistance = 100; // 指定的滑鼠位移閾值
        bool isFlipped = false; // 記錄圖片是否已經翻轉

        public ScreenSaver()
        {
            DoubleBuffered = true; // 啟用雙緩衝
            InitializeComponent();
            MouseMove += ScreenSaver_MouseMove; // 訂閱滑鼠移動事件
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((pictureBox1.Location.X + pictureBox1.Width) > ClientSize.Width || pictureBox1.Location.X < 0)
            {
                stepX = -stepX;

                // 在碰到左右螢幕邊框時翻轉圖片
                if (!isFlipped)
                {
                    // 讀取另一張 GIF 圖片來翻轉
                    pictureBox1.Image = Properties.Resources.Screensaver_2;
                    isFlipped = true;
                }
                else
                {
                    // 讀取原始的 GIF 圖片
                    pictureBox1.Image = Properties.Resources.Screensaver;
                    isFlipped = false;
                }
            }
            if ((pictureBox1.Location.Y + pictureBox1.Height) > ClientSize.Height || pictureBox1.Location.Y < 0)
                stepY = -stepY;

            pictureBox1.Location = new Point(pictureBox1.Location.X + stepX, pictureBox1.Location.Y + stepY);

            Refresh(); // 強制重新繪製畫面
        }

        private void ScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {
            if (Math.Abs(e.X - MouseSiteX) >= MouseMovementDistance || Math.Abs(e.Y - MouseSiteY) >= MouseMovementDistance)
            {
                // 如果滑鼠位移超過指定閾值，則關閉程式
                Close();
            }
        }

        private void ScreenSaver_Load(object sender, EventArgs e)
        {
            MouseSiteX = MousePosition.X;
            MouseSiteY = MousePosition.Y;
        }
              

        private void ScreenSaver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}