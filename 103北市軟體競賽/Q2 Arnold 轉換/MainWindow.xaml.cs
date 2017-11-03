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

namespace Q2_Arnold_轉換
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Pos
        {
            public int X { get; set; }
            public int Y { get; set; }
            public bool IsConverted { get; set; }
            public Pos(int X, int Y)
            {
                this.X = X; this.Y = Y;
                IsConverted = false;
            }
        }
        Button[,] Btn = new Button[5, 5];
        private Pos SelectedPos = null;

        public MainWindow()
        {
            InitializeComponent();

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    Btn[x, y] = new Button()
                    {
                        Background = Brushes.White,
                        Content = "",
                        Padding = new Thickness(5),
                        Tag = new Pos(x, y)
                    };
                    Btn[x, y].Click += (sender, e) =>
                    {
                        var SBtn = sender as Button;
                        SelectedPos = SBtn.Tag as Pos;
                        Console.WriteLine("Grid clicked @ x:{0}, y:{1}", SelectedPos.X, SelectedPos.Y);
                    };
                    Grid.SetColumn(Btn[x, y], x);
                    Grid.SetRow(Btn[x, y], y);
                    BtnGrid.Children.Add(Btn[x, y]);
                }
            }

            SetWhBtn.Click += (sender, e) =>
                Btn[SelectedPos.X, SelectedPos.Y].Background = Brushes.White; ;
            SetBlkBtn.Click += (sender, e) =>
                Btn[SelectedPos.X, SelectedPos.Y].Background = Brushes.Black; ;
        }

        private void ExeBtn_Click(object sender, RoutedEventArgs e)
        {
            var NewGrid = new bool[5, 5];
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (Btn[x, y].Background == Brushes.White)
                        continue;
                    var P = Btn[x, y].Tag as Pos;
                    var NewX = (P.X * 1 + P.Y * 1) % 5;
                    var NewY = (P.X * 1 + P.Y * 2) % 5;
                    NewGrid[NewX, NewY] = true;
                }
            }
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (NewGrid[x, y])
                        Btn[x, y].Background = Brushes.Black;
                    else
                        Btn[x, y].Background = Brushes.White;
                }
            }
        }
    }
}
