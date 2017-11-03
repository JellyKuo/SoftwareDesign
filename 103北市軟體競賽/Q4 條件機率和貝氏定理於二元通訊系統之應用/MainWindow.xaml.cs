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

namespace Q4_條件機率和貝氏定理於二元通訊系統之應用
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ExitBtn.Click += (sender, e) => Environment.Exit(0);
        }

        private void Q1Btn_Click(object sender, RoutedEventArgs e)
        {
            if(!CheckData())
            {
                AnsBox.Text = "無解";
                return;
            }
            var ZerPro = double.Parse(ZerProBox.Text);
            var OnePro = double.Parse(OneProBox.Text);
            var ZerErr = double.Parse(ZerErrBox.Text);
            var OneErr = double.Parse(OneErrBox.Text);

            var OutOne = OnePro * (1 - OneErr) + ZerPro * ZerErr;
            AnsBox.Text = "通道輸出為 1 的機率為" + OutOne.ToString();
        }

        private void Q2Btn_Click(object sender, RoutedEventArgs e)
        {
            if (!CheckData())
            {
                AnsBox.Text = "無解";
                return;
            }
            var ZerPro = double.Parse(ZerProBox.Text);
            var OnePro = double.Parse(OneProBox.Text);
            var ZerErr = double.Parse(ZerErrBox.Text);
            var OneErr = double.Parse(OneErrBox.Text);

            var OutOne = OnePro * (1 - OneErr) + ZerPro * ZerErr;
            var P = 1-(ZerPro * ZerErr / OutOne);
            AnsBox.Text = "假設我們已經觀察到通道輸出為 1，這時候通道的輸入為 1 的機率為" + P.ToString();
        }

        private bool CheckData()
        {
            try
            {
                var OnePro = double.Parse(OneProBox.Text);
                var ZerPro = double.Parse(ZerProBox.Text);
                if (OnePro < 0 || ZerPro < 0 || OnePro > 1 || ZerPro > 1 || OnePro + ZerPro != 1)
                    return false;
                var ZerErr = double.Parse(ZerErrBox.Text);
                var OneErr = double.Parse(OneErrBox.Text);
                if (ZerErr < 0 || ZerErr > 1)
                    return false;
                if (OneErr < 0 || OneErr > 1)
                    return false;
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
    }
}
