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

            ActionClass actionClass = new ActionClass();
            actionClass.Display();

            Console.ReadLine();
        }
    }
}
