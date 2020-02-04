using System;
using System.Collections.Generic;
using static System.Console;
using static DoSomething.QuickSort;
using static DoSomething.TXTLibrary;

namespace DoSomething
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteLine("Hello World!");

            //GetSetPractice getset = new GetSetPractice();
            //WriteLine(getset.TEST01);
            //getset.TEST01 = 200;
            //WriteLine(getset.TEST01);
            //WriteLine(getset.TEST02);
            //getset.TEST03 = 500;
            //WriteLine(getset.TEST02);

            //DelegatePractice delegatePractice = new DelegatePractice();
            //delegatePractice.Demo01();

            //ActionPractice actionPractice = new ActionPractice();
            //actionPractice.Demo01();

            //FuncPractice funcPractice = new FuncPractice();
            //funcPractice.Demo();

            //QuickSort quickSort = new QuickSort();
            //quickSort.Demo02();

            //List<int> list = new List<int>() { 85, 24 , 53 , 2 , 16};
            //Action action = () => QuickSortDemo01(() => Demo03(list));
            //action();

            TEST test = new TEST();
            test.Content();
            Interface.IOCTest ioctest = Interface.GetTEST.GetContent("TEST2");
            ioctest.Content();
        }
    }
}
