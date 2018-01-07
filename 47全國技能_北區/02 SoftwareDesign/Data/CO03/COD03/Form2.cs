using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //Use stringbuilder to provide higher string constructing efficiency
            StringBuilder sb = new StringBuilder("SELECT * FROM Salary WHERE ");
            if (txtId.Text != "")
                sb.AppendFormat("Id LIKE '%{0}%' AND ", txtId.Text);
            if(txtName.Text!="")
                sb.AppendFormat("name LIKE '%{0}%' AND ", txtName.Text);
            if (txtBasesalary.Text != "")
                sb.AppendFormat("basesalary LIKE '%{0}%' AND ", txtBasesalary.Text);
            if (txtBonus.Text != "")
                sb.AppendFormat("bonus LIKE '%{0}%' AND ", txtBonus.Text);
            if (txtDeduct.Text != "")
                sb.AppendFormat("deduct LIKE '%{0}%' AND ", txtDeduct.Text);
            if (txtSubtotal.Text != "")
                sb.AppendFormat("subtotal LIKE '%{0}%' AND ", txtSubtotal.Text);
            sb.Remove(sb.Length - 5, 5);
            sb.Append(';');
            using(var cmd = new SqlCommand(sb.ToString(),cn))
            {
                using(var ada = new SqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    ada.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            int[] d = new int[6];
            using(var cmd = new SqlCommand("SELECT subtotal FROM Salary", cn))
            {
                using(var ada = new SqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    ada.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        var v = (int)row[0];
                        if (v < 15000)
                            d[0]++;
                        else if (v < 25000)
                            d[1]++;
                        else if (v < 50000)
                            d[2]++;
                        else if (v < 75000)
                            d[3]++;
                        else if (v < 95000)
                            d[4]++;
                        else
                            d[5]++;
                    }
                }
            }


            var app = new Excel.Application();
            app.Visible = true;
            var  wb = app.Workbooks.Add();
            Excel.Worksheet ws = wb.ActiveSheet;

            ws.Cells[1, 1] = "薪資小計<15000";
            ws.Cells[2, 1] = "15000≦薪資小計<25000";
            ws.Cells[3, 1] = "25000≦薪資小計<50000";
            ws.Cells[4, 1] = "50000≦薪資小計<75000";
            ws.Cells[5, 1] = "75000≦薪資小計<95000";
            ws.Cells[6, 1] = "薪資小計≧95000";
            for (int i = 1; i < 7; i++)
                ws.Cells[i,2] = d[i-1];

            var chartRange = ws.Range[ws.Cells[1, 1], ws.Cells[6, 2]];
            Excel.ChartObjects charts = ws.ChartObjects();
            var chart = (charts.Add(150,20,250,200)).Chart;
            chart.SetSourceData(chartRange);
            chart.ChartType = Excel.XlChartType.xlPie;
        }
    }
}
