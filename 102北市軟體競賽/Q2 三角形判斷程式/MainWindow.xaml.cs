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

namespace Q2_三角形判斷程式
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
            var P1 = new Pos(double.Parse(P1XBox.Text), double.Parse(P1YBox.Text));
            var P2 = new Pos(double.Parse(P2XBox.Text), double.Parse(P2YBox.Text));
            var P3 = new Pos(double.Parse(P3XBox.Text), double.Parse(P3YBox.Text));
            var P1P2L = Pos.GetDistance(P1, P2);
            var P2P3L = Pos.GetDistance(P2, P3);
            var P3P1L = Pos.GetDistance(P3, P1);
            P1P2Box.Text = P1P2L.ToString();
            P2P3Box.Text = P2P3L.ToString();
            P3P1Box.Text = P3P1L.ToString();
        }
    }

    public class Pos
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Pos(double X,double Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public static double GetDistance(Pos P1,Pos P2)
        {
            var XS = Math.Pow(P1.X - P2.X, 2);
            var YS = Math.Pow(P1.Y - P2.Y, 2);
            return Math.Round(Math.Sqrt(XS + YS),3);
        }
    }
}
