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

namespace Q4_四則運算機
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

        private void BtnClick(object sender, RoutedEventArgs e)
        {
            var BtnConStr = (sender as Button).Content as string;
            if (BtnConStr != "執行")
                CalcBox.Text += BtnConStr;
            else
                Calculate();
        }

        private void Calculate()
        {
            var InpStr = CalcBox.Text;
            if (!CheckInput(InpStr))
            {
                MessageBox.Show("運算式有誤!", "錯誤", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            GenPostfix(InpStr);
        }

        private List<string> GenPostfix(string Input)
        {
            var Res = new List<string>();
            var Ope = new Stack<char>();
            bool IsPriority = false;
            var Num = "";
            foreach (char c in Input)
            {
                if ((c >= 48 && c <= 57) || c == '.')  //Number
                {
                    Num += c;
                    continue;
                }
                if (Num != "")
                {
                    Res.Add(Num);
                    Num = "";
                }
                switch (c)
                {
                    case '+':
                    case '-':
                        Ope.Push(c);
                        if (IsPriority)
                        {
                            while (Ope.Count > 0 && Ope.Peek() != '(')
                                Res.Add(Ope.Pop().ToString());
                        }
                        break;
                    case '(':
                        Ope.Push(c);
                        break;
                    case '*':
                    case '/':
                        Ope.Push(c);
                        IsPriority = true;
                        break;
                    case ')':
                        while (Ope.Peek() != '(')
                            Res.Add(Ope.Pop().ToString());
                        Ope.Pop();
                        break;
                }
            }
            if (Num != "")
                Res.Add(Num);
            while (Ope.Count > 0)
                Res.Add(Ope.Pop().ToString());

            return Res;
        }

        /// <summary>
        /// 判斷輸入是否符合四則運算所要求的原則
        /// <para>此方法可維護性極低。如果他沒壞，不要碰她</para>
        /// </summary>
        /// <param name="Input">欲檢查之字串</param>
        /// <returns></returns>
        private bool CheckInput(string Input)
        {
            uint BracketCount = 0;
            var IsOp = false;
            var IsBracket = false;
            foreach (char c in Input)
            {
                if (IsOp)
                    if (c == '.' || c == '+' || c == '-' || c == '*' || c == '/')
                        return false;
                if (IsBracket)
                    if (c == '.')
                        return false;
                switch (c)
                {
                    case '(':
                        BracketCount++;
                        IsBracket = true;
                        IsOp = false;
                        break;
                    case ')':
                        BracketCount--;
                        IsBracket = true;
                        IsOp = false;
                        break;
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                    case '.':
                        IsOp = true;
                        IsBracket = false;
                        break;
                    default:
                        if (c < 48 || c > 57)
                            return false;
                        IsOp = false;
                        IsBracket = false;
                        break;
                }
                if (BracketCount < 0)
                    return false;
            }
            if (BracketCount != 0)
                return false;
            if (IsOp)
                return false;
            return true;
        }
    }
}
