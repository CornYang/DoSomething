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
            Program p = new Program();
            p.Help();


            NoHelper noHelper = new NoHelper();
            noHelper.NoHelp();

            Console.ReadKey();
        }
    }
}
