using System;
using System.Collections.Generic;
using static System.Console;
using static DoSomething.QuickSort;

namespace DoSomething
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteLine("Hello World!");

            //DelegatePractice delegatePractice = new DelegatePractice();
            //delegatePractice.Demo01();

            //ActionPractice actionPractice = new ActionPractice();
            //actionPractice.Demo01();

            //FuncPractice funcPractice = new FuncPractice();
            //funcPractice.Demo();

            //QuickSort quickSort = new QuickSort();
            //quickSort.Demo02();

            List<int> list = new List<int>() { 33, 4, 69, 1, 51, 100, 99, 13, 15, 56};
            Action action = () => QuickSortDemo01(() => Demo03(list));
            action();
        }
    }
}
