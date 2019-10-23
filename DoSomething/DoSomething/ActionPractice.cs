using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace DoSomething
{
    class ActionPractice : ActionContent
    {
        public void Demo01()
        {
            Action method01 = this.ShowMsg;
            method01 += this.ShowOMsg;
            method01(); // method.Invoke();

            Action method02 = delegate ()
            {
                this.ShowMsg();
                this.ShowOMsg();
            };
            method02();

            Action method03 = () => this.ShowOMsg();
            method03();

            Action method04 = delegate ()
            {
                this.ShowOMsgByPara("Corn");
            };
            method04();

            Action method05 = () => this.ShowOMsgByPara("Corn");
            method05();
        }

        public void ShowMsg()
        {
            WriteLine("Hello Word");
        }
    }

    class ActionContent
    {
        public void ShowOMsg()
        {
            WriteLine("Hello Word2");
        }

        public void ShowOMsgByPara(string name)
        {
            WriteLine($"Hi! {name}");
        }
    }
}
