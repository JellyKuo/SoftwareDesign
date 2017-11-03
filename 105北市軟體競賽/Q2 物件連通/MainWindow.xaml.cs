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

namespace Q2_物件連通
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
                var Ofd = new Microsoft.Win32.OpenFileDialog()
                {
                    Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*",
                    CheckFileExists = true
                };
                if (Ofd.ShowDialog().Value != true)
                    return;
                var Path = Ofd.FileName;


            };
        }
    }
}
