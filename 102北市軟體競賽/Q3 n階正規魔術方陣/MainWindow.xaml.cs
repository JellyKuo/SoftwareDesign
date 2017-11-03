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

namespace Q3_n階正規魔術方陣
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

        private void ExeBtn_Click(object sender, RoutedEventArgs e)
        {
            ResGrid.Children.Clear();
            var N = int.Parse(NBox.Text);
            if (N % 2 != 1)
            {
                StatBox.Text = "錯誤";
                return;
            }
            var Mtx = new int[N, N];
            Mtx[N/2, 0] = 1;
            AddNum(new Pos((N/2), 0), 2, N, ref Mtx);
            StatBox.Text = "成功";
            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    var TB = new TextBlock()
                    {
                        Text = Mtx[j, i].ToString(),
                        Padding = new Thickness(10 + j * 50, 10 + i * 50, 0, 0),
                        FontSize = 18
                    };
                    ResGrid.Children.Add(TB);
                }
            }
        }
        
        /// <summary>
        /// 將數字加入方陣
        /// </summary>
        /// <param name="P">上一次加入的點的座標</param>
        /// <param name="Num">這次執行時須加入的數值</param>
        /// <param name="N">方陣階數</param>
        /// <param name="Mtx">代表方陣的二維int陣列，以第0個維度為X，第1個維度為Y</param>
        private void AddNum(Pos P, int Num, int N, ref int[,] Mtx)
        {
            if (Num == N * N+1)
                return;
            int X, Y;
            if (P.X == 0)
                X = N - 1;
            else
                X = P.X - 1;
            if (P.Y == 0)
                Y = N - 1;
            else
                Y = P.Y - 1;

            if (Mtx[X, Y] != 0)
            {
                if (P.Y == N - 1)
                {
                    X = P.X;
                    Y = 0;
                }
                else
                {
                    X = P.X;
                    Y = P.Y + 1;
                }
            }
            Mtx[X, Y] = Num;
            AddNum(new Pos(X, Y), Num + 1, N, ref Mtx);
        }
    }

}
