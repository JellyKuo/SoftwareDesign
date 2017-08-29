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

namespace Q2_大數計算機
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

        public const int Len = 200;

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            BoxA.Text = "";
            BoxB.Text = "";
            ResBox.Text = "";
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            var Btn = sender as Button;
            var A = new char[Len];
            var B = new char[Len];
            for(int i = 0; i < BoxA.Text.Length; i++)
            {
                A[BoxA.Text.Length-1 - i] = BoxA.Text[i];
            }
            for (int i = 0; i < BoxB.Text.Length; i++)
            {
                B[BoxB.Text.Length - 1 - i] = BoxB.Text[i];
            }
            char[] Result = null ;
            switch (Btn.Name)
            {
                case "PlusBtn":
                    Result = Plus(A, B);
                    break;
                case "SubBtn":
                    break;
                case "MutBtn":
                    break;
            }
            Array.Reverse(Result);
            ResBox.Text = new string(Result);
        }

        private char[] Plus(char[] A,char[] B)
        {
            var Result = new char[Len];
            for(int i = 0; i< Len; i++)
            {
                if (A[i] == 0)
                    A[i] = (char)48;
                if (B[i] == 0)
                    B[i] = (char)48;
                Result[i] = (char)(A[i] + B[i] - 48);
            }
            return Result;
        }
    }
}
