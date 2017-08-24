namespace Q3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.signBox = new System.Windows.Forms.TextBox();
            this.exponentBox = new System.Windows.Forms.TextBox();
            this.mantissaBox = new System.Windows.Forms.TextBox();
            this.resBox = new System.Windows.Forms.TextBox();
            this.RndBtn = new System.Windows.Forms.Button();
            this.ConBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signBox
            // 
            this.signBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.signBox.Location = new System.Drawing.Point(122, 16);
            this.signBox.MaxLength = 1;
            this.signBox.Name = "signBox";
            this.signBox.Size = new System.Drawing.Size(27, 27);
            this.signBox.TabIndex = 0;
            this.signBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exponentBox
            // 
            this.exponentBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.exponentBox.Location = new System.Drawing.Point(155, 16);
            this.exponentBox.MaxLength = 8;
            this.exponentBox.Name = "exponentBox";
            this.exponentBox.Size = new System.Drawing.Size(96, 27);
            this.exponentBox.TabIndex = 1;
            this.exponentBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mantissaBox
            // 
            this.mantissaBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.mantissaBox.Location = new System.Drawing.Point(257, 16);
            this.mantissaBox.MaxLength = 23;
            this.mantissaBox.Name = "mantissaBox";
            this.mantissaBox.Size = new System.Drawing.Size(212, 27);
            this.mantissaBox.TabIndex = 2;
            this.mantissaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resBox
            // 
            this.resBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.resBox.Location = new System.Drawing.Point(122, 49);
            this.resBox.MaxLength = 600000;
            this.resBox.Name = "resBox";
            this.resBox.Size = new System.Drawing.Size(347, 27);
            this.resBox.TabIndex = 99;
            this.resBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RndBtn
            // 
            this.RndBtn.Location = new System.Drawing.Point(122, 82);
            this.RndBtn.Name = "RndBtn";
            this.RndBtn.Size = new System.Drawing.Size(75, 23);
            this.RndBtn.TabIndex = 4;
            this.RndBtn.Text = "Random";
            this.RndBtn.UseVisualStyleBackColor = true;
            this.RndBtn.Click += new System.EventHandler(this.RndBtn_Click);
            // 
            // ConBtn
            // 
            this.ConBtn.Location = new System.Drawing.Point(203, 82);
            this.ConBtn.Name = "ConBtn";
            this.ConBtn.Size = new System.Drawing.Size(75, 23);
            this.ConBtn.TabIndex = 3;
            this.ConBtn.Text = "Convert";
            this.ConBtn.UseVisualStyleBackColor = true;
            this.ConBtn.Click += new System.EventHandler(this.ConBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(284, 82);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "IEEE Excess-127:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Real number:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 114);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ConBtn);
            this.Controls.Add(this.RndBtn);
            this.Controls.Add(this.mantissaBox);
            this.Controls.Add(this.exponentBox);
            this.Controls.Add(this.resBox);
            this.Controls.Add(this.signBox);
            this.Name = "Form1";
            this.Text = "IEEE 超 127 單精確度浮點二進制值轉換為十進制實數值系統";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox signBox;
        private System.Windows.Forms.TextBox exponentBox;
        private System.Windows.Forms.TextBox mantissaBox;
        private System.Windows.Forms.TextBox resBox;
        private System.Windows.Forms.Button RndBtn;
        private System.Windows.Forms.Button ConBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

