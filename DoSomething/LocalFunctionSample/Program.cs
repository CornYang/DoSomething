using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunctionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = 0;



            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine(Add(t1));
            Sub();

            Console.WriteLine("---------------------------------------------------------");

            var strlist = new List<string>() {"Edward","David","Corn","CP"};
            Show();
            Show2(strlist);

            int Add (int a)
            {
                return a + 10;
            }

            void Sub()
            {
                var t = t1 - 10;
                Console.WriteLine(t);
            }

            void Show()
            {
                foreach (var item in strlist)
                    Console.WriteLine(item);
            }

            void Show2(IEnumerable<string> list)
            {
                foreach(var item in list)
                    Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        private int Add(int a)
        {
            return a + 5;
        }

        private void Show(IEnumerable<string> list)
        {
            foreach (var item in list)
                Console.WriteLine(item);
        }
    }
}
