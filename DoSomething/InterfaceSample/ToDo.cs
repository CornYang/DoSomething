using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    /// <summary>
    /// 單一繼承 + 多介面實作
    /// </summary>
    class ToDo : InterfaceTest1
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public string Show(string text)
        {
            return text;
        }
    }

    //為一般實作
    class ToDo2 : InterfaceTest1,InterfaceTest2
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        ///如果類別實作了兩個包含相同簽章之成員的介面，則在類別上實作該成員會導致兩個介面都將該成員當做實作 (Implementation) 使用
        public string Show(string text)
        {
            return text;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }

    //為明確實作
    class ToDo3 : InterfaceTest1
    {
        //明確實作的成員不需要寫存取修飾詞
        //public int InterfaceTest1.Add(int a, int b)(int a, int b)
        //{
        //    throw new NotImplementedException();
        //}

        int InterfaceTest1.Add(int a, int b)
        {
            throw new NotImplementedException();
        }

        string InterfaceTest1.Show(string text)
        {
            throw new NotImplementedException();
        }
    }

    //實作InterfaceTest1, 明確實作InterfaceTest2
    //若用明確時做就能避免一樣的方法簽章同時實作兩個介面，而可以一對一
    class ToDo4 : InterfaceTest1,InterfaceTest2
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public string Show(string text)
        {
            return text;
        }

        int InterfaceTest2.Sub(int a, int b)
        {
            return a - b;
        }

        string InterfaceTest2.Show(string text)
        {
            return text;
        }
    }

    //
    class ToDo5 : InterfaceTest1,InterfaceTest2
    {
        public string Show(string text)
        {
            return text;
        }
        int InterfaceTest1.Add(int a, int b)
        {
            return a + b;
        }

        string InterfaceTest1.Show(string text)
        {
            return text;
        }

        int InterfaceTest2.Sub(int a, int b)
        {
            return a - b;
        }

        string InterfaceTest2.Show(string text)
        {
            return text;
        }
    }
}
