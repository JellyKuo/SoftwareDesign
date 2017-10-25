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

        private void Generate()
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Btn[i, j] = new Button()
                    {
                        Tag = new { Col=i,Row=j},
                        Padding = new Thickness(10,0,0,10)
                    };
                    GameGrid.Children.Add(Btn[i, j]);
                    Grid.SetColumn(Btn[i, j], i);
                    Grid.SetRow(Btn[i, j], j);
                }
            }
        }
    }
}
