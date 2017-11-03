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
using Coordinate;

namespace Q1_總和面積表
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ReadBtn.Click += (sender, e) =>
            {
                var ofd = new Microsoft.Win32.OpenFileDialog
                {
                    Filter = "文字檔(*.txt)|*.txt"
                };
                if (!ofd.ShowDialog().Value)
                    return;
                var Data = System.IO.File.ReadAllText(@ofd.FileName);
                SrcBox.Text = Data;
            };
        }

        int[][] Sum,Data;

        private void CalcBtn_Click(object sender, RoutedEventArgs e)
        {
            var Inp = SrcBox.Text;

            var Lines = Inp.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            Data = new int[Lines.Length][];
            for (int y = 0; y < Lines.Length; y++)
            {
                var Cell = Lines[y].Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
                Data[y] = new int[Cell.Length];
                for (int x = 0; x < Cell.Length; x++)
                {
                    Data[y][x] = int.Parse(Cell[x]);
                }
            }

            Sum = new int[Data.Length][];
            for(int y = 0; y < Data.Length; y++)
            {
                Sum[y] = new int[Data[y].Length];
                for(int x = 0; x < Data[y].Length; x++)
                {
                    for(int i = 0; i <= y; i++)
                    {
                        for(int j = 0; j <= x; j++)
                        {
                            Sum[y][x] += Data[i][j];
                        }
                    }
                }
            }
            var sb = new StringBuilder();
            foreach (var Row in Sum)
            {
                foreach (var Cell in Row)
                {
                    sb.Append('\t');
                    sb.Append(Cell.ToString());
                }
                sb.AppendLine();
            }
            ResBox.Text = sb.ToString();
        }

        private void AvgBtn_Click(object sender, RoutedEventArgs e)
        {
            var P1 = new Pos(int.Parse(P1XBox.Text) - 1, int.Parse(P1YBox.Text) - 1);
            var P2 = new Pos(int.Parse(P2XBox.Text) - 1, int.Parse(P2YBox.Text) - 1);
            var S = Sum[P2.Y][P2.X] - Sum[P1.Y - 1][P2.X] - Sum[P2.Y][P1.X - 1] + Sum[P1.Y - 1][P1.X - 1];
            var Res = (double)S / ((P2.X - P1.X+1) * (P2.Y-P1.Y+1));
            AvgBox.Text = Res.ToString();
        }

        private void SumBtn_Click(object sender, RoutedEventArgs e)
        {
            var P1 = new Pos(int.Parse(P1XBox.Text)-1, int.Parse(P1YBox.Text)-1);
            var P2 = new Pos(int.Parse(P2XBox.Text)-1, int.Parse(P2YBox.Text)-1);
            var Res = Sum[P2.Y][P2.X] - Sum[P1.Y - 1][P2.X] - Sum[P2.Y][P1.X - 1] + Sum[P1.Y - 1][P1.X - 1];
            SumBox.Text = Res.ToString();
        }

    }
}
