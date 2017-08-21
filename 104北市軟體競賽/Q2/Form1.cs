using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //public const int Len= 200;  //決定最打長度

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        #region Decimal
        /*
        private void AddBtn_Click(object sender, EventArgs e)
        {
            BigInteger a = new BigInteger(long.Parse(textBox1.Text));
            BigInteger b = new BigInteger(long.Parse(textBox2.Text));
            
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            decimal a = Decimal.Parse(textBox1.Text);
            decimal b = Decimal.Parse(textBox2.Text);
            textBox3.Text = (a - b).ToString();
        }

        private void StarBtn_Click(object sender, EventArgs e)
        {
            decimal a = Decimal.Parse(textBox1.Text);
            decimal b = Decimal.Parse(textBox2.Text);
            textBox3.Text = (a * b).ToString();
        }
        */
        #endregion

        #region Arr
        
        private void AddBtn_Click(object sender, EventArgs e)
        {
            BigCalc bc = new BigCalc(textBox1.Text, textBox2.Text);
            textBox3.Text = bc.Add();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            BigCalc bc = new BigCalc(textBox1.Text, textBox2.Text);
            textBox3.Text = bc.Subtract();
        }

        private void StarBtn_Click(object sender, EventArgs e)
        {

        }
        
        #endregion
    }
}
