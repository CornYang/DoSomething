using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSample
{
    class Sample01
    {
        public int a = 10;

        //建構式不會繼承
        public Sample01()
        {
            a = a + 10;
            Console.WriteLine($"Helloword!! Sample01");
        }
    }

    class Sample01_1 : Sample01
    {
        public Sample01_1()
        {
            Console.WriteLine($"Sample01_1 : {a.ToString()}");
        }
    }

    class Sample01_2 : Sample01
    {
        public Sample01_2()
        {
            Console.WriteLine($"Sample01_2 : {a.ToString()}");
        }
    }
}
