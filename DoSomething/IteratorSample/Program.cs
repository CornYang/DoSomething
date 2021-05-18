using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorSample
{
    /// <summary>
    /// 在陳述式中使用 yield 關鍵字時，表示關鍵字所在的方法、運算子或 get 存取子是迭代器。
    /// 傳回類型必須是 IEnumerable、IEnumerable<T>、IEnumerator或 IEnumerator<T>
    /// 宣告不可包含任何 ref 或 out 參數
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string s in GetNextString())
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("--------------------------------------------------------");
            foreach (string s in GetNextString2())
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("--------------------------------------------------------");

            Console.ReadLine();
        }

        public static IEnumerable<string> GetNextString()
        {
            yield return "A";
            yield return "B";
            yield return "C";
            yield return "D";
            yield return "E";
        }

        public static IEnumerable<string> GetNextString2()
        {
            return new string[] { "A1", "B1", "C1", "D1", "E1" };
        }
    }
}
