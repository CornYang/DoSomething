using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sample01 show01 = new Sample01();
            Sample01_1 show01_1 = new Sample01_1();
            Sample01_2 show01_2 = new Sample01_2();
            Console.WriteLine("------------------------------------------------------------------");

            Sample02_1 show02_1 = new Sample02_1();
            Console.WriteLine("------------------------------------------------------------------");

            Sample03_1 show03_1 = new Sample03_1();
            Sample03_2 show03_2 = new Sample03_2("Helloword!! Sample03_2!");
            Console.WriteLine("------------------------------------------------------------------");

            Sample04 show04_1 = new Sample04();
            Sample04 show04_2 = new Sample04(27);

            Console.ReadKey();
        }
    }
}
