namespace HW_MyClac
{
    partial class MyClac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyClac));
            this.labNum1 = new System.Windows.Forms.Label();
            this.labNum2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.labAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labNum1
            // 
            this.labNum1.AutoSize = true;
            this.labNum1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNum1.Location = new System.Drawing.Point(24, 188);
            this.labNum1.Name = "labNum1";
            this.labNum1.Size = new System.Drawing.Size(107, 36);
            this.labNum1.TabIndex = 0;
            this.labNum1.Text = "Num1:";
            // 
            // labNum2
            // 
            this.labNum2.AutoSize = true;
            this.labNum2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNum2.Location = new System.Drawing.Point(24, 341);
            this.labNum2.Name = "labNum2";
            this.labNum2.Size = new System.Drawing.Size(107, 36);
            this.labNum2.TabIndex = 1;
            this.labNum2.Text = "Num2:";
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum1.Location = new System.Drawing.Point(141, 188);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNum1.Multiline = true;
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(145, 34);
            this.txtNum1.TabIndex = 4;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum2.Location = new System.Drawing.Point(141, 342);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNum2.Multiline = true;
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(145, 33);
            this.txtNum2.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(301, 122);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 68);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSubtraction.Location = new System.Drawing.Point(301, 205);
            this.btnSubtraction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(83, 68);
            this.btnSubtraction.TabIndex = 8;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMultiplication.Location = new System.Drawing.Point(301, 294);
            this.btnMultiplication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(83, 68);
            this.btnMultiplication.TabIndex = 9;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDivision.Location = new System.Drawing.Point(301, 382);
            this.btnDivision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(83, 68);
            this.btnDivision.TabIndex = 10;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // labAnswer
            // 
            this.labAnswer.BackColor = System.Drawing.Color.Transparent;
            this.labAnswer.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAnswer.ForeColor = System.Drawing.Color.White;
            this.labAnswer.Location = new System.Drawing.Point(30, 41);
            this.labAnswer.Name = "labAnswer";
            this.labAnswer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labAnswer.Size = new System.Drawing.Size(351, 45);
            this.labAnswer.TabIndex = 2;
            this.labAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MyClac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(408, 461);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.labAnswer);
            this.Controls.Add(this.labNum2);
            this.Controls.Add(this.labNum1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MyClac";
            this.Text = "MyClac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNum1;
        private System.Windows.Forms.Label labNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Label labAnswer;
    }
}

