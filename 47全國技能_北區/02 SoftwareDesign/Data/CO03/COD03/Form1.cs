using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.IO;

namespace COD03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //SqlConnection cn = new SqlConnection();
            //TODO 完成連線字串，開啟資料庫，並進行資料錄設定
            cn.Open();

            //Load the first set of data
            hScrollBar1_Scroll(null, null);
        }

      
        private void btnClean_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtBasesalary.Text = "";
            txtBonus.Text = "";
            txtDeduct.Text = "";
            txtId.Enabled = true;

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }

            string sql = string.Format("SELECT * FROM Salary WHERE Enabled = 1");
            
            using (var cmd = new SqlCommand(sql, cn))
            {
                using(var ada = new SqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    ada.Fill(dt);

                    //Placing this here to prevent out of range when user delete last record
                    hScrollBar1.Maximum = dt.Rows.Count - 1;
                    int v = hScrollBar1.Value;

                    txtId.Text = (string)dt.Rows[v]["Id"];
                    txtName.Text = (string)dt.Rows[v]["name"];
                    txtBasesalary.Text = (dt.Rows[v]["basesalary"] as int?).ToString();
                    txtBonus.Text = (dt.Rows[v]["bonus"] as int?).ToString();
                    txtDeduct.Text = (dt.Rows[v]["deduct"] as int?).ToString();
                    if ((string)dt.Rows[v]["Picture"] != "") 
                        pictureBox1.Image = Image.FromFile((string)dt.Rows[v]["Picture"]);
                    else
                    {
                        pictureBox1.Image = null;
                    }
                        pictureBox1.Update();

                    lblCount.Text = (v+1).ToString()+"/"+dt.Rows.Count.ToString();
                }
            }
        }

        bool Edit(string sqlstr)
        {

            //SqlConnection cn = new SqlConnection();
            // 完成連線字串，開啟資料庫，執行傳入的SQL指令

            if (cn.State != ConnectionState.Open)
                cn.Open();
            using(var cmd = new SqlCommand(sqlstr,cn))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }

        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 新增資料
            string sqlstr;
            try
            {
                //Casting here to calculate subtotal and check data type before passing to Sql
                var check = checkId(txtId.Text);
                string id;
                if (check.HasValue)
                {
                    id = txtId.Text + check.Value;
                    txtId.Text = id;
                }
                else
                    throw new InvalidCastException("Id 格式不符!");

                var name = txtName.Text;
                var basesalary = int.Parse(txtBasesalary.Text);
                var bonus = int.Parse(txtBonus.Text);
                var deduct = int.Parse(txtDeduct.Text);
                var subtotal = basesalary + bonus - deduct;

                sqlstr = string.Format("INSERT INTO Salary VALUES('{0}','{1}',{2},{3},{4},{5},1)", id, name, basesalary, bonus, deduct,subtotal);

                if(!Edit(sqlstr))
                    MessageBox.Show("與現有資料庫重複!");
                else
                    MessageBox.Show("加入成功!");
                txtId.Enabled = false;  
                hScrollBar1_Scroll(null, null);
            }
            catch(InvalidCastException invalidCaseEx)
            {
                MessageBox.Show("輸入資料格式不正確\n"+invalidCaseEx.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //更新資料
            var id = txtId.Text;
            var name = txtName.Text;
            var basesalary = int.Parse(txtBasesalary.Text);
            var bonus = int.Parse(txtBonus.Text);
            var deduct = int.Parse(txtDeduct.Text);
            var subtotal = basesalary + bonus - deduct;

            var sqlstr = string.Format("UPDATE Salary SET name = '{0}', basesalary = {1}, bonus = {2}, deduct = {3}, subtotal = {4} WHERE Id = '{5}';", name,basesalary,bonus,deduct,subtotal,id);
            Edit(sqlstr);
            hScrollBar1_Scroll(null, null);
            MessageBox.Show("資料已更新!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 刪除資料
            if(MessageBox.Show("確定刪除?","",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)!=DialogResult.OK);
            return;
            //We are not allowed to delete data, instead we mark it as not enabled
            var sqlstr = string.Format("UPDATE Salary SET Enabled = 0 WHERE Id = '{0}';",txtId.Text);
            Edit(sqlstr);
            //Refresh current view and also update scrollbar
            hScrollBar1_Scroll(null, null);
            MessageBox.Show("刪除成功!");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //開啟Form2表單
            var f2 = new Form2();
            f2.Show();
        }

        private int? checkId(string id)
        {
            int fn = 0;

            //65 is A, 70 is F
            if (id[0] > 64 && id[0] < 71)
                // 65(A) - 64 = 1
                fn = (id[0] - 64) * 5;
            else
                return null;

            for(int i = 0; i < 4;i++)
            {
                //id[index] is char. If char is 0~9, 0 ascii is 48, id[i] - 48 gets number
                int num = id[i + 1] - 48;
                if (num< 0 || num> 9)
                    return null;
                fn += num * (4 - i);
            }
            //Add tens and ones place together
            int check = fn % 10 + fn / 10;
            //If check > 9, get only ones place
            check = check > 9 ? check % 10 : check;
            return check;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog()
            {
                Filter = "JPG | *.jpg"
            };
            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            //Get relative path using Uri
            var selUri = new Uri(ofd.FileName);
            var envUri = new Uri(Application.ExecutablePath);
            //Uri's MakeRelativeUri utilize the specified uri as base path
            var path = envUri.MakeRelativeUri(selUri).ToString();
            var id = txtId.Text;
            if (id == "")
            {
                MessageBox.Show("Id不能為空!");
                return;
            }
            var sqlstr = string.Format("UPDATE Salary SET Picture = '{0}' WHERE Id = '{1}'", path,id);
            if (!Edit(sqlstr))
            {
                MessageBox.Show("指定的Id不存在!");
                return;
            }
            else
            {
                MessageBox.Show("圖片設定成功!");
                hScrollBar1_Scroll(null, null);
            }
        }
    }
}
