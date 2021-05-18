using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC_Sample.Ioc
{
    interface IShow
    {
         void Show();
    }

    class A : IShow
    {
        public void Show() => Console.WriteLine("A");
    }

    class B : IShow
    {
        public void Show() => Console.WriteLine("B");
    }

    class IocFactory
    {
        public IShow Display(string functionname)
        {
            switch(functionname)
            {
                case "A":
                    return new A();
                case "B":
                    return new B();
                default:
                    return null;
            }
        }
    }
}
