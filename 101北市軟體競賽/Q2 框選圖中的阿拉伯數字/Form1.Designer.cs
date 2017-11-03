namespace Q2_框選圖中的阿拉伯數字
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
            this.label1 = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.exeBtn = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入圖檔名";
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(95, 199);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(177, 22);
            this.pathBox.TabIndex = 1;
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(12, 227);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 2;
            this.loadBtn.Text = "載入圖檔";
            this.loadBtn.UseVisualStyleBackColor = true;
            // 
            // exeBtn
            // 
            this.exeBtn.Location = new System.Drawing.Point(93, 227);
            this.exeBtn.Name = "exeBtn";
            this.exeBtn.Size = new System.Drawing.Size(179, 23);
            this.exeBtn.TabIndex = 2;
            this.exeBtn.Text = "框選圖檔中的阿拉伯數字";
            this.exeBtn.UseVisualStyleBackColor = true;
            this.exeBtn.Click += new System.EventHandler(this.exeBtn_Click);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(12, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(260, 181);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 3;
            this.picBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.exeBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button exeBtn;
        private System.Windows.Forms.PictureBox picBox;
    }
}

