using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{
    //Action這個委託是Void，傳入參數型態是由泛型來決定
    //public delegate void Action<in T>(T obj);
    public class ActionClass
    {
        public void Display()
        {
            Person p = new Person()
            {
                Name = "David",
                Age = 51
            };

            Action<Person> Show = new Action<Person>(check);
            Show(p);

            Action<Person> Show2 = (d) => check2(d);
            Show2(p);

            Action<Person> Show3 = (d) =>
            {
                if (string.IsNullOrEmpty(d.Name))
                    Console.WriteLine("無法辨識!!");
                if (d.Age > 50)
                    Console.WriteLine($"Hello {d.Name}!! 你的年紀稍大唷~");
                else
                    Console.WriteLine($"Hello {d.Name}!! 你還蠻年輕的耶~");
            };

            Show3(p);

            void check(Person r)
            {
                if (string.IsNullOrEmpty(r.Name))
                    Console.WriteLine("無法辨識!!");
                if (r.Age > 50)
                    Console.WriteLine($"Hello {r.Name}!! 你的年紀稍大唷~");
                else
                    Console.WriteLine($"Hello {r.Name}!! 你還蠻年輕的耶~");
            }
        }

        void check2(Person r)
        {
            if (string.IsNullOrEmpty(r.Name))
                Console.WriteLine("無法辨識!!");
            if (r.Age > 50)
                Console.WriteLine($"Hello {r.Name}!! 你的年紀稍大唷~");
            else
                Console.WriteLine($"Hello {r.Name}!! 你還蠻年輕的耶~");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
