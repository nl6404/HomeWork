using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Alarm
{
    public partial class Alarm : Form
    {
        private DateTime alarmTime; // 声明鬧鐘時間變量
        private System.Media.SoundPlayer player; // 播放音樂的 SoundPlayer 對象
        public Alarm()
        {
            InitializeComponent();
            labDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            labTime.Text = DateTime.Now.ToString("HH:mm:ss");
            MyInitial();
        }

        private void TimerTime_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            labDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void MyInitial()
        {
            // 添加小時選項
            for (int i = 0; i <= 23; i++)
            {
                cmbHour.Items.Add(i.ToString("00")); // 將數字轉換為雙位數字格式，例如 1 轉換為 "01"
            }
            cmbHour.SelectedIndex = 0;

            cmbHour.DropDownHeight = 160; // 設定較小的下拉選單高度

            // 添加分鐘選項
            for (int i = 0; i <= 59; i++)
            {
                cmbMinute.Items.Add(i.ToString("00")); // 將數字轉換為雙位數字格式，例如 1 轉換為 "01"
            }
            cmbMinute.SelectedIndex = 0;
                        
            cmbMinute.DropDownHeight = 160;

            // 添加秒鐘選項
            for (int i = 0; i <= 59; i++)
            {
                cmbSecond.Items.Add(i.ToString("00")); // 將數字轉換為雙位數字格式，例如 1 轉換為 "01"
            }
            cmbSecond.SelectedIndex = 0;

            cmbSecond.DropDownHeight = 160;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            int selectedHour = Convert.ToInt32(cmbHour.SelectedItem.ToString());
            int selectedMinute = Convert.ToInt32(cmbMinute.SelectedItem.ToString());
            int selectedSecond = Convert.ToInt32(cmbSecond.SelectedItem.ToString());

            alarmTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                                              selectedHour, selectedMinute, selectedSecond);

            MessageBox.Show("鬧鐘已設定為：" + alarmTime.ToString("HH:mm:ss"));

            // 計算距離鬧鐘設定時間還剩下多少時間
            TimeSpan timeRemaining = alarmTime - DateTime.Now;

            // 啟動定時器            
            timer1.Tick += CountdownTimer_Tick;
            timer1.Start();
        }

        // 定時器的 Tick 事件處理方法
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            // 計算距離鬧鐘設定時間還剩下多少時間
            TimeSpan timeRemaining = alarmTime - DateTime.Now;

            if (timeRemaining.TotalSeconds <= 0)
            {
                // 鬧鐘時間到達，停止定時器
                timer1.Stop();

                // 播放音樂
                PlayAlarmSound();

                MessageBox.Show("鬧鐘時間到達！");

                StopAlarmSound();
                return;
            }

            // 更新 Label 的內容，顯示距離鬧鐘設定時間還剩下多少時間
            labShowRemaining.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", 
                                                   timeRemaining.Hours, 
                                                   timeRemaining.Minutes, 
                                                   timeRemaining.Seconds);
        }

        private void PlayAlarmSound()
        {
            // 指定音樂文件的路徑
            System.IO.Stream soundFileStream = Properties.Resources.song;

            // 初始化 SoundPlayer 對象
            player = new System.Media.SoundPlayer(soundFileStream);

            // 播放音樂
            player.Play();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // 停止計時器
            timer1.Stop();

            // 重置顯示剩餘時間的 Label
            labShowRemaining.Text = "00:00:00";

            StopAlarmSound();

            // 提示用戶鬧鐘已取消
            MessageBox.Show("鬧鐘已關閉");
        }

        private void StopAlarmSound()
        {
            // 停止播放音樂
            player?.Stop();
        }


    }
}
