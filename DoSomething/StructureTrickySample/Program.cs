using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureTrickySample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct myStruct = new MyStruct() { X = 1, Y = 1 };
            var myStruct2 = myStruct;
            myStruct2.X = 2;

            Console.WriteLine($"myStruct.X = {myStruct.X}");
            Console.WriteLine($"myStruct2.X = {myStruct2.X}");
            Console.WriteLine("----------------------------------------------------------");

            List<MyStruct> list = new List<MyStruct>();
            MyStruct a = new MyStruct() { X = 1, Y = 1 };
            list.Add(a);
            a.X = 999;
            Console.WriteLine(list[0].X);
            var b = list[0];
            b.X = 666;
            list[0] = b;
            Console.WriteLine(list[0].X);
            Console.WriteLine(a.X);
            Console.WriteLine("----------------------------------------------------------");

            MyStruct[] arr = new MyStruct[2];
            arr[0].X = 111;
            var o = arr[0];
            Console.WriteLine(o.X);
            o.X = 222;
            Console.WriteLine(arr[0].X);
            arr[0].X = 333;
            Console.WriteLine(arr[0].X);

            Console.ReadKey();
        }
    }

    public struct MyStruct
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}