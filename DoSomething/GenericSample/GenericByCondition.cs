using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSample
{
    //在泛型中，使用where條件約束類型
    class GenericByCondition
    {
        //比較struct & class 的不同處 : https://dotblogs.com.tw/daniel/2018/02/22/135011
        public T Show<T>(T val) where T : struct => val; //struct約束類型不能為null類型
        public T Show2<T>(T val) where T : class => val;//class約束類型可為null類型

        public void Show3<T>(T val) where T : SubClass //型別引數必須本身是指定的基底類別，或衍生自該類別
        {
            Console.WriteLine("where Generic condition is 約束條件為物件需繼承某個指定類別");
        }

        public T Show4<T>(T val) where T : GenericInterface<T,string> => val; //型別引數必須本身是指定的介面，或實作該介面
        public T Show5<T>(T val) where T : new() => val; //型別引數必須擁有公用的無參數建構函式
    }

    class Class01 : SubClass
    {
        
    }

    interface Interface01
    {
        string s(string text);
    }

    public class SubClass
    {
        public void AA() => Console.WriteLine("HI I'm SubClass");
    }


}
