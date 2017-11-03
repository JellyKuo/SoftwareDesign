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

namespace Q4_誤差擴散法
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
                    Filter = "所有檔案 (*.*)|*.*"
                };
                if (!ofd.ShowDialog().Value)
                    return;
                PathBox.Text = ofd.FileName;
                SrcBox.Text = System.IO.File.ReadAllText(@ofd.FileName);
            };
        }

        private void ExeBtn_Click(object sender, RoutedEventArgs e)
        {
            var SStr = SrcBox.Text;
            var Lines = SStr.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            var Data = new int[Lines.Length][];
            for (int i = 0; i < Lines.Length; i++)
            {
                var Line = Lines[i];
                var Obj = Line.Split(new string[] { "_" }, StringSplitOptions.RemoveEmptyEntries);
                Data[i] = new int[Obj.Length];
                for (int j = 0; j < Obj.Length; j++)
                    Data[i][j] = int.Parse(Obj[j]);
            }
            for (int y = 0; y < Data.Length; y++)
            {
                for (int x = 0; x < Data[y].Length; x++)
                {
                    int Err = 0;
                    if (Data[y][x] > 128)
                    {
                        Err = Data[y][x] - 255;
                        Data[y][x] = 255;
                    }
                    else
                    {
                        Err = Data[y][x];
                        Data[y][x] = 0;
                    }
                    if (x + 1 < Data[y].Length)
                        Data[y][x + 1] += Err * 7 / 16;
                    if (x + 1 < Data[y].Length&&y+1<Data.Length)
                        Data[y + 1][x + 1] += Err * 1 / 16;
                    if(y+1<Data.Length)
                    Data[y + 1][x] += Err * 5 / 16;
                    if(y+1<Data.Length&&x-1>=0)
                    Data[y + 1][x - 1] += Err * 3 / 16;
                }
            }
            StringBuilder sb = new StringBuilder();
            foreach(var Row in Data)
            {
                foreach(var Cell in Row)
                    sb.Append(Cell.ToString().PadLeft(4, '_'));
                sb.AppendLine();
            }
            ResBox.Text = sb.ToString();
        }
    }
}
