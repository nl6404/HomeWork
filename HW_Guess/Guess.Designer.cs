namespace HW_Guess
{
    partial class Guess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guess));
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnShowAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Select A Number Between 1 to 100!";
            // 
            // btnGuess
            // 
            this.btnGuess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuess.BackgroundImage")));
            this.btnGuess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuess.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGuess.ForeColor = System.Drawing.Color.White;
            this.btnGuess.Location = new System.Drawing.Point(101, 220);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(160, 75);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnShowAnswer
            // 
            this.btnShowAnswer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowAnswer.BackgroundImage")));
            this.btnShowAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowAnswer.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowAnswer.ForeColor = System.Drawing.Color.White;
            this.btnShowAnswer.Location = new System.Drawing.Point(300, 220);
            this.btnShowAnswer.Name = "btnShowAnswer";
            this.btnShowAnswer.Size = new System.Drawing.Size(248, 75);
            this.btnShowAnswer.TabIndex = 2;
            this.btnShowAnswer.Text = "Show Answer";
            this.btnShowAnswer.UseVisualStyleBackColor = true;
            this.btnShowAnswer.Click += new System.EventHandler(this.btnShowAnswer_Click);
            // 
            // Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(649, 406);
            this.Controls.Add(this.btnShowAnswer);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.label1);
            this.Name = "Guess";
            this.Text = "Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnShowAnswer;
    }
}

