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
    }

    public  class TestClass
    {
        // abstract 方法只能存在於 abstract class 中
        //public abstract void Function01 { }
    }

    public class Class01 : BaseClass
    {

    }
}
