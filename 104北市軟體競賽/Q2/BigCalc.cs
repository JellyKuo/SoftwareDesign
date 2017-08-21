using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class BigCalc
    {
        public const int Len = 200;

        public char?[] InpA { get; }
        public char?[] InpB { get; }

        private StringBuilder sb = new StringBuilder();
        private int?[] Res = new int?[Len];

        public BigCalc(string A, string B)
        {
            InpA = new char?[Len];
            InpB = new char?[Len];
            for (int i = 0; i < A.Length; i++)
            {
                InpA[i] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                InpB[i] = B[i];
            }
        }

        public string Add()
        {
            for (int i = 0; i < Len; i++)
            {
                Res[i] = InpA[i] + InpB[i] - 96;
                if (Res[i] >= 10)
                {
                    Res[i - 1] += 1;
                    Res[i] = Res[i] % 10;
                }
                if (Res[i].HasValue)
                    sb.Append(Res[i]);
            }

            return sb.ToString();
        }

        public string Subtract()
        {
            //TODO: Substract
            for(int i = 0; i < Len; i++)
            {

            }

            return sb.ToString();
        }
    }
}
