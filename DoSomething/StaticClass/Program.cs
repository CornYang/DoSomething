using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //只要使用靜態，基本就不用再去new 一個object去使用它
            int a = Helper.GetNum(); //使用靜態類別 + 靜態方法
            int b = Helper2.GetNum(); //使用靜態方法
            Console.WriteLine(a);
            Console.WriteLine(b);

            //這邊因為Helper裡面的全域變數num已為共享的，所以上面呼叫它已讓他改變值，並不會再變回原本的
            int test = Helper.GetNum();
            Console.WriteLine(test);
            Console.WriteLine(Helper.num);//因為num為靜態，可直接使用

            //若沒有使用靜態，必須先建立一個new object，在使用
            Helper3 helper = new Helper3();
            helper.GetString();

            Console.ReadKey();
        }
    }

    //靜態類別裡面的方法必須也是靜態方法
    //靜態的使用主要好處就是專案在建立時，就會提供記憶體給靜態使用，並且不會釋放
    //靜態使用本身不需要再繼承
    static class Helper
    {
        public static int num = 5;
        public static int GetNum()
        {
            num = num + 5;
            return num;
        }

        public static int GetNum2()
        {
            return num;
        }
    }

    class Helper2
    {
        public static int num = 5;
        public static int GetNum()
        {
            return num;
        }
    }

    class Helper3
    {
        public void GetString()
        {
            Console.WriteLine("HelloWorld!");
        }
    }
}
