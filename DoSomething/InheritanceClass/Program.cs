using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClass
{
    /// <summary>
    /// 繼承練習
    /// 繼承只能一個(繼承為非靜態)，則實作能多個
    /// </summary>
    class Program : Helper
    {
        static void Main(string[] args)
        {
            //new  一個有繼承的類別 object，可以使用他繼承的裡面的東西
            Program p = new Program();
            p.Help();

            //如果沒有繼承，則必須使用new 一個object 來使用其裡面的方法
            NoHelper noHelper = new NoHelper();
            noHelper.NoHelp();

            Console.ReadKey();
        }
    }
}
