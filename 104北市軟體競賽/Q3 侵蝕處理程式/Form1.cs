using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3_侵蝕處理程式
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
                erosionBtn.Enabled = true;
            };
            erosionBtn.Click += (sender, e) => picBox.Image = Erosion(new Bitmap(picBox.Image));
        }

        private void OpenPicture(string @Path)
        {
            picBox.Image = Image.FromFile(Path);
        }

        private Bitmap Erosion(Bitmap Src)
        {
            var Result = new Bitmap(Src.Width, Src.Height);
            var B = Color.FromArgb(255, 0, 0, 0);
            for (int y = 1; y < Src.Height - 1; y++)
                for (int x = 1; x < Src.Width - 1; x++)
                {
                    if (Src.GetPixel(x, y) != Color.FromArgb(255, 255, 255, 255))
                    {
                        if (Src.GetPixel(x - 1, y - 1) == B &&
                            Src.GetPixel(x, y - 1) == B &&
                            Src.GetPixel(x + 1, y - 1) == B &&

                            Src.GetPixel(x - 1, y) == B &&
                            Src.GetPixel(x + 1, y) == B &&

                            Src.GetPixel(x - 1, y + 1) == B &&
                            Src.GetPixel(x, y + 1) == B &&
                            Src.GetPixel(x + 1, y + 1) == B)
                            Result.SetPixel(x, y, Src.GetPixel(x, y));
                    }
                }
            return Result;
        }
    }
}
