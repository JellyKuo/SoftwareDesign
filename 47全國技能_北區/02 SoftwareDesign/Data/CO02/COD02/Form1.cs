using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;


namespace COD02
{
    public partial class Form1 : Form
    {
        public class Station
        {
            public string StationId { get; set; }
            public string StationNo { get; set; }
            public string StationName { get; set; }
            public string StationAddress { get; set; }
            public string StationLat { get; set; }
            public string StationLng { get; set; }
            public string StationDesc { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection conn = null;
        string[] worksheets = null;
        DataTable dt = null;

        private void cmdOpenRead_Click(object sender, EventArgs e)
        {
            string dataSource = this.txtFilePath.Text;

            if (string.IsNullOrEmpty(dataSource))
            {
                MessageBox.Show("未選擇資料來源檔案。");
                return;
            }

            // 實作由 Excel 讀取資料並繫結至 DataGridView 的程式。

            var conneStr = string.Format(@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={0};Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;';", txtFilePath.Text);

            try
            {
                conn = new OleDbConnection(conneStr);
                conn.Open();
                DataTable dt;
                dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                List<string> ws = new List<string>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ws.Add((string)dt.Rows[i]["TABLE_NAME"]);
                    wsCombo.Items.Add(ws[i].Replace("$", ""));
                }
                worksheets = ws.ToArray();
                wsCombo.SelectedIndex = 0;  //This will trigger wsCombo.SelectedIndexChanged to update dataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.CheckFileExists = true;
                ofd.Filter = "Excel File (*.xlsx)|*.xlsx|Excel 97-2003 (*.xls)|*.xls";

                if (ofd.ShowDialog() == DialogResult.OK)
                    this.txtFilePath.Text = ofd.FileName;
            }
        }

        private void wsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateDgv(worksheets[wsCombo.SelectedIndex]);
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            wordApp.Visible = true;
            Word.Document doc = wordApp.Documents.Add();
            //TODO: Add header and footer
            foreach (DataRow row in dt.Rows)
            {
                Word.Paragraph para1 = doc.Content.Paragraphs.Add();
                para1.Range.Text = string.Format("代碼：{0}站點代號：{1}",row["代碼"],row["站點代號"]);
                para1.Range.InsertParagraphAfter();

                Word.Paragraph para2 = doc.Content.Paragraphs.Add();
                para2.Range.Text = string.Format("場站名稱：{0}",row["場站名稱"]);
                para2.Range.InsertParagraphAfter();

                Word.Paragraph para3 = doc.Content.Paragraphs.Add();
                para3.Range.Text = string.Format("緯度：{0}：經度：{1}", row["緯度"], row["經度"]);
                para3.Range.InsertParagraphAfter();

                Word.Paragraph para4 = doc.Content.Paragraphs.Add();
                para4.Range.Text = string.Format("地址：{0}", row["地址"]);
                para4.Range.InsertParagraphAfter();

                doc.Words.Last.InsertBreak(Word.WdBreakType.wdPageBreak);
                
            }
        }

        private void dgvDataList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Station stn = new Station();

            var row = dgvDataList.SelectedRows[0];
            stn.StationId = (row.Cells["代碼"].Value as double?).ToString() ;
            stn.StationNo = (string)row.Cells["站點代號"].Value;
            stn.StationName = (string)row.Cells["場站名稱"].Value;
            stn.StationLat = (row.Cells["緯度"].Value as double?).ToString();
            stn.StationLng = (row.Cells["經度"].Value as double?).ToString();
            stn.StationAddress = (string)row.Cells["地址"].Value;
            var detForm = new detailForm(stn);
            detForm.Show();
        }

        private void populateDgv(string sheetName)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = string.Format(@"SELECT * FROM [{0}]", sheetName);
                using (var cmd = new OleDbCommand(sql,conn))
                {
                    using (var ada = new OleDbDataAdapter(cmd))
                    {
                        dt = new DataTable();
                        ada.Fill(dt);
                        dgvDataList.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                Err(ex);
                return;
            }
        }

        private void Err(Exception ex)
        {
            Console.WriteLine(ex.Message);
            MessageBox.Show(ex.Message);
            throw ex;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Release possible memory
            if(conn!=null)
            {
                conn.Close();
                conn.Dispose();
            }
                 
            worksheets = null;
            base.OnFormClosing(e);
        }
    }
}
