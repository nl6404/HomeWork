using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_PictureViwer
{
    public partial class PictureViwer : Form
    {
        private Form imageForm = null;// 用於儲存已開啟的視窗

        public PictureViwer()
        {
            InitializeComponent();
            //MessageBox.Show("IU我婆", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowPicture(Image image)
        {
            // 如果已經有視窗開啟，則先關閉它
            if (imageForm != null)
            {
                imageForm.Close();
                imageForm.Dispose();
                imageForm = null;
            }

            // 建立新的視窗並顯示圖片
            imageForm = new Form();
            PictureBox imagePictureBox = new PictureBox();
            imagePictureBox.Image = image;
            imagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imagePictureBox.Dock = DockStyle.Fill;

            imageForm.StartPosition = FormStartPosition.CenterScreen;
            imageForm.Controls.Add(imagePictureBox);
            imageForm.Show();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = (PictureBox)sender;
            Image clickedImage = clickedPictureBox.Image;
            ShowPicture(clickedImage);
        }
    }
}
