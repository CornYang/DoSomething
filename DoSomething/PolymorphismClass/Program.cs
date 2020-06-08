using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismClass
{
    /// <summary>
    /// 多型練習
    /// </summary>
    class Program
    {
        //繼承式多型
        static void Main(string[] args)
        {
            //當你new 子類別object ，並宣告為父類別，你會發現呼叫的方法居然是父類別的，而不是子類別(無法做到多型)
            Parent obj = new Child();

            Parent obj2 = new Child();
            obj2.Name = "玉米";
            obj2.Print(); //會依據實際的類別叫用其method的實作(去呼叫子類別了，達到多型的結果)

            Console.ReadKey();
        }
    }

    class Parent
    {
        public string Name { get; set; }
        public void print()
        {
            Console.WriteLine($"Parent Name : {Name}");
        }

        // 若再父類別的方法加上"virtual" 表示叫用該method時，編譯器必須檢視物件實際的型別，而不能只檢視參址器的型別
        public virtual void Print()
        {
            Console.WriteLine($"Parent Name : {Name}");
        }
    }

    class Child : Parent
    {
        new public void print()
        {
            Console.WriteLine($"Child Name : {Name}");
        }

        //子類別的同名method上，也必須加上override關鍵字。這代表子類別知道父類別有一個同名的method，且要用子類別的實作覆蓋父類別的實作
        public override void Print()
        {
            Console.WriteLine($"Child Name : {Name}");
        }
    }
}
