namespace HW_Alarm
{
    partial class Alarm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TimerTime = new System.Windows.Forms.Timer(this.components);
            this.labTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.labMinute = new System.Windows.Forms.Label();
            this.cmbMinute = new System.Windows.Forms.ComboBox();
            this.labHour = new System.Windows.Forms.Label();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.labTimeTitle = new System.Windows.Forms.Label();
            this.labRemaining = new System.Windows.Forms.Label();
            this.labShowRemaining = new System.Windows.Forms.Label();
            this.labSecond = new System.Windows.Forms.Label();
            this.cmbSecond = new System.Windows.Forms.ComboBox();
            this.labDateTitle = new System.Windows.Forms.Label();
            this.labDate = new System.Windows.Forms.Label();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerTime
            // 
            this.TimerTime.Enabled = true;
            this.TimerTime.Interval = 500;
            this.TimerTime.Tick += new System.EventHandler(this.TimerTime_Tick);
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTime.Location = new System.Drawing.Point(368, 72);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(247, 47);
            this.labTime.TabIndex = 0;
            this.labTime.Text = "XX XX:XX:XX";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.labSecond);
            this.groupBox1.Controls.Add(this.cmbSecond);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.labMinute);
            this.groupBox1.Controls.Add(this.cmbMinute);
            this.groupBox1.Controls.Add(this.labHour);
            this.groupBox1.Controls.Add(this.cmbHour);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(89, 139);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(621, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "設定鬧鐘";
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSet.Location = new System.Drawing.Point(117, 124);
            this.btnSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(183, 45);
            this.btnSet.TabIndex = 4;
            this.btnSet.Text = "設定鬧鐘";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // labMinute
            // 
            this.labMinute.AutoSize = true;
            this.labMinute.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMinute.Location = new System.Drawing.Point(353, 54);
            this.labMinute.Name = "labMinute";
            this.labMinute.Size = new System.Drawing.Size(47, 38);
            this.labMinute.TabIndex = 3;
            this.labMinute.Text = "分";
            // 
            // cmbMinute
            // 
            this.cmbMinute.FormattingEnabled = true;
            this.cmbMinute.Location = new System.Drawing.Point(221, 51);
            this.cmbMinute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMinute.Name = "cmbMinute";
            this.cmbMinute.Size = new System.Drawing.Size(127, 42);
            this.cmbMinute.TabIndex = 2;
            // 
            // labHour
            // 
            this.labHour.AutoSize = true;
            this.labHour.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labHour.Location = new System.Drawing.Point(169, 54);
            this.labHour.Name = "labHour";
            this.labHour.Size = new System.Drawing.Size(47, 38);
            this.labHour.TabIndex = 1;
            this.labHour.Text = "時";
            // 
            // cmbHour
            // 
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Location = new System.Drawing.Point(37, 51);
            this.cmbHour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(127, 42);
            this.cmbHour.TabIndex = 0;
            // 
            // labTimeTitle
            // 
            this.labTimeTitle.AutoSize = true;
            this.labTimeTitle.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTimeTitle.Location = new System.Drawing.Point(185, 72);
            this.labTimeTitle.Name = "labTimeTitle";
            this.labTimeTitle.Size = new System.Drawing.Size(177, 47);
            this.labTimeTitle.TabIndex = 2;
            this.labTimeTitle.Text = "現在時間:";
            // 
            // labRemaining
            // 
            this.labRemaining.AutoSize = true;
            this.labRemaining.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRemaining.Location = new System.Drawing.Point(101, 347);
            this.labRemaining.Name = "labRemaining";
            this.labRemaining.Size = new System.Drawing.Size(354, 38);
            this.labRemaining.TabIndex = 3;
            this.labRemaining.Text = "距離鬧鐘設定時間，剩餘:";
            // 
            // labShowRemaining
            // 
            this.labShowRemaining.AutoSize = true;
            this.labShowRemaining.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowRemaining.ForeColor = System.Drawing.Color.Red;
            this.labShowRemaining.Location = new System.Drawing.Point(461, 347);
            this.labShowRemaining.Name = "labShowRemaining";
            this.labShowRemaining.Size = new System.Drawing.Size(238, 38);
            this.labShowRemaining.TabIndex = 4;
            this.labShowRemaining.Text = "_________________";
            // 
            // labSecond
            // 
            this.labSecond.AutoSize = true;
            this.labSecond.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSecond.Location = new System.Drawing.Point(537, 53);
            this.labSecond.Name = "labSecond";
            this.labSecond.Size = new System.Drawing.Size(47, 38);
            this.labSecond.TabIndex = 6;
            this.labSecond.Text = "秒";
            // 
            // cmbSecond
            // 
            this.cmbSecond.FormattingEnabled = true;
            this.cmbSecond.Location = new System.Drawing.Point(405, 50);
            this.cmbSecond.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSecond.Name = "cmbSecond";
            this.cmbSecond.Size = new System.Drawing.Size(127, 42);
            this.cmbSecond.TabIndex = 5;
            // 
            // labDateTitle
            // 
            this.labDateTitle.AutoSize = true;
            this.labDateTitle.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDateTitle.Location = new System.Drawing.Point(14, 19);
            this.labDateTitle.Name = "labDateTitle";
            this.labDateTitle.Size = new System.Drawing.Size(78, 36);
            this.labDateTitle.TabIndex = 6;
            this.labDateTitle.Text = "日期:";
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDate.Location = new System.Drawing.Point(88, 19);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(191, 36);
            this.labDate.TabIndex = 5;
            this.labDate.Text = "XXXX/XX/XX\r\n";
            // 
            // timerDate
            // 
            this.timerDate.Enabled = true;
            this.timerDate.Interval = 500;
            this.timerDate.Tick += new System.EventHandler(this.timerDate_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(321, 124);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(183, 45);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "關閉鬧鐘";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.labDateTitle);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.labShowRemaining);
            this.Controls.Add(this.labRemaining);
            this.Controls.Add(this.labTimeTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labTime);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Alarm";
            this.Text = "Alarm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimerTime;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labTimeTitle;
        private System.Windows.Forms.Label labHour;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.Label labMinute;
        private System.Windows.Forms.ComboBox cmbMinute;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label labRemaining;
        private System.Windows.Forms.Label labShowRemaining;
        private System.Windows.Forms.Label labSecond;
        private System.Windows.Forms.ComboBox cmbSecond;
        private System.Windows.Forms.Label labDateTitle;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Timer timerDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCancel;
    }
}

