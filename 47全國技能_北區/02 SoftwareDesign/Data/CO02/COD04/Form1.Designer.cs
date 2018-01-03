namespace COD04
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDataList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.cmdOpenRead = new System.Windows.Forms.Button();
            this.cmdBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataList
            // 
            this.dgvDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataList.Location = new System.Drawing.Point(38, 71);
            this.dgvDataList.Name = "dgvDataList";
            this.dgvDataList.RowTemplate.Height = 24;
            this.dgvDataList.Size = new System.Drawing.Size(803, 387);
            this.dgvDataList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "資料來源：";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(107, 25);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(605, 22);
            this.txtFilePath.TabIndex = 2;
            // 
            // cmdOpenRead
            // 
            this.cmdOpenRead.Location = new System.Drawing.Point(749, 25);
            this.cmdOpenRead.Name = "cmdOpenRead";
            this.cmdOpenRead.Size = new System.Drawing.Size(92, 23);
            this.cmdOpenRead.TabIndex = 3;
            this.cmdOpenRead.Text = "讀取";
            this.cmdOpenRead.UseVisualStyleBackColor = true;
            this.cmdOpenRead.Click += new System.EventHandler(this.cmdOpenRead_Click);
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Location = new System.Drawing.Point(718, 25);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(25, 23);
            this.cmdBrowse.TabIndex = 4;
            this.cmdBrowse.Text = "...";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 489);
            this.Controls.Add(this.cmdBrowse);
            this.Controls.Add(this.cmdOpenRead);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDataList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "高雄市公共腳踏車租賃站";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDataList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button cmdOpenRead;
        private System.Windows.Forms.Button cmdBrowse;
    }
}

