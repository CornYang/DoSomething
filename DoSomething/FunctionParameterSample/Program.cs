using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionParameterSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 0;
            Console.WriteLine($"val的初始值為 {val}");
            int res = Function01(val);
            Console.WriteLine($"退出Function01方法回到Main方法後，val的值為 {val}");
            Console.WriteLine("-----------------------------------------------------------------------");

            int val2 = 0;
            Console.WriteLine($"val的初始值為 {val2}");
            int res02 = Function02(ref val2);
            Console.WriteLine($"退出Function02方法回到Main方法後，val2的值為 {val2}");
            Console.WriteLine("-----------------------------------------------------------------------");

            ParaClass para = new ParaClass(); //先實體化ParaClass，配給para
            Console.WriteLine($"para實體中的val初始值為 {para.val}");
            ParaClass r = Function03(para);
            Console.WriteLine($"退出Function03方法回到Main方法後，para實體中的val值為 {para.val}");
            Console.WriteLine("-----------------------------------------------------------------------");

            ParaClass para2 = new ParaClass();
            Console.WriteLine($"para2實體中的val初始值為 {para2.val}");
            ParaClass res03 = Function04(ref para2);
            Console.WriteLine($"退出Function04方法回到Main方法後，para2實體中的val值為 {para2.val}");
            Console.WriteLine("Function04 回傳的實體中的 val 的值為 " + para2.val.ToString());
            Console.WriteLine("-----------------------------------------------------------------------");

            ParaClass p = new ParaClass();
            ParaClass r1 = ChangeByValue(p);
            Console.WriteLine(string.Format("r1 和 p 指向同實體 : {0}", (r1 == p)));
            ParaClass r2 = ChangeByRef(ref p);
            Console.WriteLine(string.Format("r2 和 p 指向同實體 : {0}", (r2 == p)));
            Console.WriteLine("-----------------------------------------------------------------------");

            int v1 = 0, v2; //ref 必須先將參數做初始化而out則不需要
            var result = Function05(ref v1, out v2);
            Console.WriteLine($"v1 為ref值 : {v1}  v2 為out值 : {v2}");
            Console.WriteLine("-----------------------------------------------------------------------");

            int v3 = 0, v4, v5 = 99;//ref & in 必須先將參數做初始化而out則不需要
            var result02 = Function06(ref v3, out v4, in v5);
            Console.WriteLine($"v3 為ref值 : {v3}  v4 為out值 : {v4}  v5 為in值 : {v5}");

            Console.ReadKey();
        }

        /// <summary>
        /// 取出 Main 方法中 val 的值複製一份到 Function01 方法中的 val(兩個 val 的變數位址不同)
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        private static int Function01(int val)
        {
            Console.WriteLine($"進入方法Function01時，val的初始值為 {val}");
            val = 99;
            Console.WriteLine($"在Function01方法裡重新指派值後，val的值為 {val}");
            return val;
        }

        /// <summary>
        /// 取出 Main 方法中 val2 的位址傳遞給 Function02 方法中的 val2 (兩個 val2 的變數位址相同)
        /// </summary>
        /// <param name="val2"></param>
        /// <returns></returns>
        private static int Function02(ref int val2)
        {
            Console.WriteLine($"進入方法Function01時，val2的初始值為 {val2}");
            val2 = 999;
            Console.WriteLine($"在Function01方法裡重新指派值後，val2的值為 {val2}");
            return val2;
        }

        public class ParaClass
        {
            public int val = 0;
        }

        /// <summary>
        /// 取出 Main 方法中 para 的值複製一份到 Function03 方法中的 para(兩個 para 的變數位址不同)
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        private static ParaClass Function03(ParaClass para)
        {
            Console.WriteLine($"進入方法Function03時候，para實體中val值為 {para.val}");
            para.val = 50;
            Console.WriteLine($"在Function03方法裡重新指派值給para的val，para實體中的val值為 {para.val}");
            para = new ParaClass();
            Console.WriteLine($"在Function03方法裡重新產生ParaClass的實體para，para實體中的val值為 {para.val}");
            return para;
        }

        private static ParaClass Function04(ref ParaClass para2)
        {
            Console.WriteLine($"進入方法Function04時候，para2實體中val值為 {para2.val}");
            para2.val = 500;
            Console.WriteLine($"在Function04方法裡重新指派值給para2的val，para2實體中的val值為 {para2.val}");
            para2 = new ParaClass();
            Console.WriteLine($"在Function04方法裡重新產生ParaClass的實體para，para實體中的val值為 {para2.val}");
            return para2;
        }

        //pass by value傳遞，array變數是另開一個空間(0x20)，來存這個陣列的所在位置(0x10)，但透過pass by referencs，ref array變數的位置就是跟原本arr變數一樣(0x00)，所以value也一樣(0x10)。 
        //差別就是，如果你在函式內想new一個陣列給array(等於給array變數新的參考)，就會發現pass by value完全沒有改變，
        //因為array跟原本的arr完全沒有關係，而pass by reference就成功new了
        //http://davidhsu666.com/archives/c-sharp-call-by-value-and-call-by-reference-and-equals/
        //https://dotblogs.com.tw/daniel/2018/02/26/150443

        private static ParaClass ChangeByValue(ParaClass p)
        {
            p = new ParaClass();
            return p;
        }

        private static ParaClass ChangeByRef(ref ParaClass p)
        {
            p = new ParaClass();
            return p;
        }

        /// <summary>
        /// out 與 ref 都是以 By Reference 作為參數傳遞
        /// ref 必須先將參數做初始化而out則不需要
        /// out 一定要修改傳入的參數 而 ref 則不用
        /// ref 需要在執行前初始化參數(給值) 而 out 是在程式結束前需要初始化參數(給值)
        /// 參數宣告為 out 會強迫該方法實作內部一定要產生物件
        /// https://dotblogs.com.tw/erictsaiblog/2015/05/10/151238
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        private static (int, int) Function05(ref int val1, out int val2)
        {
            // out 一定要修改傳入的參數 而 ref 則不用
            // 參數宣告為 out 會強迫該方法實作內部一定要產生物件
            val2 = 5;
            return (val1, val2);
        }

        /// <summary>
        /// 參數宣告為 in 會強迫該方法內部無法變更參數內容值
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <param name="val3"></param>
        /// <returns></returns>
        private static (int, int, int) Function06(ref int val1, out int val2, in int val3)
        {
            // out 一定要修改傳入的參數 而 ref & in 則不用
            // 參數宣告為 out 會強迫該方法實作內部一定要產生物件
            val2 = 99;
            //val3 = 0; //in 會強迫該方法內部無法變更參數內容值
            return (val1, val2, val3);
        }
    }
}
