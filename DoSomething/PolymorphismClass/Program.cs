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
            Parent obj = new Child();
            obj.Name = "Corn";
            obj.print();

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

    abstract class A
    {
        public abstract void BBB();
    }

    class Child : Parent
    {
        new public void print()
        {
            Console.WriteLine($"Child Name : {Name}");
        }
    }
}
