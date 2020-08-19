using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ValueTupleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateValueTuple();
            Console.WriteLine("-------------------------------------------------------------");
            ReturnValueTuple();
            Console.WriteLine("-------------------------------------------------------------");

            DeconstructSample.GetFunc();
            

            Console.ReadKey();
        }

        /// <summary>
        /// 練習建立ValueTuple
        /// </summary>
        public static void CreateValueTuple()
        {
            // 顯式宣告使用 ValuTuple.Create methods
            ValueTuple<int, string> a1 = ValueTuple.Create<int, string>(1, "Corn");
            Console.WriteLine($"(1) {a1.Item1} : {a1.Item2}");

            // 隱式宣告使用 ValuTuple Constructor
            var a2 = (2, "Corn");
            Console.WriteLine($"(2) {a2.Item1} : {a2.Item2}");

            // 具名宣告欄位名稱 (1)
            var a3 = (abc: 3, xyz: "Corn");
            Console.WriteLine($"(3) {a3.abc} : {a3.xyz}");

            // 具名宣告欄位名稱 (2)
            (int abc, string xyz) a4 = (4, "Corn");
            Console.WriteLine($"(4) {a4.abc} : {a4.xyz}");

            // 具名宣告欄位名稱 (3) -- 會以指派運算子的左邊為主
            (int abc, string xyz) a5 = (one: 5, two: "Corn");
            Console.WriteLine($"(5) {a5.abc} : {a5.xyz}");

            foreach (var item in a5.GetType().GetFields())
            {
                Console.WriteLine($"{item.Name} : {item.GetValue(a5) }");
            }
        }

        /// <summary>
        /// 回傳ValueTuple練習
        /// </summary>
        /// <returns></returns>
        static void ReturnValueTuple()
        {
            var result01 = GetRange();
            Console.WriteLine($"Range : {result01.min} to {result01.max}");
            var (min, max) = GetRange();
            Console.WriteLine($"Range : {min} to {max}");
            var (_, Max) = GetRange();
            Console.WriteLine($"Maximum is {Max}");

            var result02 = Cal(2, 3);
            Console.WriteLine($"{result02.Item1} {result02.Item2}");
        }

        static (int min, int max) GetRange()
        {
            int min = 1;
            int max = 999;
            return (min, max);
        }
        static (string, int) Cal(int x, int y)
        {
            return ("結果是 :", x + y);
        }
    }
}
