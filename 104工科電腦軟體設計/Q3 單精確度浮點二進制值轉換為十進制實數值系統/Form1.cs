using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void ConBtn_Click(object sender, EventArgs e)
        {
            if (signBox.Text == "1")
                resBox.Text = "-";
            else
                resBox.Text = "";
            int Exponent = Convert.ToInt32(exponentBox.Text, 2) - 127;
            string AfterDecimal = mantissaBox.Text.Substring(Exponent);
            string BeforeDecimal = "1"+mantissaBox.Text.Substring(0, mantissaBox.Text.Length - AfterDecimal.Length);
            double x = Convert.ToInt32(BeforeDecimal, 2);
            double y = 0;
            for(int i = 0; i < AfterDecimal.Length; i++)
            {
                if (AfterDecimal[i] == '1')
                    y += Math.Pow(2,(i+1)*-1);
            }
            resBox.Text += (x + y).ToString();
        }

        private void RndBtn_Click(object sender, EventArgs e)
        {
            signBox.Text = "";
            exponentBox.Text = "";
            mantissaBox.Text = "";
            resBox.Text = "";

            Random rnd = new Random();
            signBox.Text = rnd.Next(0, 2).ToString();
            for (int i = 0; i < 8; i++)
                exponentBox.Text += rnd.Next(0, 2).ToString();
            for (int i = 0; i < 22; i++)
                mantissaBox.Text += rnd.Next(0, 2).ToString();
        }
    }
}
