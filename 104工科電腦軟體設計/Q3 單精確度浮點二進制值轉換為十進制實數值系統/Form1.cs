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


        #region Calculate Solution
        //--Bugged when exponent is below 0 after removing 127--
        /*
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
        */
        #endregion

        #region Byte Array Cast Solution
        //史上最好的解法 :)
        private void ConBtn_Click(object sender, EventArgs e)
        {
            string InputStr = signBox.Text + exponentBox.Text + mantissaBox.Text;  //組合為長32的字串
            byte[] Bytes = new byte[4];  //宣告4個byte的陣列，32 bits
            for (int i = 0; i < 4; i++)  //重複4次 (4個byte)
                Bytes[3 - i] = Convert.ToByte(InputStr.Substring(8 * i, 8), 2);  //把字串的值經過轉換為byte，填入陣列
            Single Result = BitConverter.ToSingle(Bytes, 0);  //宣告一個Single，把byte陣列轉型填入
            resBox.Text = Result.ToString();  //顯示結果
        }
        #endregion

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
            for (int i = 0; i < 23; i++)
                mantissaBox.Text += rnd.Next(0, 2).ToString();
        }
    }
}
