namespace HW_POS
{
    partial class POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            this.gpb_Menu = new System.Windows.Forms.GroupBox();
            this.btnWine = new System.Windows.Forms.Button();
            this.btnWhisky = new System.Windows.Forms.Button();
            this.btnTequila = new System.Windows.Forms.Button();
            this.btnBeer = new System.Windows.Forms.Button();
            this.gpbList = new System.Windows.Forms.GroupBox();
            this.txtMenuList = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.gpbPayment = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.gpbTotalPrice = new System.Windows.Forms.GroupBox();
            this.txtShowPrice = new System.Windows.Forms.TextBox();
            this.gpb_Menu.SuspendLayout();
            this.gpbList.SuspendLayout();
            this.gpbPayment.SuspendLayout();
            this.gpbTotalPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_Menu
            // 
            this.gpb_Menu.BackColor = System.Drawing.Color.Transparent;
            this.gpb_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gpb_Menu.Controls.Add(this.btnWine);
            this.gpb_Menu.Controls.Add(this.btnWhisky);
            this.gpb_Menu.Controls.Add(this.btnTequila);
            this.gpb_Menu.Controls.Add(this.btnBeer);
            this.gpb_Menu.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpb_Menu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpb_Menu.Location = new System.Drawing.Point(28, 28);
            this.gpb_Menu.Name = "gpb_Menu";
            this.gpb_Menu.Size = new System.Drawing.Size(314, 366);
            this.gpb_Menu.TabIndex = 0;
            this.gpb_Menu.TabStop = false;
            this.gpb_Menu.Text = "菜單 Menu";
            // 
            // btnWine
            // 
            this.btnWine.BackColor = System.Drawing.Color.White;
            this.btnWine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWine.BackgroundImage")));
            this.btnWine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnWine.Location = new System.Drawing.Point(165, 206);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(131, 138);
            this.btnWine.TabIndex = 3;
            this.btnWine.Text = "紅酒\r\nWine\r\nNT$320";
            this.btnWine.UseVisualStyleBackColor = false;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // btnWhisky
            // 
            this.btnWhisky.BackColor = System.Drawing.Color.White;
            this.btnWhisky.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWhisky.BackgroundImage")));
            this.btnWhisky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWhisky.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWhisky.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnWhisky.Location = new System.Drawing.Point(19, 206);
            this.btnWhisky.Name = "btnWhisky";
            this.btnWhisky.Size = new System.Drawing.Size(131, 138);
            this.btnWhisky.TabIndex = 2;
            this.btnWhisky.Text = "威士忌\r\nWhisky\r\nNT$350";
            this.btnWhisky.UseVisualStyleBackColor = false;
            this.btnWhisky.Click += new System.EventHandler(this.btnWhisky_Click);
            // 
            // btnTequila
            // 
            this.btnTequila.BackColor = System.Drawing.Color.White;
            this.btnTequila.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTequila.BackgroundImage")));
            this.btnTequila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTequila.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTequila.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTequila.Location = new System.Drawing.Point(165, 51);
            this.btnTequila.Name = "btnTequila";
            this.btnTequila.Size = new System.Drawing.Size(131, 138);
            this.btnTequila.TabIndex = 1;
            this.btnTequila.Text = "龍舌蘭\r\nTequila\r\nNT$180";
            this.btnTequila.UseVisualStyleBackColor = false;
            this.btnTequila.Click += new System.EventHandler(this.btnTequila_Click);
            // 
            // btnBeer
            // 
            this.btnBeer.BackColor = System.Drawing.Color.White;
            this.btnBeer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBeer.BackgroundImage")));
            this.btnBeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBeer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBeer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBeer.Location = new System.Drawing.Point(19, 51);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(131, 138);
            this.btnBeer.TabIndex = 0;
            this.btnBeer.Text = "啤酒\r\nBeer\r\nNT$120";
            this.btnBeer.UseVisualStyleBackColor = false;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // gpbList
            // 
            this.gpbList.BackColor = System.Drawing.Color.Transparent;
            this.gpbList.Controls.Add(this.txtMenuList);
            this.gpbList.Controls.Add(this.btnClear);
            this.gpbList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpbList.Location = new System.Drawing.Point(595, 35);
            this.gpbList.Name = "gpbList";
            this.gpbList.Size = new System.Drawing.Size(334, 359);
            this.gpbList.TabIndex = 1;
            this.gpbList.TabStop = false;
            this.gpbList.Text = "購物清單 List";
            // 
            // txtMenuList
            // 
            this.txtMenuList.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMenuList.Location = new System.Drawing.Point(6, 33);
            this.txtMenuList.Multiline = true;
            this.txtMenuList.Name = "txtMenuList";
            this.txtMenuList.Size = new System.Drawing.Size(318, 275);
            this.txtMenuList.TabIndex = 8;
            this.txtMenuList.Text = "尚未點餐";
            this.txtMenuList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(220, 314);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 39);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "清除清單";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gpbPayment
            // 
            this.gpbPayment.BackColor = System.Drawing.Color.Transparent;
            this.gpbPayment.Controls.Add(this.label1);
            this.gpbPayment.Controls.Add(this.btnCreditCard);
            this.gpbPayment.Controls.Add(this.btnCash);
            this.gpbPayment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbPayment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpbPayment.Location = new System.Drawing.Point(354, 175);
            this.gpbPayment.Name = "gpbPayment";
            this.gpbPayment.Size = new System.Drawing.Size(227, 146);
            this.gpbPayment.TabIndex = 2;
            this.gpbPayment.TabStop = false;
            this.gpbPayment.Text = "付款方式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(83, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "信用卡享九折!";
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreditCard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreditCard.Location = new System.Drawing.Point(117, 59);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(95, 39);
            this.btnCreditCard.TabIndex = 5;
            this.btnCreditCard.Text = "信用卡";
            this.btnCreditCard.UseVisualStyleBackColor = true;
            this.btnCreditCard.Click += new System.EventHandler(this.btnCreditCard_Click);
            // 
            // btnCash
            // 
            this.btnCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCash.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCash.Location = new System.Drawing.Point(16, 59);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(95, 39);
            this.btnCash.TabIndex = 4;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // gpbTotalPrice
            // 
            this.gpbTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.gpbTotalPrice.Controls.Add(this.txtShowPrice);
            this.gpbTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbTotalPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpbTotalPrice.Location = new System.Drawing.Point(354, 35);
            this.gpbTotalPrice.Name = "gpbTotalPrice";
            this.gpbTotalPrice.Size = new System.Drawing.Size(227, 124);
            this.gpbTotalPrice.TabIndex = 2;
            this.gpbTotalPrice.TabStop = false;
            this.gpbTotalPrice.Text = "總金額 Total Price";
            // 
            // txtShowPrice
            // 
            this.txtShowPrice.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtShowPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.txtShowPrice.Location = new System.Drawing.Point(11, 57);
            this.txtShowPrice.Name = "txtShowPrice";
            this.txtShowPrice.Size = new System.Drawing.Size(200, 34);
            this.txtShowPrice.TabIndex = 0;
            this.txtShowPrice.Text = "NT$0";
            this.txtShowPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 444);
            this.Controls.Add(this.gpbList);
            this.Controls.Add(this.gpbTotalPrice);
            this.Controls.Add(this.gpbPayment);
            this.Controls.Add(this.gpb_Menu);
            this.Name = "POS";
            this.Text = "POS";
            this.gpb_Menu.ResumeLayout(false);
            this.gpbList.ResumeLayout(false);
            this.gpbList.PerformLayout();
            this.gpbPayment.ResumeLayout(false);
            this.gpbPayment.PerformLayout();
            this.gpbTotalPrice.ResumeLayout(false);
            this.gpbTotalPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_Menu;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Button btnWhisky;
        private System.Windows.Forms.Button btnTequila;
        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.GroupBox gpbList;
        private System.Windows.Forms.GroupBox gpbPayment;
        private System.Windows.Forms.GroupBox gpbTotalPrice;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtMenuList;
        private System.Windows.Forms.TextBox txtShowPrice;
    }
}

