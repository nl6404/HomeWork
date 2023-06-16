namespace HW_Studen_StructFrom
{
    partial class Studen_StructFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Studen_StructFrom));
            this.labName = new System.Windows.Forms.Label();
            this.labChi = new System.Windows.Forms.Label();
            this.labEng = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.gpbScores = new System.Windows.Forms.GroupBox();
            this.labMaxMin = new System.Windows.Forms.Label();
            this.labShowScores = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.btnShowSave = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.gpbScores.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.White;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.ForeColor = System.Drawing.Color.Black;
            this.labName.Location = new System.Drawing.Point(80, 69);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(78, 36);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名:";
            // 
            // labChi
            // 
            this.labChi.AutoSize = true;
            this.labChi.BackColor = System.Drawing.Color.White;
            this.labChi.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChi.ForeColor = System.Drawing.Color.Black;
            this.labChi.Location = new System.Drawing.Point(80, 129);
            this.labChi.Name = "labChi";
            this.labChi.Size = new System.Drawing.Size(78, 36);
            this.labChi.TabIndex = 1;
            this.labChi.Text = "國文:";
            // 
            // labEng
            // 
            this.labEng.AutoSize = true;
            this.labEng.BackColor = System.Drawing.Color.White;
            this.labEng.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEng.ForeColor = System.Drawing.Color.Black;
            this.labEng.Location = new System.Drawing.Point(80, 189);
            this.labEng.Name = "labEng";
            this.labEng.Size = new System.Drawing.Size(78, 36);
            this.labEng.TabIndex = 2;
            this.labEng.Text = "英文:";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.BackColor = System.Drawing.Color.White;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.ForeColor = System.Drawing.Color.Black;
            this.labMath.Location = new System.Drawing.Point(80, 249);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(78, 36);
            this.labMath.TabIndex = 3;
            this.labMath.Text = "數學:";
            // 
            // gpbScores
            // 
            this.gpbScores.BackColor = System.Drawing.Color.Transparent;
            this.gpbScores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gpbScores.BackgroundImage")));
            this.gpbScores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpbScores.Controls.Add(this.labMaxMin);
            this.gpbScores.Controls.Add(this.labShowScores);
            this.gpbScores.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbScores.ForeColor = System.Drawing.Color.Black;
            this.gpbScores.Location = new System.Drawing.Point(396, 12);
            this.gpbScores.Name = "gpbScores";
            this.gpbScores.Size = new System.Drawing.Size(354, 351);
            this.gpbScores.TabIndex = 4;
            this.gpbScores.TabStop = false;
            this.gpbScores.Text = "成績";
            // 
            // labMaxMin
            // 
            this.labMaxMin.BackColor = System.Drawing.Color.Transparent;
            this.labMaxMin.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMaxMin.ForeColor = System.Drawing.Color.Transparent;
            this.labMaxMin.Location = new System.Drawing.Point(12, 253);
            this.labMaxMin.Name = "labMaxMin";
            this.labMaxMin.Size = new System.Drawing.Size(332, 93);
            this.labMaxMin.TabIndex = 1;
            // 
            // labShowScores
            // 
            this.labShowScores.BackColor = System.Drawing.Color.Transparent;
            this.labShowScores.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowScores.ForeColor = System.Drawing.Color.Transparent;
            this.labShowScores.Location = new System.Drawing.Point(12, 29);
            this.labShowScores.Name = "labShowScores";
            this.labShowScores.Size = new System.Drawing.Size(332, 219);
            this.labShowScores.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(188, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 34);
            this.txtName.TabIndex = 7;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChi
            // 
            this.txtChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChi.Location = new System.Drawing.Point(188, 129);
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(140, 34);
            this.txtChi.TabIndex = 8;
            this.txtChi.Text = "0";
            this.txtChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEng
            // 
            this.txtEng.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEng.Location = new System.Drawing.Point(188, 189);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(140, 34);
            this.txtEng.TabIndex = 9;
            this.txtEng.Text = "0";
            this.txtEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMath
            // 
            this.txtMath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(188, 249);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(140, 34);
            this.txtMath.TabIndex = 10;
            this.txtMath.Text = "0";
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnShowSave
            // 
            this.btnShowSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowSave.Location = new System.Drawing.Point(216, 323);
            this.btnShowSave.Name = "btnShowSave";
            this.btnShowSave.Size = new System.Drawing.Size(170, 49);
            this.btnShowSave.TabIndex = 11;
            this.btnShowSave.Text = "顯示儲存內容";
            this.btnShowSave.UseVisualStyleBackColor = true;
            this.btnShowSave.Click += new System.EventHandler(this.btnShowSave_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(27, 323);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 49);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaxMin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMaxMin.Location = new System.Drawing.Point(534, 369);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(216, 49);
            this.btnMaxMin.TabIndex = 13;
            this.btnMaxMin.Text = "最高分/最低分科目";
            this.btnMaxMin.UseVisualStyleBackColor = true;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // Studen_StructFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMaxMin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShowSave);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.txtChi);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.gpbScores);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEng);
            this.Controls.Add(this.labChi);
            this.Controls.Add(this.labName);
            this.Name = "Studen_StructFrom";
            this.Text = "Studen_StructFrom";
            this.gpbScores.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labChi;
        private System.Windows.Forms.Label labEng;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.GroupBox gpbScores;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Button btnShowSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.Label labMaxMin;
        private System.Windows.Forms.Label labShowScores;
    }
}

