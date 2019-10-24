using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace DoSomething
{
    class FuncPractice : FuncContent
    {
        public void Demo()
        {
            Func<int, int, int> method = GetByPara01;
            method += GetOByPara01;
            WriteLine(method(1, 1));

            Func<int, int, int> method02 = delegate (int a, int b)
            {
                return this.GetOByPara01(a, b);
            };
            WriteLine(method02(1, 1));

            Func<int, int, int> method03 = (int a, int b) => GetByPara01(a, b);
            WriteLine(method03.Invoke(1 ,1));
        }

        public int GetByPara01(int a, int b)
        {
            return a + b;
        }
    }

    class FuncContent
    {
        public int GetOByPara01(int a, int b)
        {
            return a + b + 2;
        }
    }
}
