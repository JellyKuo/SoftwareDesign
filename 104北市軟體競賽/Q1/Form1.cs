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

        bool Turn = true;

        private void BtnClick(object sender, EventArgs e)
        {
            #region 符號判斷
            int[] Code = new int[2];
            Code[0] = textBox1.Text[0];
            Code[1] = textBox2.Text[0];
            if ((Code[0] > 90 || Code[0] < 65) && (Code[0] > 122 || Code[0] < 97))
            {
                MessageBox.Show("輸入的符號無效");
                return;
            }
            if ((Code[1] > 90 || Code[1] < 65) && (Code[1] > 122 || Code[1] < 97))
            {
                MessageBox.Show("輸入的符號無效");
                return;
            }
            #endregion
            #region Set Value
            var S = sender as Button;
            S.Enabled = false;
            S.Text = (Turn) ? textBox1.Text : textBox2.Text;
            Turn = !Turn;
            #endregion
            #region Win

            #endregion

        }
       
    }
}
