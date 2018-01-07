namespace COD03
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cn = new System.Data.SqlClient.SqlConnection();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBasesalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(594, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // cn
            // 
            this.cn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Jelly\\Documents\\Rep" +
    "ository\\SoftwareDesign\\47全國技能_北區\\02 SoftwareDesign\\Data\\CO03\\COD03\\TestDB.mdf\";I" +
    "ntegrated Security=True";
            this.cn.FireInfoMessageEventOnUserErrors = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "員工編號";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(91, 14);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "姓名(name)";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(268, 14);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "本俸(basesalary)";
            // 
            // txtBasesalary
            // 
            this.txtBasesalary.Location = new System.Drawing.Point(477, 14);
            this.txtBasesalary.Name = "txtBasesalary";
            this.txtBasesalary.Size = new System.Drawing.Size(100, 22);
            this.txtBasesalary.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "獎金(bonus)";
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(91, 42);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(100, 22);
            this.txtBonus.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "扣款(deduct)";
            // 
            // txtDeduct
            // 
            this.txtDeduct.Location = new System.Drawing.Point(268, 42);
            this.txtDeduct.Name = "txtDeduct";
            this.txtDeduct.Size = new System.Drawing.Size(100, 22);
            this.txtDeduct.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "薪資小計(subtotal)";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(477, 42);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubtotal.TabIndex = 2;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(421, 70);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "查詢";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(502, 70);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(75, 23);
            this.exportBtn.TabIndex = 3;
            this.exportBtn.Text = "匯出圖表";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 348);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtBasesalary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDeduct);
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "薪資統計表";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.SqlClient.SqlConnection cn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBasesalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDeduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button exportBtn;
    }
}