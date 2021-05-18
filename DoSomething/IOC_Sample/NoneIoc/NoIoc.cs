using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC_Sample.NoneIoc
{
    class NoIoc
    {
    }

    public class A
    {
        public void Show() => Console.WriteLine($"A");
    }

    public class B
    {
        public void Show() => Console.WriteLine($"B");
    }
}
