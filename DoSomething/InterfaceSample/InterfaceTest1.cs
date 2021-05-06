using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    /// <summary>
    /// 介面是一系列方法、屬性、事件與索引的簽章
    /// 介面不能定義執行個體欄位與建構式
    /// C# 不允許在介面中定義靜態成員
    /// </summary>
    internal interface InterfaceTest1
    {
        int Add(int a, int b);
        string Show(string text);

        //介面不能定義執行個體欄位與建構式
        //public InterfaceTest1()
        //{

        //}

        //C# 不允許在介面中定義靜態成員
        //static string s(string a);
    }

    public interface InterfaceTest2
    {
        int Sub(int a, int b);
        string Show(string text);
    }
}
