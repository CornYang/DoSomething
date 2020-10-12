using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    /// <summary>
    ///  abstract 練習
    ///  只能用在抽象類別
    ///  方法不提供實作(抽象不需要寫內容，類似interface)， 非抽象衍生類別必須覆寫此方法
    ///  隱含 virtual
    /// </summary>
    public abstract class BaseClass
    {
        //abstract 方法只能存在於 abstract class 中
        public abstract int Add(int a, int b);

        //抽象方法在抽象類別裡面是不需要實作的
        //public abstract void AddTest()
        //{

        //}

        // 虛擬方法的實作則可由衍生類別所取代。取代繼承之虛擬方法實作的流程，稱為覆寫方法(override)
        // vitual 方法在類別裡面是需要內容(所以必須先給內容)，但可被複寫(利用override)
        public virtual void GetThing()
        {
            Console.WriteLine("BaseClass");
        }

        public virtual void GetThing2()
        {

        }

        //抽象類別裡面可有一般成員，不一定只能擁有抽象成員
        //抽象類別裡面的一般成員，子類別如果繼承抽象類別不用去實作一般成員
        public int Add02(int a, int b)
        {
            return a + b;
        }
    }

    public  class TestClass
    {
        // abstract 方法只能存在於 abstract class(類別) 中
        //public abstract void Function01 { }
    }

    public class Class01 : BaseClass
    {
        // abstract 方法只能存在於 abstract class(類別) 中
        //public abstract void TestAbstract();

        // 覆寫方法為(override)
        // 被覆寫的基底方法必須是虛擬(virtual)、抽象(abstract)或覆寫的執行個體方法。換言之，被覆寫的基底方法不能為靜態或非虛擬。
        // 被覆寫的基底方法不能為密封方法。
        // 覆寫宣告和覆寫基底方法有相同的傳回型別。
        // 覆寫宣告和覆寫基底方法擁有相同的宣告存取層級。換言之，覆寫宣告不能更改虛擬方法的存取層級。
        public override int Add(int a, int b)
        {
            Console.WriteLine($"{a + b}");
            return a + b;
        }

        // 在同一個類別裡，同樣override 覆寫過後的方法是不能再覆寫一次的，就好像上面Add抽象方法已經覆寫(override)，這次就無法再覆寫了
        //public override int Add(int a, int b)
        //{
        //    Console.WriteLine($"{a + b}");
        //    return a + b;
        //}

        public override void GetThing()
        {
            Console.WriteLine("Class01");
        }

        public void TEST()
        {
            // 因為繼承的抽象類別裡面有一般成員，因為繼承可直接使用
            var a = Add02(1, 5);
        }
    }

    public class Class02 : BaseClass
    {
        // sealed為密封方法
        // 防止衍生類別覆寫該方法
        // 如果執行個體方法宣告包含 sealed 修飾詞，它同時也必須包含 override修飾詞(也就是sealed 必須是搭配override)
        public sealed override int Add(int a, int b)
        {
            Console.WriteLine($"{a + b + 5}");
            return a + b + 5;
        }

        public override void GetThing()
        {
            Console.WriteLine("Class02");
        }

        public sealed override void GetThing2()
        {
            Console.WriteLine("Class02-2");
        }
    }

    public class Class03 : Class02
    {
        // 因為原本繼承的Class02裡面的抽象方法被封閉(sealed)，所以無法覆寫(override)
        // 但如果繼承原來的BaseClass 就能繼續覆寫，因為最原來的沒有被Sealed
        //public override int Add(int a, int b)
        //{
        //    Console.WriteLine($"{a + b + 10}");
        //    return a + b + 5;
        //}

        public override void GetThing()
        {
            Console.WriteLine("Class03");
        }

        // 因為原本繼承的Class02裡面的抽象方法被封閉(sealed)，所以無法覆寫(override)
        //public override void GetThing2()
        //{

        //}
    }
}
