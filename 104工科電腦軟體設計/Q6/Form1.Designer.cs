namespace Q6
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
            this.openBtn = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.strBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countLab = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(13, 13);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(182, 23);
            this.openBtn.TabIndex = 0;
            this.openBtn.Text = "開啟文字檔顯示在下面方塊中";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // ofd
            // 
            this.ofd.Filter = "純文字 (*.txt)|*.txt";
            this.ofd.Title = "開啟";
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(13, 43);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(491, 360);
            this.rtb.TabIndex = 1;
            this.rtb.Text = "";
            // 
            // strBox
            // 
            this.strBox.Location = new System.Drawing.Point(12, 438);
            this.strBox.Name = "strBox";
            this.strBox.Size = new System.Drawing.Size(318, 22);
            this.strBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "請輸入欲搜尋的字串:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "找到的個數:";
            // 
            // countLab
            // 
            this.countLab.AutoSize = true;
            this.countLab.Location = new System.Drawing.Point(336, 448);
            this.countLab.Name = "countLab";
            this.countLab.Size = new System.Drawing.Size(11, 12);
            this.countLab.TabIndex = 3;
            this.countLab.Text = "0";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(429, 436);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "搜尋";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 472);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.countLab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.strBox);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.openBtn);
            this.Name = "Form1";
            this.Text = "搜尋字串並標示黃色背景顏色";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.TextBox strBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label countLab;
        private System.Windows.Forms.Button searchBtn;
    }
}

