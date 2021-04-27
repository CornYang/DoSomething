using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSample
{
    //抽象類別的建構式通常為 protected
    public abstract class Sample02
    {
        public string Msg;
        //protected Sample02()
        //{
        //    Msg = "Helloword!! Constructor Abstract~";
        //}
        public Sample02() => Msg = "Helloword!! Constructor Abstract~";
    }

    class Sample02_1 : Sample02
    {
        public Sample02_1()
        {
            Console.WriteLine(Msg);
        }
    }
}
