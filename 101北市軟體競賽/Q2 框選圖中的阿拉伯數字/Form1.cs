using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2_框選圖中的阿拉伯數字
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exeBtn_Click(object sender, EventArgs e)
        {
            var Bmp = (Bitmap)Image.FromFile(@pathBox.Text);
            int XMin = int.MaxValue, XMax = 0, YMin = int.MaxValue, YMax = 0;
            for (int y = 0; y < Bmp.Height; y++)
            {
                for (int x = 0; x < Bmp.Width; x++)
                {
                    if (Bmp.GetPixel(x, y) ==Color.FromArgb(255,0,0,0))
                    {
                        if (x < XMin)
                            XMin = x;
                        if (x > XMax)
                            XMax = x;

                        if (y < YMin)
                            YMin = y;
                        if (y > YMax)
                            YMax = y;
                    }
                }
            }

            for (int i =XMin-1; i < XMax+1 ; i++)
            {
                Bmp.SetPixel(i, YMin - 1, Color.Red);
            }
            for (int j = YMin-1; j < YMax+1; j++)
            {
                Bmp.SetPixel(XMin - 1, j, Color.Red);
                Bmp.SetPixel(XMax + 1, j, Color.Red);
            }
            for (int i =XMin-1; i <XMax+2 ; i++)
            {
                Bmp.SetPixel(i, YMax + 1, Color.Red);
            }
            picBox.Image = Bmp;
        }
    }
}
