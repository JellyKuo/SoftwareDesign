using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace COD03
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //完成連線字串，將目前資料庫資料顯示在DataGridView內
            cn.Open();
            var sqlstr = "SELECT * FROM Salary ORDER BY subtotal DESC";
            using (var cmd = new SqlCommand(sqlstr, cn))
            {
                using (var ada = new SqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    ada.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}
