namespace HW_Loan
{
    partial class Loan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loan));
            this.labCount = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.labInterestRate = new System.Windows.Forms.Label();
            this.labDownPayment = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.btnPMT = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.BackColor = System.Drawing.Color.Gold;
            this.labCount.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCount.ForeColor = System.Drawing.Color.Black;
            this.labCount.Location = new System.Drawing.Point(123, 49);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(137, 38);
            this.labCount.TabIndex = 4;
            this.labCount.Text = "貸款金額";
            this.labCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.BackColor = System.Drawing.Color.Gold;
            this.labYear.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labYear.ForeColor = System.Drawing.Color.Black;
            this.labYear.Location = new System.Drawing.Point(123, 116);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(129, 38);
            this.labYear.TabIndex = 5;
            this.labYear.Text = "期限(年)";
            this.labYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labInterestRate
            // 
            this.labInterestRate.AutoSize = true;
            this.labInterestRate.BackColor = System.Drawing.Color.Gold;
            this.labInterestRate.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labInterestRate.ForeColor = System.Drawing.Color.Black;
            this.labInterestRate.Location = new System.Drawing.Point(123, 181);
            this.labInterestRate.Name = "labInterestRate";
            this.labInterestRate.Size = new System.Drawing.Size(126, 38);
            this.labInterestRate.TabIndex = 6;
            this.labInterestRate.Text = "利率(%)";
            this.labInterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labDownPayment
            // 
            this.labDownPayment.AutoSize = true;
            this.labDownPayment.BackColor = System.Drawing.Color.Gold;
            this.labDownPayment.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDownPayment.ForeColor = System.Drawing.Color.Black;
            this.labDownPayment.Location = new System.Drawing.Point(123, 242);
            this.labDownPayment.Name = "labDownPayment";
            this.labDownPayment.Size = new System.Drawing.Size(107, 38);
            this.labDownPayment.TabIndex = 7;
            this.labDownPayment.Text = "頭期款";
            this.labDownPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCount.Location = new System.Drawing.Point(311, 49);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(213, 38);
            this.txtCount.TabIndex = 8;
            this.txtCount.Text = "100000";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtYear.Location = new System.Drawing.Point(311, 116);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(213, 38);
            this.txtYear.TabIndex = 9;
            this.txtYear.Text = "2";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInterestRate.Location = new System.Drawing.Point(311, 181);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(213, 38);
            this.txtInterestRate.TabIndex = 10;
            this.txtInterestRate.Text = "10";
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDownPayment.Location = new System.Drawing.Point(311, 242);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(213, 38);
            this.txtDownPayment.TabIndex = 11;
            this.txtDownPayment.Text = "0";
            // 
            // btnPMT
            // 
            this.btnPMT.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPMT.Location = new System.Drawing.Point(39, 314);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(250, 54);
            this.btnPMT.TabIndex = 12;
            this.btnPMT.Text = "PMT(月付額)";
            this.btnPMT.UseVisualStyleBackColor = true;
            this.btnPMT.Click += new System.EventHandler(this.btnPMT_Click);
            // 
            // btnCount
            // 
            this.btnCount.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCount.Location = new System.Drawing.Point(311, 315);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(173, 54);
            this.btnCount.TabIndex = 13;
            this.btnCount.Text = "總付款";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(521, 315);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(161, 54);
            this.btnReport.TabIndex = 14;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 428);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnPMT);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.labDownPayment);
            this.Controls.Add(this.labInterestRate);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.labCount);
            this.Name = "Loan";
            this.Text = "Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label labInterestRate;
        private System.Windows.Forms.Label labDownPayment;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.Button btnPMT;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnReport;
    }
}

