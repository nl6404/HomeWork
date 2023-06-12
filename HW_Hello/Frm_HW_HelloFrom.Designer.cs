namespace HW_Hello
{
    partial class Frm_HW_HelloFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HW_HelloFrom));
            this.lab_Name = new System.Windows.Forms.Label();
            this.lab_EnglishName = new System.Windows.Forms.Label();
            this.lab_Sex = new System.Windows.Forms.Label();
            this.lab_Sign = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_EnglishName = new System.Windows.Forms.TextBox();
            this.txt_Sex = new System.Windows.Forms.TextBox();
            this.txt_Sign = new System.Windows.Forms.TextBox();
            this.btn_SayHello = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_SayHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.BackColor = System.Drawing.Color.Transparent;
            this.lab_Name.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Name.Location = new System.Drawing.Point(264, 74);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(93, 38);
            this.lab_Name.TabIndex = 0;
            this.lab_Name.Text = "姓名 :";
            // 
            // lab_EnglishName
            // 
            this.lab_EnglishName.AutoSize = true;
            this.lab_EnglishName.BackColor = System.Drawing.Color.Transparent;
            this.lab_EnglishName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_EnglishName.Location = new System.Drawing.Point(264, 141);
            this.lab_EnglishName.Name = "lab_EnglishName";
            this.lab_EnglishName.Size = new System.Drawing.Size(233, 38);
            this.lab_EnglishName.TabIndex = 1;
            this.lab_EnglishName.Text = "English Name :";
            // 
            // lab_Sex
            // 
            this.lab_Sex.AutoSize = true;
            this.lab_Sex.BackColor = System.Drawing.Color.Transparent;
            this.lab_Sex.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Sex.Location = new System.Drawing.Point(264, 205);
            this.lab_Sex.Name = "lab_Sex";
            this.lab_Sex.Size = new System.Drawing.Size(93, 38);
            this.lab_Sex.TabIndex = 2;
            this.lab_Sex.Text = "性別 :";
            // 
            // lab_Sign
            // 
            this.lab_Sign.AutoSize = true;
            this.lab_Sign.BackColor = System.Drawing.Color.Transparent;
            this.lab_Sign.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Sign.Location = new System.Drawing.Point(264, 273);
            this.lab_Sign.Name = "lab_Sign";
            this.lab_Sign.Size = new System.Drawing.Size(93, 38);
            this.lab_Sign.TabIndex = 3;
            this.lab_Sign.Text = "星座 :";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(518, 74);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(195, 38);
            this.txt_Name.TabIndex = 4;
            // 
            // txt_EnglishName
            // 
            this.txt_EnglishName.Location = new System.Drawing.Point(518, 141);
            this.txt_EnglishName.Multiline = true;
            this.txt_EnglishName.Name = "txt_EnglishName";
            this.txt_EnglishName.Size = new System.Drawing.Size(195, 38);
            this.txt_EnglishName.TabIndex = 5;
            // 
            // txt_Sex
            // 
            this.txt_Sex.Location = new System.Drawing.Point(518, 205);
            this.txt_Sex.Multiline = true;
            this.txt_Sex.Name = "txt_Sex";
            this.txt_Sex.Size = new System.Drawing.Size(195, 38);
            this.txt_Sex.TabIndex = 6;
            // 
            // txt_Sign
            // 
            this.txt_Sign.Location = new System.Drawing.Point(518, 273);
            this.txt_Sign.Multiline = true;
            this.txt_Sign.Name = "txt_Sign";
            this.txt_Sign.Size = new System.Drawing.Size(195, 38);
            this.txt_Sign.TabIndex = 7;
            // 
            // btn_SayHello
            // 
            this.btn_SayHello.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SayHello.BackgroundImage")));
            this.btn_SayHello.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SayHello.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SayHello.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_SayHello.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SayHello.Location = new System.Drawing.Point(271, 344);
            this.btn_SayHello.Name = "btn_SayHello";
            this.btn_SayHello.Size = new System.Drawing.Size(176, 53);
            this.btn_SayHello.TabIndex = 8;
            this.btn_SayHello.Text = "Say Hello!";
            this.btn_SayHello.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SayHello.UseVisualStyleBackColor = true;
            this.btn_SayHello.Click += new System.EventHandler(this.btn_SayHello_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(552, 797);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_SayHi
            // 
            this.btn_SayHi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SayHi.BackgroundImage")));
            this.btn_SayHi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SayHi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SayHi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_SayHi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SayHi.Location = new System.Drawing.Point(549, 344);
            this.btn_SayHi.Name = "btn_SayHi";
            this.btn_SayHi.Size = new System.Drawing.Size(137, 53);
            this.btn_SayHi.TabIndex = 10;
            this.btn_SayHi.Text = "Say Hi!";
            this.btn_SayHi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SayHi.UseVisualStyleBackColor = true;
            this.btn_SayHi.Click += new System.EventHandler(this.btn_SayHi_Click);
            // 
            // Frm_HW_HelloFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SayHi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_SayHello);
            this.Controls.Add(this.txt_Sign);
            this.Controls.Add(this.txt_Sex);
            this.Controls.Add(this.txt_EnglishName);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lab_Sign);
            this.Controls.Add(this.lab_Sex);
            this.Controls.Add(this.lab_EnglishName);
            this.Controls.Add(this.lab_Name);
            this.Name = "Frm_HW_HelloFrom";
            this.Text = "Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.Label lab_EnglishName;
        private System.Windows.Forms.Label lab_Sex;
        private System.Windows.Forms.Label lab_Sign;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_EnglishName;
        private System.Windows.Forms.TextBox txt_Sex;
        private System.Windows.Forms.TextBox txt_Sign;
        private System.Windows.Forms.Button btn_SayHello;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_SayHi;
    }
}

