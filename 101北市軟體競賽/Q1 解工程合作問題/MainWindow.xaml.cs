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

namespace Q1_解工程合作問題
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ExtBtn.Click += (sender, e) => Environment.Exit(0);
        }

        private void ExeBtn_Click(object sender, RoutedEventArgs e)
        {
            var AllTog = int.Parse(N1Box.Text);
            var FirTog = int.Parse(N2Box.Text);
            var ASin = int.Parse(N3Box.Text);
            var BSin = int.Parse(N4Box.Text);

        }
    }
}
