using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSample
{
    class Sample03
    {
        protected string msg;
        public Sample03(string aa)
        {
            msg = aa;
        }
    }

    class Sample03_1 : Sample03
    {
        public Sample03_1() : base("Helloword!! Sample03!")
        {
            Console.WriteLine(msg);
        }
    }

    class Sample03_2 : Sample03
    {
        public Sample03_2(string bb) : base(bb)
        {
            Console.WriteLine(msg);
        }
    }
}
