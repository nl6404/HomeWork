namespace HW_Guess
{
    partial class ReturnGuess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnGuess));
            this.labtitle = new System.Windows.Forms.Label();
            this.txtReturnNum = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labtitle
            // 
            this.labtitle.AutoSize = true;
            this.labtitle.BackColor = System.Drawing.Color.Transparent;
            this.labtitle.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labtitle.ForeColor = System.Drawing.Color.White;
            this.labtitle.Location = new System.Drawing.Point(13, 13);
            this.labtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labtitle.Name = "labtitle";
            this.labtitle.Size = new System.Drawing.Size(262, 28);
            this.labtitle.TabIndex = 1;
            this.labtitle.Text = "Please Input a Number.";
            // 
            // txtReturnNum
            // 
            this.txtReturnNum.Location = new System.Drawing.Point(11, 53);
            this.txtReturnNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtReturnNum.Multiline = true;
            this.txtReturnNum.Name = "txtReturnNum";
            this.txtReturnNum.Size = new System.Drawing.Size(251, 28);
            this.txtReturnNum.TabIndex = 2;
            // 
            // btnEnter
            // 
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEnter.Location = new System.Drawing.Point(56, 117);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(57, 28);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(161, 117);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 28);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ReturnGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(274, 156);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtReturnNum);
            this.Controls.Add(this.labtitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReturnGuess";
            this.Text = "ReturnGuess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labtitle;
        private System.Windows.Forms.TextBox txtReturnNum;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCancel;
    }
}