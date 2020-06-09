using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageClass
{
    /// <summary>
    /// 封裝練習
    /// </summary>
    class Program : Helper
    {
        static void Main(string[] args)
        {
            //如果使用private的封裝，不管是繼承或者是new 物件來使用其private方法會無法使用
            //如果使用protected的封裝，只有自己及繼承這Class的人才能使用
            //如果使用internal的封裝，只能在相同專案中使用
            //如果使用protected internal的封裝，只有相同專案且只有自己及繼承的人可以使用

            Program p = new Program();
            p.Title2();
            p.Title3();
            p.Title4();
            p.Title5();
            Console.WriteLine("-------------------------------------------------------");

            Helper helper = new Helper();
            helper.Title2();
            helper.Title4();
            helper.Title5();

            Console.ReadKey();
        }
    }

    public class Helper
    {
        private void Title()
        {
            Console.WriteLine("Private HelloWorld");
        }

        public void Title2()
        {
            Console.WriteLine("Public HelloWorld");
        }

        protected void Title3()
        {
            Console.WriteLine("Protected HelloWorld");
        }

        internal void Title4()
        {
            Console.WriteLine("Internal HelloWorld");
        }

        protected internal void Title5()
        {
            Console.WriteLine("Protected Internal HelloWorld");
        }
    }
}
