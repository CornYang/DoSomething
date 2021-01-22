using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSample
{
    //Lambda參考網站 : https://dotblogs.com.tw/Im_sqz777/2017/07/23/225131
    class Program
    {
        //Lambda 必須包含與委派類型相同數目的參數。
        //Lambda 中的每個輸入參數都必須能夠隱含轉換為其對應的委派參數。
        //Lambda 的傳回值 (如果有的話) 必須能夠隱含轉換為委派的傳回類型。

        delegate int R(int a);
        delegate int R2(int a, int b);

        static void Main(string[] args)
        {
            //Lambda有分"運算式"&"陳述式"
            //運算式 Lambda 的基本形式 : (input parameters) => expression

            R expressionlambda = x => x * x; //這種是Lambda給的方法，而只有一個參數(x)，但因我們一開始設定委派也只設定一個參數
            int val = expressionlambda(10);
            Console.WriteLine($"{val}");

            // 這種是匿名方法
            R anonymousMethod = delegate (int a) 
            {
                return a * a;
            };
            val = anonymousMethod(6);
            Console.WriteLine(val);

            R2 expressionlambda2 = (x, y) => x * y;
            Console.WriteLine($"{expressionlambda2(2,3)}");

            ////這個方式是利用編譯器進行型別推斷，讓我們可以省去寫傳入參數型別的寫法
            //(x, y) => x + y;
            ////有時候編譯器會無法判斷輸入類型，所以出現這種情況時，就需要明確的指定類型
            //(int x, string s) => s.Length > x;
            ////只有一個傳入參數時，可以省去括號
            //x => x * x
            ////在不需要傳入參數時必須以空括號來表示
            //() => "S" + "Q" + "Z";


            //陳述式 Lambda 的基本形式 : (input parameters) => { statement; }
            //Lambda方法
            R statementLambda = x =>
            {
                x = x + 5;
                return x * x;
            };
            Console.WriteLine(statementLambda(7));

            //匿名方法
            anonymousMethod = delegate (int a)
            {
                a = a - 5;
                return a * a;
            };
            Console.WriteLine(anonymousMethod(3));

            Console.ReadLine();
        }
    }
}
