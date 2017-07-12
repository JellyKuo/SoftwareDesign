using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() != DialogResult.OK)
                return;
            rtb.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (strBox.Text == "")
            {
                MessageBox.Show("未輸入欲搜尋的字串", "搜尋字串並標示黃色背景顏色", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            rtb.SelectAll();
            rtb.SelectionBackColor = Color.White;
             int start = rtb.SelectionStart, startIndex = 0, index;
            int count = 0;
            while (((index = rtb.Text.IndexOf(strBox.Text, startIndex)) != -1))
            {
                rtb.Select(index, strBox.Text.Length);
                rtb.SelectionBackColor = Color.Yellow;
                startIndex = index + strBox.Text.Length;
                count++;
            }
            countLab.Text = count.ToString();
        }
    }
}
