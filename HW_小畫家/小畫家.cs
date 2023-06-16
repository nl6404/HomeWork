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

namespace HW_小畫家
{
    public partial class 小畫家 : Form
    {
        int x0, y0;
        Bitmap bmp;
        int penPoint;
        Color penColor;
        Graphics g;
        Pen pen;
        public 小畫家()
        {
            InitializeComponent();
            pen = new Pen(penColor, penPoint);
            bmp = new Bitmap(this.Width, this.Height - menuStrip1.Height);
            g = Graphics.FromImage(bmp);            
            pictureBox1.Size = new Size(this.Width, this.Height - menuStrip1.Height);
            pictureBox1.Location = new Point(0, menuStrip1.Height);

            penColor = Color.Black;
            penPoint = 1;
            pictureBox1.Image = bmp;
            pictureBox1.Refresh();
        }
                

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = e.X;
            y0 = e.Y;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                penColor = colorDialog1.Color;
            labColor.BackColor = penColor;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pen = new Pen(penColor, penPoint);
                g = Graphics.FromImage(bmp);
                g.DrawLine(pen, x0, y0, e.X, e.Y);
                pictureBox1.Image = bmp;
                x0 = e.X;
                y0 = e.Y;
            }
        }

        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(this.Width, this.Height - menuStrip1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Size = new Size(this.Width, this.Height - menuStrip1.Height);
            pictureBox1.Location = new Point(0, menuStrip1.Height);

            pictureBox1.Image = bmp;
            pictureBox1.Refresh();
        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bmp = new Bitmap(pictureBox1.Image);
                    bmp.Save(saveFileDialog1.FileName);
                }
            }
            else
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                bmp.Save(saveFileDialog1.FileName);
            }
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                bmp.Save(saveFileDialog1.FileName);
            }
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            penPoint = trackBar.Value;
            labRange.Text = trackBar.Value.ToString();
        }
    }
}

