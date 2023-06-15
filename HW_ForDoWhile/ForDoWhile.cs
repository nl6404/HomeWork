using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace HW_ForDoWhile
{
    public partial class ForDoWhile : Form
    {
        public ForDoWhile()
        {
            InitializeComponent();
        }

        private void btnOddEven_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(txtNumber.Text, out int num))
            {
                if (num % 2 == 0)
                {
                    labResult.Text = $"輸入的數{num}為 偶數。";
                }
                else
                {
                    labResult.Text = $"輸入的數{num}為 奇數。";
                }
            }
            else
                MessageBox.Show("請輸入數值");
        }

        private void btnProduce_Click(object sender, EventArgs e)
        {
            labResult.Text = "";
            if (int.TryParse(txtRows.Text, out int num))
            {
                for (int i = 1; i <= num; i++)
                {
                    string line = "";

                    for (int j = 0; j < i; j++)
                    {
                        line += "*";
                    }

                    labResult.Text += line + "\n";
                }
            }
            else
                MessageBox.Show("請輸入數值");
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            
            int n1 = 100, n2 = 200;
            Swap<int>(ref n1, ref n2);
            labResult.Text = $"換位前n1=100 , n2=200\r\n" +
                             $"換位後n1={n1} , n2={n2}";
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            
            int num = 100;
            string binary = Convert.ToString(num, 2);
            labResult.Text = binary;
        }

        private void btn99_Click(object sender, EventArgs e)
        {
            labResult.Text = "";
            labResult.Text += "九九乘法表\r\n";

            int num;
            string result = "";

            for (int j = 1; j < 10; j++)
            {
                for (int i = 2; i < 10; i++)
                {
                    num = i * j;
                    result += $"{i} * {j} = {num.ToString().PadLeft(2)} |";
                }
                result += "\r\n";
            }
            labResult.Text += result;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labResult.Text = "結果";
        }

        private void btnLotoo_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<int> selectedNumbers = new List<int>();

            while (selectedNumbers.Count < 6)
            {
                int randomNumber = random.Next(1, 50);

                if (!selectedNumbers.Contains(randomNumber))
                {
                    selectedNumbers.Add(randomNumber);
                }
            }

            string message = string.Join(" ", selectedNumbers);
            labResult.Text = $"樂透號碼\r\n {message}";
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
             if (int.TryParse(txtFrom.Text, out int from)
              && int.TryParse(txtTo.Text, out int to)
              && int.TryParse(txtStep.Text, out int step))
            {
                int sum = 0;

                for (int i = from; i <= to; i += step)
                {
                    sum += i;
                }
                labResult.Text = $"{from} 到 {to} 相隔 {step - 1}\r\n" +
                                 $"加總為 {sum}";
            }
            else
                MessageBox.Show("請輸入數值");
        }

        private void butWhile_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtFrom.Text, out int from)
             && int.TryParse(txtTo.Text, out int to)
             && int.TryParse(txtStep.Text, out int step))
            {
                int sum = 0;
                int i = from;
                while (i <= to)
                {
                    sum += i;
                    i += step;
                }
                labResult.Text = $"{from} 到 {to} 相隔 {step - 1}\r\n" +
                                 $"加總為 {sum}";
            }
            else
                MessageBox.Show("請輸入數值");
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtFrom.Text, out int from)
             && int.TryParse(txtTo.Text, out int to)
             && int.TryParse(txtStep.Text, out int step))
            {
                int sum = 0;
                int i = from;
                do
                {
                    sum += i;
                    i += step;
                }
                while (i <= to);

                labResult.Text = $"{from} 到 {to} 相隔 {step - 1}\r\n" +
                                 $"加總為 {sum}";
            }
            else
                MessageBox.Show("請輸入數值");
        }

        private void btnArrOddEven_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            foreach (int i in arr0711)
            {
                if (i % 2 == 0)
                {
                    list1.Add(i);
                }
                else
                {
                    list2.Add(i);
                }
            }
            labResult.Text = $"int陣列arr0711[{string.Join(", ", arr0711)}]" +
                             $"\r\n奇數共 {list2.Count}" +
                             $"\r\n偶數共 {list1.Count}";
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            labResult.Text = $"int陣列arr0711[{string.Join(", ", arr0711)}]" +
                             $"\r\n最大值為 {arr0711.Max()}" +
                             $"\r\n最小值為 {arr0711.Min()}";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            labResult.Text = $"int陣列arr0711[{string.Join(", ", arr0711)}]" +
                             $"\r\n加總為為 {arr0711.Sum()}";
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            labResult.Text = $"int陣列arr0711[{string.Join(", ", arr0711)}]" +
                             $"\r\n最大值為 {arr0711.Max()}";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            labResult.Text = $"int陣列arr0711[{string.Join(", ", arr0711)}]" +
                             $"\r\n最小值為 {arr0711.Min()}";
        }

        private void btnLong_Click(object sender, EventArgs e)
        {
            string[] arr0711_Str = {"mother張", "emma", "迪克蕭", "J40", "Candy",
                                    "Cindy", "Cocount", "Motherfacker"};
            string longstring = "";
            int maxlength = 0;
            foreach (string str in arr0711_Str)
            {
                if (str.Length > maxlength)
                {
                    maxlength = str.Length;
                    longstring = str;
                }
            }
            labResult.Text = $"arr0711_Str陣列 [{string.Join(", ", arr0711_Str)}]" +
                             $"\r\n最長的名字為{longstring}";
        }

        private void btnCc_Click(object sender, EventArgs e)
        {
            string[] arr0711_Str = {"mother張", "emma", "迪克蕭", "J40", "Candy",
                                    "Cindy", "Cocount", "Motherfacker"};
            int count = 0;
            foreach (string str in arr0711_Str)
            {
                if (str.Contains("c") || str.Contains("C"))
                {
                    count++;
                }
            }
            labResult.Text = $"arr0711_Str陣列 [{string.Join(", ", arr0711_Str)}]" +
                             $"\r\n有 C 及 c 的名字共有 {count} 個";
        }

        private void btn2Darray1_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                arr[0, i] = 0; //左
                arr[9, i] = 0; //右
                arr[i, 0] = 0; //上
                arr[i, 9] = 0; //下
            }

            for (int j = 1; j < 9; j++)
            {
                for (int k = 1; k < 9; k++)
                {
                    arr[j, k] = 1;
                }
            }

            string result = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    result += arr[i, j].ToString() + " ";
                }
                result += "\n";
            }

            labResult.Text = result;
        }

        private void btn2Darray2_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                arr[0, i] = 1;
                arr[9, i] = 1;
                arr[i, 0] = 1;
                arr[i, 9] = 1;
            }
            for (int j = 1; j < 9; j++)
            {
                for (int k = 1; k < 9; k++)
                {
                    arr[j, k] = 0;
                }
            }

            string result = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    result += arr[i, j].ToString() + " ";
                }
                result += "\n";
            }

            labResult.Text = result;
        }

        private void btnbtn2Darray3_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((i + j) % 2 == 0)
                        arr[i, j] = 1;
                    else
                        arr[i, j] = 0;
                }
            }

            string result = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    result += arr[i, j].ToString()+" ";
                }
                result += "\n";
            }
            labResult.Text = result;
        }
    }
}
