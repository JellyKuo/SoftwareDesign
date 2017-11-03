using System;
using System.Collections.Generic;
using System.IO;
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

namespace Q1_水果銷售分析程式
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OpenBtn.Click += (sender, e) =>
            {
                var ofd = new Microsoft.Win32.OpenFileDialog()
                {
                    Filter = "Text File (*.txt)|*.txt"
                };
                if (!ofd.ShowDialog().Value)
                    return;
                ReadFile(ofd.FileName);
            };
        }

        private void ReadFile(string @Path)
        {
            var Lines = File.ReadAllLines(Path);
            var Fruits = new List<string>();
            var Count = new List<int>();
            foreach(var Line in Lines)
            {
                var F = Line.Split('、');
                foreach(var Fruit in F)
                {
                    if (!Fruits.Contains(Fruit))
                    {
                        Fruits.Add(Fruit);
                        Count.Add(1);
                    }
                    var Ind = Fruits.IndexOf(Fruit);
                    Count[Ind]++;
                }
            }
            var FArr = Fruits.ToArray();
            var CArr = Count.ToArray();
            CArr.Reverse();
            Array.Sort(CArr, FArr);
            //FArr.Reverse();
            FirTxt.Text = FArr[0];
            SecTxt.Text = FArr[1];
            TrdTxt.Text = FArr[2];
            FthTxt.Text = FArr[3];
            LstTxt.Text = FArr.Last();
        }
    }
}
