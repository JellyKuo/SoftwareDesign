using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        #region DEBUG
        [System.Diagnostics.Conditional("DEBUG")]
        private void Write(object Msg)
        {
            Console.WriteLine(Msg);
        }

        [System.Diagnostics.Conditional("DEBUG")]
        private void TestData()
        {
            InpBox.Text = "LEE\r\nKUHNE\r\nEBELL\r\nEBELSON\r\nSCHAEFER\r\nSCHAAK";
        }

        #endregion
        public Form1()
        {
            InitializeComponent();
            TestData();
        }

        private void Convert(object sender, EventArgs e)
        {
            OutBox.Text = string.Empty;
            string[] Input = InpBox.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb;
            foreach (string Entry in Input)
            {
                sb = new StringBuilder();
                char? StartCode = Encode(Entry[0]);
                bool Separator = false;
                sb.Append(Entry[0]);
                for (int i = 1; i < Entry.Length; i++)
                {
                    if (sb.Length >= 4)
                        break;
                    char? Result = Encode(Entry[i]);
                    if (Result.HasValue)
                    {
                        if (i == 1 && Result == StartCode)
                        {
                            Separator = true;
                            continue;
                        }
                        if (Result == sb[sb.Length - 1] && !Separator)
                        {
                            Separator = true;
                            continue;
                        }
                        sb.Append(Result.Value);
                        Separator = false;
                    }
                    else
                    {
                        Separator = true;
                        continue;
                    }
                }
                while (sb.Length < 4)
                    sb.Append("0");
                sb.AppendLine();
                OutBox.Text += sb.ToString();
            }
        }

        private char? Encode(char c)
        {
            if ("AEIOUYWH".Contains(c))
                return null;
            else if ("BPFV".Contains(c))
                return '1';
            else if ("CSKGJQXZ".Contains(c))
                return '2';
            else if ("DT".Contains(c))
                return '3';
            else if ('L' == c)
                return '4';
            else if ("MN".Contains(c))
                return '5';
            else if ('R' == c)
                return '6';
            else
                throw new FormatException("Input \"" + c + "\" cannot be encoded!");
        }
    }
}
