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


namespace COD04
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

        private void cmdOpenRead_Click(object sender, EventArgs e)
        {
            string dataSource = this.txtFilePath.Text;

            if (string.IsNullOrEmpty(dataSource))
            {
                MessageBox.Show("未選擇資料來源檔案。");
                return;
            }

            // TODO: 
            // 實作由 Excel 讀取資料並繫結至 DataGridView 的程式。

        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.CheckFileExists = true;
                ofd.Filter = "    ";

                if (ofd.ShowDialog() == DialogResult.OK)
                    this.txtFilePath.Text = ofd.FileName;
            }
        }
    }
}
