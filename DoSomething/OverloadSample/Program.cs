using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadSample
{
    /// <summary>
    /// 多載(Override)練習
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.R("HelloWorld");
            Console.WriteLine(p.R(5));
            Console.WriteLine(p.R(2.0));


            Console.ReadKey();
        }

        public void R(string a)
        {
            Console.WriteLine(a);
        }

        public int R(int a)
        {
            return a + 5;
        }

        public bool R(double a)
        {
            return a > 5;
        }
    }
}