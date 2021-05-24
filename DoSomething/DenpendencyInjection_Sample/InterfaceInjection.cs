using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenpendencyInjection_Sample
{
    /// <summary>
    /// 介面注入
    /// </summary>
    public interface IShow
    {
        void ShowText(string a);
    }
    
    public class A : IShow
    {
        public void ShowText(string a)
        {
            Console.WriteLine($"{a}");
        }
    }

    public class B : IShow
    {
        public void ShowText(string a) => Console.WriteLine($"{a}");
    }

    public interface IShowTime
    {
        /// <summary>
        /// 依賴IShow,並不是實作類別
        /// </summary>
        /// <param name="show"></param>
        void Display(IShow show, string a);
    }

    class InterfaceInjection : IShowTime
    {
        public void Display(IShow show, string a)
        {
            show.ShowText(a);
        }
    }
}
