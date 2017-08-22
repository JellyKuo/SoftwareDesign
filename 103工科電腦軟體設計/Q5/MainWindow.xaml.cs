using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Q5
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenBtn_Click(object sender, RoutedEventArgs e)
        {
            List<string> Result = new List<string>();
            if (StartBox.Text != "" && EndBox.Text != "")
                RegGen(int.Parse(StartBox.Text), int.Parse(EndBox.Text), ref Result);
            if (IndBox.Text != "")
                IndGen(IndBox.Text, ref Result);
            foreach (string s in Result)
            {
                OutBox.Text += s + "@antu.edu.tw;";
            }
            OutBox.Text.Remove(OutBox.Text.Length - 1, 1);
        }

        private void RegGen(int Start, int End, ref List<string> Result)
        {
            int ID = Start;
            while (ID <= End)
            {
                Result.Add(ID.ToString() + GetChecksum(ID).ToString());
                ID += 1;
            }
        }

        private void IndGen(string Inp, ref List<string> Result)
        {

            string CurrentID = "";
            foreach (char c in Inp)
            {
                if (c == ',' || c == ' ')
                {
                    if (CurrentID.Length == 8)
                    {
                        Result.Add(CurrentID + GetChecksum(int.Parse(CurrentID)).ToString());
                    }
                    CurrentID = "";
                }
                else
                    CurrentID += c;
            }
            if (CurrentID != "")
                Result.Add(CurrentID + GetChecksum(int.Parse(CurrentID)).ToString());
        }

        private int GetChecksum(int ID)
        {
            string IDstr = ID.ToString();
            int Sum = 0;
            for (int i = 0; i < 8; i++)
            {
                Sum += (IDstr[i] - 48) * (i + 1);
            }
            //Need Optimize
            switch (Sum % 10)
            {
                case 0:
                    return 0;
                case 1:
                    return 7;
                case 2:
                    return 4;
                case 3:
                    return 1;
                case 4:
                    return 8;
                case 5:
                    return 5;
                case 6:
                    return 2;
                case 7:
                    return 9;
                case 8:
                    return 6;
                case 9:
                    return 3;
            }
            throw new Exception();
        }
    }
}
