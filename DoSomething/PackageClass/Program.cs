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
            //如果使用private，不管事繼承或者是new 物件來使用其private會無法使用
            Program p = new Program();
            p.Title2();
            Helper helper = new Helper();
            helper.Title2();


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
    }
}
