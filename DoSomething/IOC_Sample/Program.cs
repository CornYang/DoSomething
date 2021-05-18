using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            //非 IOC 呼叫, 上層類別 (Program) 直接倚賴實作, 而且由 Program 決定實做類別
            NoneIoc.B b = new NoneIoc.B();
            b.Show();

            // IOC 呼叫,上層類別 (Program) 倚賴 IShow 介面, 由 IocFactory 決定實做類別, Program 無須得知有哪些類別實作的 IShow 
            Ioc.IShow show = new Ioc.IocFactory().Display("B");
            show.Show();

            Console.ReadKey();
        }
    }
}
