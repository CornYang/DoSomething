using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{
    class FuncClass
    {
        public void Display()
        {
            Person p = new Person()
            {
                Name = "Corn",
                Age = 25
            };

            Person p1 = new Person()
            {
                Name = "",
                Age = 25
            };

            Func<int, string> Show01 = new Func<int, string>(CheckAge);
            if (string.IsNullOrEmpty(p.Name))
                Console.WriteLine("無法辨識身分");
            else
                Console.WriteLine($"Hello {p.Name}!!" + Show01(p.Age));

            Func<Person, string> Show02 = (o) => CheckAge2(o);
            Console.WriteLine(Show02(p1));

            Func<string, int, string> Show03 = (x, y) =>
           {
               if (string.IsNullOrEmpty(x))
                   return "無法辨識身分";
               if (y > 50)
                   return $"Hello {x}!! 你的年紀稍大唷~";
               else
                   return $"Hello {x}!! 你還蠻年輕的耶~";
           };
            Console.WriteLine(Show03(p.Name, p.Age));

            string CheckAge(int age)
            {
                if (age > 50)
                    return " 你的年紀稍大唷~";
                else
                    return " 你還蠻年輕的耶~";
            }
        }

        string CheckAge2(Person a)
        {
            if (string.IsNullOrEmpty(a.Name))
                return "無法辨識身分";
            if (a.Age > 50)
                return $"Hello {a.Name}!! 你的年紀稍大唷~";
            else
                return $"Hello {a.Name}!! 你還蠻年輕的耶~";
        }
    }
}
