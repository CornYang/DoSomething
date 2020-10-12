using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{   
    class Program
    {
        static void Main(string[] args)
        {
            Class01 class01 = new Class01();
            var r1 = class01.Add(0, 1);
            class01.GetThing();

            Class02 class02 = new Class02();
            var r2 = class02.Add(0, 1);
            class02.GetThing();

            Class03 class03 = new Class03();
            var r3 = class03.Add(0, 1);
            class03.GetThing();

            Console.ReadKey();
        }
    }
}
