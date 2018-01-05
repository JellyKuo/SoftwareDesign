namespace COD02
{
    partial class detailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.numBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.staNumBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lonBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.latBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addrTxt = new System.Windows.Forms.TextBox();
            this.mapBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "代碼：";
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(99, 27);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(100, 22);
            this.numBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "站點代碼：";
            // 
            // staNumBox
            // 
            this.staNumBox.Location = new System.Drawing.Point(295, 27);
            this.staNumBox.Name = "staNumBox";
            this.staNumBox.Size = new System.Drawing.Size(285, 22);
            this.staNumBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "站點名稱：";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(99, 55);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(481, 22);
            this.nameBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "經度：";
            // 
            // lonBox
            // 
            this.lonBox.Location = new System.Drawing.Point(99, 83);
            this.lonBox.Name = "lonBox";
            this.lonBox.Size = new System.Drawing.Size(100, 22);
            this.lonBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "緯度：";
            // 
            // latBox
            // 
            this.latBox.Location = new System.Drawing.Point(256, 83);
            this.latBox.Name = "latBox";
            this.latBox.Size = new System.Drawing.Size(100, 22);
            this.latBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "地址：";
            // 
            // addrTxt
            // 
            this.addrTxt.Location = new System.Drawing.Point(99, 112);
            this.addrTxt.Multiline = true;
            this.addrTxt.Name = "addrTxt";
            this.addrTxt.Size = new System.Drawing.Size(481, 66);
            this.addrTxt.TabIndex = 1;
            // 
            // mapBtn
            // 
            this.mapBtn.Location = new System.Drawing.Point(459, 83);
            this.mapBtn.Name = "mapBtn";
            this.mapBtn.Size = new System.Drawing.Size(121, 23);
            this.mapBtn.TabIndex = 2;
            this.mapBtn.Text = "Google地圖定位";
            this.mapBtn.UseVisualStyleBackColor = true;
            this.mapBtn.Click += new System.EventHandler(this.mapBtn_Click);
            // 
            // detailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 203);
            this.Controls.Add(this.mapBtn);
            this.Controls.Add(this.addrTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.staNumBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.latBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lonBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "detailForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "detailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox staNumBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lonBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox latBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addrTxt;
        private System.Windows.Forms.Button mapBtn;
    }
}