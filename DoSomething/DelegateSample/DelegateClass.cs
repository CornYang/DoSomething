using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{
    class DelegateClass
    {
        public delegate void DoFunction();
        public delegate void DoFunction2(string a);
        delegate void SumFunction();
        delegate int IntMethod();

        public void DisplayDelegate()
        {
            //delegate的基本操作

            DoFunction doFunction = Show;
            doFunction.Invoke(); // 可用Invoke來呼叫其委派的所有方法
            doFunction(); // 也可以直接呼叫其委派的所有方法

            DoFunction2 doFunction2 = ShowText;
            doFunction2.Invoke("CORN");
            doFunction2("CORN");

            // 委派呼叫多個方法
            doFunction = Show;
            doFunction += Show2;
            doFunction();

            DoFunction2 doFunction21 = ShowText2;
            // 可以利用一個委派將其他委派運用一起使用(可加多個("+")，也可以刪除("-"))
            DoFunction2 sumfunction = doFunction2 + doFunction21; 
            sumfunction.Invoke("Hello Corn!!");
            Console.WriteLine("------------------------------------------------------------------");

            //將delegate當參數傳遞
            DelegateClass02 delegateClass02 = new DelegateClass02();
            DelegateClass02.ShowDelegateObj obj = ShowText;
            delegateClass02.DoAction(obj, "Hi Corn!!");
            Console.WriteLine("------------------------------------------------------------------");

            IntMethod method = Method01;
            method += Method02;
            method += Method03;
            Console.WriteLine($"{method()}");

            foreach (var item in method.GetInvocationList()) //GetInvocationList會將多個方法串成清單
            {
                // DynamicInvoke為取得目前委派的方法
                Console.WriteLine(item.DynamicInvoke());
            }
        }

        public void Show()
        {
            Console.WriteLine("HelloWord!!");
        }

        public void Show2()
        {
            Console.WriteLine("HelloWord2!!");
        }

        public void ShowText(string text)
        {
            Console.WriteLine($"{text}");
        }

        public void ShowText2(string text)
        {
            Console.WriteLine($"{text}2");
        }

        public int Method01() { return 1; }
        public int Method02() { return 2; }
        public int Method03() { return 3; }
    }

    class DelegateClass02
    {
        public delegate void ShowDelegateObj(string text);

        public void DoAction(ShowDelegateObj action, string text)
        {
            // 兩種寫法都可以
            action(text);
            //action.Invoke(text);
        }
    }
}
