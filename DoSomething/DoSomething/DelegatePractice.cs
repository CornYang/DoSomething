using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace DoSomething
{
    class DelegatePractice : Content_Delegate
    {
        public delegate void delegate_action01();
        public delegate void delegate_action02(string name);

        public delegate string delegate_func01();
        public delegate bool delegate_func02(bool r);

        public void Demo01()
        {
            delegate_action01 method01 = GetAction;
            method01.Invoke();

            delegate_action01 method02 = GetAction;
            method02 += GetAction2;
            method02.Invoke();

            delegate_action01 method03 = this.GetOAction;
            method03.Invoke();


            delegate_action02 method04 = GetActionByPara01;
            method04.Invoke("Corn");

            delegate_action02 method05 = GetActionByPara01;
            method05 += GetActionByPara02;
            method05.Invoke("CornYang");

            delegate_action02 method06 = this.GetOActionByPara01;
            method06.Invoke("Corn");

            delegate_func01 method07 = GetFunc;
            WriteLine(method07.Invoke());

            delegate_func02 method08 = CheckFunc;
            WriteLine(method08.Invoke(true) ? 50 : 100);

            delegate_func02 method09 = this.GetOFunc;
            WriteLine(method09.Invoke(true) ? 50 : 100);
        }

        void GetAction()
        {
            WriteLine("委派 Action");
        }

        void GetAction2()
        {
            WriteLine("委派 Action2");
        }

        void GetActionByPara01(string name)
        {
            WriteLine($"Hello! {name}");
        }

        void GetActionByPara02(string name)
        {
            WriteLine($"Nice to meet you! {name}");
        }

        string GetFunc()
        {
            return "Hello Word";
        }

        bool CheckFunc(bool test)
        {
            return test;
        }
    }

    public class Content_Delegate
    {
        public void GetOAction()
        {
            WriteLine("委派 Action 繼承");
        }

        public void GetOActionByPara01(string name)
        {
            WriteLine($"Hello! {name} By 繼承");
        }

        public bool GetOFunc(bool r)
        {
            return !r;
        }
    }
}
