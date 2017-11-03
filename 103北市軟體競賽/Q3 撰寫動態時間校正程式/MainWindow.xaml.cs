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

namespace Q3_撰寫動態時間校正程式
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

        private void CalcBtn_Click(object sender, RoutedEventArgs e)
        {
            var FStrArr = FirValBox.Text.Split(',');
            var SStrArr = SecValBox.Text.Split(',');
            var First = new List<int>();
            var Second = new List<int>();
            for (int i = 0; i < FStrArr.Length; i++)
                if (FStrArr[i] != "")
                    First.Add(int.Parse(FStrArr[i]));
            for (int i = 0; i < SStrArr.Length; i++)
                if (SStrArr[i] != "")
                    Second.Add(int.Parse(SStrArr[i]));

            var Result = new int[First.Count, Second.Count];

            for (int i = 0; i < First.Count; i++)
            {
                for (int j = 0; j < Second.Count; j++)
                {
                    if (i == 0 && j == 0)
                        Result[i, j] = Math.Abs(First[i] - Second[j]);
                    else if (i == 0 && j > 0)
                        Result[i, j] = Math.Abs(First[i] - Second[j]) + Result[i, j - 1];
                    else if (i > 0 && j == 0)
                        Result[i, j] = Math.Abs(First[i] - Second[j]) + Result[i - 1, j];
                    else
                    {
                        var TriPt = new int[] { Result[i - 1, j], Result[i - 1, j - 1], Result[i, j - 1] };
                        Result[i, j] = Math.Abs(First[i] - Second[j]) + TriPt.Min() ;
                    }
                }
            }


            var sb = new StringBuilder();
            sb.Append("0\t");
            foreach (var Num in First)
            {
                sb.Append(Num);
                sb.Append('\t');
            }
            sb.AppendLine();
            for (int i = 0; i <Result.GetLength(1) ; i++)
            {
                sb.Append(Second[i]);
                sb.Append('\t');
                for (int j = 0; j < Result.GetLength(0); j++)
                {
                    sb.Append(Result[j,i]);
                    sb.Append('\t');
                }
                sb.AppendLine();
            }
            ResBox.Text = sb.ToString();
        }
    }
}
