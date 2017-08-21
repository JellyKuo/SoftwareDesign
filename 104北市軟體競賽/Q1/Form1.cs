using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button[] btn = new Button[9];

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 10, y = 10;
            for(int i = 0;i < 9; i++)
            {
                btn[i] = new Button()
                {
                    Name = "btn" + i.ToString(),
                    Size = new Size(50, 50),
                    Location = new Point(x,y),
                    Tag = i
                };
                x += 60;
                if(x>=190)
                {
                    y += 60;
                    x = 10;
                }
                btn[i].Click += BtnClick;
                panel1.Controls.Add(btn[i]);
            }
        }

        private void BtnClick(object sender,EventArgs e)
        {
            var S = sender as Button;
            S.Enabled = false;
            var ID = (int)S.Tag;
            Check();

        }

        private void Check()
        {
            //TODO: Check
        }
    }
}
