using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableSample
{
    /// <summary>
    /// Nullable<T>練習
    /// Nullable Compare
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> i; // == int? i ==  System.Int32? i
            i = 100;
            Console.WriteLine(i.HasValue.ToString());
            Console.WriteLine(i.Value.ToString());
            Console.WriteLine(i.GetValueOrDefault().ToString());
            i = null;
            Console.WriteLine(i.HasValue.ToString());
            //Console.WriteLine(i.Value.ToString()); //因為為Null，所以i.Value並無Value
            Console.WriteLine(i.GetValueOrDefault().ToString());
            Console.WriteLine("----------------------------------------------------------");

            int? x = null;
            int y = 0;
            Console.WriteLine(x == y);
            Console.WriteLine(x != null);
            Console.WriteLine(x.HasValue);

            Console.ReadKey();
        }
    }
}
