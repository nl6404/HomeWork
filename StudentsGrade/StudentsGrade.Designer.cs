namespace StudentsGrade
{
    partial class StudentsGrade
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
            this.labName = new System.Windows.Forms.Label();
            this.labChi = new System.Windows.Forms.Label();
            this.labEng = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRandomSave = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRandom20 = new System.Windows.Forms.Button();
            this.labtitle = new System.Windows.Forms.Label();
            this.labStatistics = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labdata = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(23, 20);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(64, 29);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名:";
            // 
            // labChi
            // 
            this.labChi.AutoSize = true;
            this.labChi.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChi.Location = new System.Drawing.Point(23, 77);
            this.labChi.Name = "labChi";
            this.labChi.Size = new System.Drawing.Size(64, 29);
            this.labChi.TabIndex = 1;
            this.labChi.Text = "國文:";
            // 
            // labEng
            // 
            this.labEng.AutoSize = true;
            this.labEng.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEng.Location = new System.Drawing.Point(23, 134);
            this.labEng.Name = "labEng";
            this.labEng.Size = new System.Drawing.Size(64, 29);
            this.labEng.TabIndex = 2;
            this.labEng.Text = "英文:";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(23, 191);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(64, 29);
            this.labMath.TabIndex = 3;
            this.labMath.Text = "數學:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 20);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(122, 29);
            this.txtName.TabIndex = 4;
            // 
            // txtChi
            // 
            this.txtChi.Location = new System.Drawing.Point(106, 77);
            this.txtChi.Multiline = true;
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(122, 29);
            this.txtChi.TabIndex = 5;
            // 
            // txtEng
            // 
            this.txtEng.Location = new System.Drawing.Point(106, 134);
            this.txtEng.Multiline = true;
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(122, 29);
            this.txtEng.TabIndex = 6;
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(106, 191);
            this.txtMath.Multiline = true;
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(122, 29);
            this.txtMath.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(54, 243);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 40);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "加入學生資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRandomSave
            // 
            this.btnRandomSave.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRandomSave.Location = new System.Drawing.Point(54, 297);
            this.btnRandomSave.Name = "btnRandomSave";
            this.btnRandomSave.Size = new System.Drawing.Size(143, 40);
            this.btnRandomSave.TabIndex = 9;
            this.btnRandomSave.Text = "隨機儲存資料";
            this.btnRandomSave.UseVisualStyleBackColor = true;
            this.btnRandomSave.Click += new System.EventHandler(this.btnRandomSave_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Enabled = false;
            this.btnStatistics.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStatistics.Location = new System.Drawing.Point(54, 351);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(143, 40);
            this.btnStatistics.TabIndex = 10;
            this.btnStatistics.Text = "各科統計";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(54, 435);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(143, 40);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "重設所有資料";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRandom20
            // 
            this.btnRandom20.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRandom20.Location = new System.Drawing.Point(54, 489);
            this.btnRandom20.Name = "btnRandom20";
            this.btnRandom20.Size = new System.Drawing.Size(143, 40);
            this.btnRandom20.TabIndex = 12;
            this.btnRandom20.Text = "隨機加入20筆";
            this.btnRandom20.UseVisualStyleBackColor = true;
            this.btnRandom20.Click += new System.EventHandler(this.btnRandom20_Click);
            // 
            // labtitle
            // 
            this.labtitle.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labtitle.Location = new System.Drawing.Point(3, 4);
            this.labtitle.Name = "labtitle";
            this.labtitle.Size = new System.Drawing.Size(567, 30);
            this.labtitle.TabIndex = 13;
            this.labtitle.Text = "姓名       國文      英文      數學      總分      平均        最低        最高";
            // 
            // labStatistics
            // 
            this.labStatistics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labStatistics.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labStatistics.Location = new System.Drawing.Point(252, 409);
            this.labStatistics.Name = "labStatistics";
            this.labStatistics.Size = new System.Drawing.Size(591, 120);
            this.labStatistics.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labdata);
            this.panel1.Controls.Add(this.labtitle);
            this.panel1.Location = new System.Drawing.Point(252, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 380);
            this.panel1.TabIndex = 15;
            // 
            // labdata
            // 
            this.labdata.AutoSize = true;
            this.labdata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labdata.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labdata.Location = new System.Drawing.Point(1, 27);
            this.labdata.Name = "labdata";
            this.labdata.Size = new System.Drawing.Size(2, 18);
            this.labdata.TabIndex = 0;
            this.labdata.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StudentsGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(855, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labStatistics);
            this.Controls.Add(this.btnRandom20);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnRandomSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.txtChi);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEng);
            this.Controls.Add(this.labChi);
            this.Controls.Add(this.labName);
            this.Name = "StudentsGrade";
            this.Text = "StudentsGrade";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labChi;
        private System.Windows.Forms.Label labEng;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRandomSave;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRandom20;
        private System.Windows.Forms.Label labtitle;
        private System.Windows.Forms.Label labStatistics;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labdata;
    }
}

