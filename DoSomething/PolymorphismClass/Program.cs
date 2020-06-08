using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //當你new 子類別object ，並宣告為父類別，你會發現呼叫的方法居然是父類別的，而不是子類別(無法做到多型)
            Parent obj = new Child();


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

        public virtual void Print()
        {

        }
    }

    class Child : Parent
    {
        new public void print()
        {
            Console.WriteLine($"Child Name : {Name}");
        }
    }
}
