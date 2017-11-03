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

namespace Q1_自訂符號井字遊戲
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Generate();
        }

        Button[,] Btn = new Button[3, 3];
        enum Players { A, B }
        Players Turn = Players.A;
        Players?[,] Board = new Players?[3, 3];

        class Pos
        {
            public int Col { get; set; }
            public int Row { get; set; }
            public Pos(int Col, int Row)
            {
                this.Col = Col;
                this.Row = Row;
            }
        }

        private void Generate()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Btn[j, i] = new Button()
                    {
                        Tag = new Pos(j, i),
                        Padding = new Thickness(10, 0, 0, 10)
                    };
                    Btn[j, i].Click += BtnClick;
                    GameGrid.Children.Add(Btn[j, i]);
                    Grid.SetColumn(Btn[j, i], j);
                    Grid.SetRow(Btn[j, i], i);
                }
            }
        }

        private void BtnClick(object sender, RoutedEventArgs e)
        {
            var Btn = sender as Button;
            var Tag = Btn.Tag as Pos;
            if (!CheckSymbol())
                return;
            if (Turn == Players.A)
            {
                Btn.Content = ABox.Text;
                Board[Tag.Col, Tag.Row] = Players.A;
                Turn = Players.B;
            }
            else
            {
                Btn.Content = BBox.Text;
                Board[Tag.Col, Tag.Row] = Players.B;
                Turn = Players.A;
            }
            try
            {
                var res = CheckMatch();
                if (res.HasValue)
                    MessageBox.Show(res.Value.ToString() + "Has Won");
                else
                    MessageBox.Show("Tie");
            }
            catch { }
        }

        private Players? CheckMatch()
        {
            //Brute force <3
            var P = Players.A;
            for (int i = 0; i < 2; i++)
            {
                if (Board[0, 0] == P && Board[1, 0] == P && Board[2, 0] == P)
                    return P;
                if (Board[0, 1] == P && Board[1, 1] == P && Board[2, 1] == P)
                    return P;
                if (Board[0, 2] == P && Board[1, 2] == P && Board[2, 2] == P)
                    return P;

                if (Board[0, 0] == P && Board[0, 1] == P && Board[0, 2] == P)
                    return P;
                if (Board[1, 0] == P && Board[1, 1] == P && Board[1, 2] == P)
                    return P;
                if (Board[2, 0] == P && Board[2, 1] == P && Board[2, 2] == P)
                    return P;

                if (Board[0, 0] == P && Board[1, 1] == P && Board[2, 2] == P)
                    return P;
                if (Board[2, 0] == P && Board[1, 1] == P && Board[0, 2] == P)
                    return P;

                P = Players.B;
            }
            foreach (var b in Board)
            {
                if (b==null)
                    throw new Exception("Match not finished");
            }
            return null;

        }

        private bool CheckSymbol()
        {
            var AName = ABox.Text; var BName = BBox.Text;
            var Names = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            if (AName.Length > 1 || AName.Length <= 0 || !Names.Contains(AName))
            {
                MessageBox.Show("輸入的符號無效");
                return false;
            }
            if (BName.Length > 1 || BName.Length <= 0 || !Names.Contains(BName))
            {
                MessageBox.Show("輸入的符號無效");
                return false;
            }
            return true;
        }
    }

}