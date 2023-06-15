using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_POS
{
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }

        int beercount = 0;
        int beertotal = 0;

        int tequilacount = 0;
        int tequilatotal = 0;

        int whiskycount = 0;
        int whiskytotal = 0;

        int winecount = 0;
        int winetotal = 0;

        string[] array = new string[4];

        private void btnBeer_Click(object sender, EventArgs e)
        {
            beercount += 120;
            beertotal += 1;
            array[0] = $"啤酒Beer *{beertotal},共{beercount:C0}\r\n";
            Totalcount();
            Menulist();
        }

        private void btnTequila_Click(object sender, EventArgs e)
        {
            tequilacount += 180;
            tequilatotal += 1;
            array[1] = $"龍舌蘭Tequila *{tequilatotal},共{tequilacount:C0}\r\n";            
            Totalcount();
            Menulist();
        }

        private void btnWhisky_Click(object sender, EventArgs e)
        {
            whiskycount += 350;
            whiskytotal += 1;
            array[2] = $"威士忌Whisky *{whiskytotal},共{whiskycount:C0}\r\n";
            Totalcount();
            Menulist();
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            winecount += 320;
            winetotal += 1;
            array[3] = $"紅酒Wine *{winetotal},共{winecount:C0}\r\n";
            Totalcount();
            Menulist();
        }

        private void Totalcount()
        {
            txtShowPrice.Text = (beercount + tequilacount + whiskycount + winecount).ToString("C0");
        }



        private void Menulist()
        {
            //String Menulist = array[0]+ array[1] + array[2] + array[3];
            //String Menulist = string.Join("",array);
            
            //txtMenuList.Text = Menulist;
            
            txtMenuList.Text = string.Join("", array);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 重設相關變數
            beercount = 0;
            beertotal = 0;
            tequilacount = 0;
            tequilatotal = 0;
            whiskycount = 0;
            whiskytotal = 0;
            winecount = 0;
            winetotal = 0;

            // 清空陣列
            Array.Clear(array, 0, array.Length);

            // 清除總價格和菜單顯示
            txtShowPrice.Text = "NT$0";
            txtMenuList.Text = "尚未點餐";

        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額:NT$" + (beercount + tequilacount + whiskycount + winecount));
            
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額:NT$" + (beercount + tequilacount + whiskycount + winecount)
                            + "\r\n折扣後金額:NT$" + 0.9*(beercount + tequilacount + whiskycount + winecount));
        }
    }
}
