using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenpendencyInjection_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            //介面注入
            InterfaceInjection interfaceInjection = new InterfaceInjection();
            interfaceInjection.Display(new A(), "interfaceInjectionA");
            interfaceInjection.Display(new B(), " interfaceInjectionB");
            Console.WriteLine("------------------------------------------------------------------");

            //建構值注入
            ConstructorInjection constructorInjection = new ConstructorInjection(new Apple());
            constructorInjection.Display();
            constructorInjection = new ConstructorInjection(new Orange());
            constructorInjection.Display();


            Console.ReadKey();
        }
    }
}
