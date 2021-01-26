using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateClass delegateClass = new DelegateClass();
            delegateClass.DisplayDelegate();

            Console.WriteLine("------------------------------------------------------------");

            ActionClass actionClass = new ActionClass();
            actionClass.Display();

            Console.WriteLine("------------------------------------------------------------");

            FuncClass funcClass = new FuncClass();
            funcClass.Display();

            Console.WriteLine("------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
