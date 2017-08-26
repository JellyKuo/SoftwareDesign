using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1_數獨4X4遊戲程式設計
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += (sender, e) =>
            {
                Pen p = new Pen(Color.Black);
                e.Graphics.DrawLine(p, 68, 10, 68, 132);
                e.Graphics.DrawLine(p, 5, 70, 132, 70);
                p.Dispose();
            };
            GenerateUI();
            Reset();
        }

        Label[] Lab;
        Button[] NumBtn;
        int SelectedBox = -1;

        private void GenerateUI()
        {
            Lab = new Label[16];
            int x = 0, y = -25;
            for (int i = 0; i < 16; i++)
            {
                if ((i) % 4 == 0)
                {
                    x = 0;
                    y += 25;
                }
                if ((i) % 2 == 0)
                    x += 15;
                if (i % 8 == 0)
                    y += 15;
                Lab[i] = new Label()
                {
                    Name = i.ToString(),
                    AutoSize = false,
                    Size = new Size(23, 23),
                    Location = new Point(x, y),
                    BorderStyle = BorderStyle.Fixed3D,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                x += 23;
                Lab[i].Click += (sender, e) => SelectedBox = int.Parse((sender as Label).Name);
                this.Controls.Add(Lab[i]);
            }



            NumBtn = new Button[4];
            x = 10; y = 125;
            for (int i = 0; i < 4; i++)
            {
                if (i % 2 == 0)
                {
                    x = 10;
                    y += 33;
                }
                NumBtn[i] = new Button()
                {
                    Text = (i + 1).ToString(),
                    Name = (i + 1).ToString(),
                    Size = new Size(50, 23),
                    Location = new Point(x, y)
                };
                NumBtn[i].Click += (sender, e) =>
                {
                    try
                    {
                        Lab[SelectedBox].Text = (sender as Button).Name;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("尚未選取方格!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };
                x += 60;
                this.Controls.Add(NumBtn[i]);
            }
        }

        private void Reset()
        {
            for (int i = 0; i < 16; i++)
            {
                switch (i)
                {
                    case 0:
                        Lab[i].Text = "1";
                        break;
                    case 5:
                        Lab[i].Text = "2";
                        break;
                    case 10:
                        Lab[i].Text = "3";
                        break;
                    case 15:
                        Lab[i].Text = "4";
                        break;
                    default:
                        Lab[i].Text = "";
                        break;
                }
                SelectedBox = -1;
            }
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                int Sum = 0;
                for (int j = 0; j < 4; j++)
                    Sum += int.Parse(Lab[(j * 4) + i].Text);
                if (Sum != 10)
                {
                    ResLab.Text = "錯誤";
                    Console.WriteLine("Wrong on column {0}, sum: {1}", i, Sum);
                    return;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                int Sum = 0;
                for (int j = 0; j < 4; j++)
                    Sum += int.Parse(Lab[j + (i * 4)].Text);
                if (Sum != 10)
                {
                    ResLab.Text = "錯誤";
                    Console.WriteLine("Wrong on row {0}, sum: {1}", i, Sum);
                    return;
                }
            }

            int[] Header = new int[] { 0, 2, 8, 10 };
            for (int i = 0; i < 4; i++)
            {
                int Sum = 0;
                Sum += int.Parse(Lab[Header[i]].Text);
                Sum += int.Parse(Lab[Header[i] + 1].Text);
                Sum += int.Parse(Lab[Header[i] + 4].Text);
                Sum += int.Parse(Lab[Header[i] + 5].Text);
                if (Sum != 10)
                {
                    ResLab.Text = "錯誤";
                    Console.WriteLine("Wrong on block {0}, sum: {1}", i, Sum);
                    return;
                }
            }
        }

        private void HintBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
