using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4_彩色影像品質量測
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileBtn.Click += (sender, e) =>
            {
                var ofd = new OpenFileDialog
                {
                    Filter = "BMP檔案 (*.bmp)|*.bmp|所有檔案|*.*"
                };
                if (ofd.ShowDialog() != DialogResult.OK)
                    return;
                OpenPicture(ofd.FileName);
            };
        }
        private void OpenPicture(string @Path)
        {
            picBox.Image = Image.FromFile(Path);
        }
    }
}
