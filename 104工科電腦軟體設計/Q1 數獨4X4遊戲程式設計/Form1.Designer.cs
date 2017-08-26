namespace Q1_數獨4X4遊戲程式設計
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
            this.HintBtn = new System.Windows.Forms.Button();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.ResLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HintBtn
            // 
            this.HintBtn.Location = new System.Drawing.Point(197, 12);
            this.HintBtn.Name = "HintBtn";
            this.HintBtn.Size = new System.Drawing.Size(75, 23);
            this.HintBtn.TabIndex = 1;
            this.HintBtn.Text = "產生提示";
            this.HintBtn.UseVisualStyleBackColor = true;
            this.HintBtn.Click += new System.EventHandler(this.HintBtn_Click);
            // 
            // CheckBtn
            // 
            this.CheckBtn.Location = new System.Drawing.Point(197, 41);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(75, 23);
            this.CheckBtn.TabIndex = 1;
            this.CheckBtn.Text = "Check";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // ResLab
            // 
            this.ResLab.AutoSize = true;
            this.ResLab.Location = new System.Drawing.Point(195, 67);
            this.ResLab.Name = "ResLab";
            this.ResLab.Size = new System.Drawing.Size(0, 12);
            this.ResLab.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ResLab);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.HintBtn);
            this.Name = "Form1";
            this.Text = "簡易數獨";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HintBtn;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.Label ResLab;
    }
}

